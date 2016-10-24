using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineDrawOrderKeyFrameData : SpineBaseKeyFrameData
    {
        [SerializeField]
        private List<SpineDrawOrderOffsetKeyFrameData> _offsets;
        public ReadOnlyCollection<SpineDrawOrderOffsetKeyFrameData> Offsets => _offsets.AsReadOnly();
        public SpineDrawOrderKeyFrameData(float time, List<SpineDrawOrderOffsetKeyFrameData> offsets) : base(time)
        {
            _offsets = offsets;
        }
    }

    [Serializable]
    public class SpineDrawOrderOffsetKeyFrameData
    {
        [SerializeField]
        private string _slot;
        public string Slot => _slot;

        [SerializeField]
        private int _offset;
        public int Offser => _offset;
        public SpineDrawOrderOffsetKeyFrameData(string slot, int offset)
        {
            _slot = slot;
            _offset = offset;
        }
    }
}
