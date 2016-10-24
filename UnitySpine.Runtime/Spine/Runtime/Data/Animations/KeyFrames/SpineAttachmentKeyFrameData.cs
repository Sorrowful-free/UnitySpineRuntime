using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineAttachmentKeyFrameData : SpineBaseKeyFrameData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;
        
        public SpineAttachmentKeyFrameData(float time, string name) : base(time)
        {
            _name = name;
        }
    }
}
