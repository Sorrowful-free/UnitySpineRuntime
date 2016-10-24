using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineRotationKeyFrameData : SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        private float _angle;
        public float Angle => _angle;


        public SpineRotationKeyFrameData(float time, float angle) : base(time)
        {
            _angle = angle;
        }

        public SpineRotationKeyFrameData(float time, SpineKeyFrameCurveType curveType, float angle) : base(time, curveType)
        {
            _angle = angle;
        }

        public SpineRotationKeyFrameData(float time, List<float> curveData, float angle) : base(time, curveData)
        {
            _angle = angle;
        }
    }
}
