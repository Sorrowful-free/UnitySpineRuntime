using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Math;

namespace UnitySpine.Runtime.Spine.Runtime.Bone
{
    public class SpineTransform : BaseSpineObject
    {
        [SerializeField,HideInInspector]
        private List<SpineTransform> _childs = new List<SpineTransform>();
        public ReadOnlyCollection<SpineTransform> Childs => _childs.AsReadOnly();

        [SerializeField, HideInInspector]
        private SpineTransform _parent;
        public SpineTransform Parent => _parent;

        [SerializeField,HideInInspector]
        private SpineSkeleton _skeleton;
        public SpineSkeleton Skeleton => _skeleton;

        public bool InherintHasChanges => (_parent != null && _parent.InherintHasChanges) || this.HasChange;

        [SerializeField,HideInInspector]
        private Matrix2D _localMatrix;
        public Matrix2D LocalMatrix { get {return _localMatrix;} protected set { _localMatrix = value; } }

        [SerializeField, HideInInspector]
        private Matrix2D _worldMatrix;
        public Matrix2D WorldMatrix { get { return _worldMatrix; } protected set { _worldMatrix = value; } }

        public float Rotation;
        public Vector2 Position;
        public Vector2 Scale = Vector2.one;
        public Vector2 Shear;

        public void SetParent(SpineTransform parent)
        {
            _parent?._childs?.Remove(this);
            _parent = parent;
            _parent?._childs?.Add(this);
            if(transform.parent != parent.transform)
                transform.SetParent(parent.transform,false);
            SetSkeleton(_parent?._skeleton);
        }

        internal void SetSkeleton(SpineSkeleton skeleton)
        {
            if (skeleton == null)
                return;
            _skeleton = skeleton;
        }

        protected override void OnTransformParentChanged()
        {
            base.OnTransformParentChanged();
            var parentSkeleton = transform?.parent?.GetComponent<SpineSkeleton>();
            if (parentSkeleton != null && parentSkeleton != _skeleton)
                SetSkeleton(parentSkeleton);
            var parentBone = transform?.parent?.GetComponent<SpineTransform>();
            if(parentBone != _parent)
                SetParent(parentBone);
        }

        internal void UpdateContrains()
        {
            foreach (var child in _childs)
            {
                child.UpdateContrains();
            }
        }

        internal void UpdateTransform()
        {
            // this update
            UpdateSelf();
            foreach (var child in _childs)
            {
                child.UpdateTransform();
            }
        }

        protected virtual void UpdateSelf()
        {
            if (InherintHasChanges)
            {
                _localMatrix = _localMatrix.Make(Scale.x, Scale.y, Position.x, Position.y, Rotation, Shear.x, Shear.y);
                _worldMatrix = _parent?._worldMatrix.Concat(_localMatrix) ?? _localMatrix;
            }
        }

        internal void UpdateSlots()
        {
            foreach (var child in _childs)
            {
                child.UpdateSlots();
            }
        }
    }
}
