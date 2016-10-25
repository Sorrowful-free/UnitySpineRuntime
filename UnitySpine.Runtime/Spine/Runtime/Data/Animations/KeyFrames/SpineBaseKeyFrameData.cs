using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public abstract class SpineBaseKeyFrameData
    {
        [SerializeField]
        private float _time;
        public float Time => _time;
        public SpineBaseKeyFrameData(float time)
        {
            _time = time;
        }
    }
}
