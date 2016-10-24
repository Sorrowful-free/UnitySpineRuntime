using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineColorKeyFrameData:SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        private Color _color;
        public Color Color => _color;

        public SpineColorKeyFrameData(float time, Color color) : base(time)
        {
            _color = color;
        }

        public SpineColorKeyFrameData(float time, SpineKeyFrameCurveType curveType, Color color) : base(time, curveType)
        {
            _color = color;
        }

        public SpineColorKeyFrameData(float time, List<float> curveData, Color color) : base(time, curveData)
        {
            _color = color;
        }
    }
}
