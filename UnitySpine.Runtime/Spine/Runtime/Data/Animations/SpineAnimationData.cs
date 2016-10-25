using System;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.TimeLines;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    [Serializable]
    public class SpineAnimationData
    {
        [SerializeField]
        private SpineBonesTimeLineData _bones;
        public SpineBonesTimeLineData Bones => _bones;

        [SerializeField]
        private SpineSlotsTimeLineData _slots;
        public SpineSlotsTimeLineData Slots => _slots;

        public SpineAnimationData(SpineBonesTimeLineData bones, SpineSlotsTimeLineData slots)
        {
            _bones = bones;
            _slots = slots;
        }
    }
}