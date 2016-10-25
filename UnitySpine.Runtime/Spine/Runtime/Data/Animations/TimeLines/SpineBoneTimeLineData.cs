using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.TimeLines
{
    [Serializable]
    public class SpineBoneTimeLineData
    {
        [SerializeField]
        private List<SpineRotationKeyFrameData> _rotate;
        public ReadOnlyCollection<SpineRotationKeyFrameData> Rotate => _rotate.AsReadOnly();

        [SerializeField]
        private List<SpineVectorKeyFrameData> _translate;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Translate => _translate.AsReadOnly();

        [SerializeField]
        private List<SpineVectorKeyFrameData> _scale;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Scale => _scale.AsReadOnly();
        
        [SerializeField]
        private List<SpineVectorKeyFrameData> _shear;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Shear => _shear.AsReadOnly();

        public SpineBoneTimeLineData(List<SpineRotationKeyFrameData> rotate, List<SpineVectorKeyFrameData> translate, List<SpineVectorKeyFrameData> scale, List<SpineVectorKeyFrameData> shear)
        {
            _rotate = rotate;
            _translate = translate;
            _scale = scale;
            _shear = shear;
        }
    }
}