using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineDeformKeyFrameData : SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        private int _offset;
        public int Offset => _offset;
        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices.AsReadOnly();

        public SpineDeformKeyFrameData(float time, int offset, List<float> vertices) : base(time)
        {
            _offset = offset;
            _vertices = vertices;
        }

        public SpineDeformKeyFrameData(float time, SpineKeyFrameCurveType curveType, int offset, List<float> vertices) : base(time, curveType)
        {
            _offset = offset;
            _vertices = vertices;
        }

        public SpineDeformKeyFrameData(float time, List<float> curveData, int offset, List<float> vertices) : base(time, curveData)
        {
            _offset = offset;
            _vertices = vertices;
        }
    }
}
