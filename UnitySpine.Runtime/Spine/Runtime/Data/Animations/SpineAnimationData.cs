using System;
using UnityEngine;

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

    }
}