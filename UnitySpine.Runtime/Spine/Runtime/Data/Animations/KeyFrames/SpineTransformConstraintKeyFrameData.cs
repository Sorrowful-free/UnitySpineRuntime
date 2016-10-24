using System;
using System.Collections.Generic;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineTransformConstraintKeyFrameData : SpineBaseCurvedKeyFrameData
    {
        [SerializeField]
        [Range(0, 1)]
        private float _rotateMix;
        public float RotateMix => _rotateMix;

        [SerializeField]
        [Range(0, 1)]
        private float _translateMix;
        public float TranslateMix => _translateMix;

        [SerializeField]
        [Range(0, 1)]
        private float _scaleMix;
        public float ScaleMix => _scaleMix;


        [SerializeField]
        [Range(0, 1)]
        private float _shearMix;
        public float ShearMix => _shearMix;

        public SpineTransformConstraintKeyFrameData(float time, float rotateMix, float translateMix, float scaleMix, float shearMix) : base(time)
        {
            _rotateMix = rotateMix;
            _translateMix = translateMix;
            _scaleMix = scaleMix;
            _shearMix = shearMix;
        }

        public SpineTransformConstraintKeyFrameData(float time, SpineKeyFrameCurveType curveType, float rotateMix, float translateMix, float scaleMix, float shearMix) : base(time, curveType)
        {
            _rotateMix = rotateMix;
            _translateMix = translateMix;
            _scaleMix = scaleMix;
            _shearMix = shearMix;
        }

        public SpineTransformConstraintKeyFrameData(float time, List<float> curveData, float rotateMix, float translateMix, float scaleMix, float shearMix) : base(time, curveData)
        {
            _rotateMix = rotateMix;
            _translateMix = translateMix;
            _scaleMix = scaleMix;
            _shearMix = shearMix;
        }
    }
}
