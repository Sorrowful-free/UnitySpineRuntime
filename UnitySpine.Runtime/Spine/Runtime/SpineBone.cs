using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Bone;

namespace UnitySpine.Runtime.Spine.Runtime
{
    public class SpineBone : SpineTransform
    {
        [SerializeField]
        private bool _inheritRotation;
        [SerializeField]
        private bool _inheritScale;
        protected override void UpdateSelf()
        {
            if (InherintHasChanges)
            {
                LocalMatrix = LocalMatrix.Make(Scale.x, Scale.y, Position.x, Position.y, Rotation, Shear.x, Shear.y);
                WorldMatrix = Parent?.WorldMatrix.Concat(LocalMatrix, _inheritRotation, _inheritScale) ?? LocalMatrix;
            }
        }
    }
}
