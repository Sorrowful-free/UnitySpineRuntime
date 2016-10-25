using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public abstract class SpineBaseCurvedKeyFrameData : SpineBaseKeyFrameData
    {
        [SerializeField]
        private SpineKeyFrameCurveType _curveType;
        public SpineKeyFrameCurveType CurveType =>_curveType;

        [SerializeField]
        private List<float> _curveData;
        public ReadOnlyCollection<float> CurveData => _curveData.AsReadOnly();

        public SpineBaseCurvedKeyFrameData(float time) : base(time)
        {
            _curveType = SpineKeyFrameCurveType.Linear;
            _curveData = new List<float> {0.5f, 0.5f, 0.5f, 0.5f};
        }

        public SpineBaseCurvedKeyFrameData(float time, SpineKeyFrameCurveType curveType) : base(time)
        {
            _curveType = curveType;
            switch (curveType)
            {
                default:
                case SpineKeyFrameCurveType.Linear:
                    _curveData = new List<float> { 0.5f, 0.5f, 0.5f, 0.5f };
                    break;
                case SpineKeyFrameCurveType.Stepped:
                    _curveData = new List<float> { 1, 0, 1, 0};
                    break;
                case SpineKeyFrameCurveType.Custom:
                    throw new Exception("please use other constructor");
                    break;
            }
        }

        public SpineBaseCurvedKeyFrameData(float time, List<float> curveData) : base(time)
        {
            _curveType = SpineKeyFrameCurveType.Custom;
            _curveData = curveData;

        }
    }

    public enum SpineKeyFrameCurveType
    {
        Linear,
        Stepped,
        Custom,
    }
}
