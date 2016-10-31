using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime
{
    public class BaseSpineObject : MonoBehaviour
    {
        public bool HasChange { get; private set; }
        private void OnValidate()
        {
            HasChange = true;
            OnPropertyChange();
        }
        private void OnDidApplyAnimationProperties()
        {
            HasChange = true;
            OnPropertyChange();
        }
        protected virtual void OnTransformParentChanged()
        {
        }
        protected virtual void OnPropertyChange()
        {
        }

        protected virtual void Update()
        {
            HasChange = false;
        }

        protected virtual void LateUpdate()
        {
        }
    }
}
