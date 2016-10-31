using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Bone;

namespace UnitySpine.Runtime.Spine.Runtime
{
    public class SpineSkeleton : BaseSpineObject
    {
        [SerializeField]
        private bool _flipX;
        [SerializeField]
        private bool _flipY;

        [SerializeField,HideInInspector]
        private List<SpineTransform> _roots = new List<SpineTransform>();
        public ReadOnlyCollection<SpineTransform> Roots => _roots.AsReadOnly();

        protected override void LateUpdate()
        {
            base.LateUpdate();
            UpdateContrains();
            UpdateRootsTransforms();
            UpdateSlots();
        }

        private void UpdateContrains()
        {
            foreach (var root in _roots)
            {
                root.UpdateContrains();
            }
        }

        private void UpdateRootsTransforms()
        {
            foreach (var root in _roots)
            {
                root.UpdateTransform();
            }
        }

        private void UpdateSlots()
        {
            foreach (var root in _roots)
            {
                root.UpdateSlots();
            }
        }
    }
}
