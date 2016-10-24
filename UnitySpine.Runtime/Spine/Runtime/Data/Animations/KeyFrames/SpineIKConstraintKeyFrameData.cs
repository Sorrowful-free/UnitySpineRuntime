using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineIKConstraintKeyFrameData : SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        [Range(0,1)]
        private float _mix;
        public float Mix => _mix;

        [SerializeField]
        private bool _blendPositive;
        public bool BlendPositive => _blendPositive;

        public SpineIKConstraintKeyFrameData(float time, float mix, bool blendPositive) : base(time)
        {
            _mix = mix;
            _blendPositive = blendPositive;
        }

        public SpineIKConstraintKeyFrameData(float time, SpineKeyFrameCurveType curveType, float mix, bool blendPositive) : base(time, curveType)
        {
            _mix = mix;
            _blendPositive = blendPositive;
        }

        public SpineIKConstraintKeyFrameData(float time, List<float> curveData, float mix, bool blendPositive) : base(time, curveData)
        {
            _mix = mix;
            _blendPositive = blendPositive;
        }
    }
}
