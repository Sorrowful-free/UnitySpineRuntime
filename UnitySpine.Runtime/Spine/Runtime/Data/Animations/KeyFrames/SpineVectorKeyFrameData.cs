using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineVectorKeyFrameData : SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        private float _x;
        public float X => _x;

        [SerializeField]
        private float _y;
        public float Y => _y;

        public SpineVectorKeyFrameData(float time, float y, float x) : base(time)
        {
            _y = y;
            _x = x;
        }

        public SpineVectorKeyFrameData(float time, SpineKeyFrameCurveType curveType, float y, float x) : base(time, curveType)
        {
            _y = y;
            _x = x;
        }

        public SpineVectorKeyFrameData(float time, List<float> curveData, float y, float x) : base(time, curveData)
        {
            _y = y;
            _x = x;
        }
    }
}
