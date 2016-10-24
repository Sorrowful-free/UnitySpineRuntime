using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Slots
{
    [Serializable]
    public class SpineSlotData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private string _bone;
        public string Bone => _bone;

        [SerializeField]
        private Color _color ;
        public Color Color => _color;

        [SerializeField]
        private string _attachment;
        public string Attachment => _attachment;

        [SerializeField]
        private SpineBlendModeType _blend;
        public SpineBlendModeType Blend => _blend;
        public SpineSlotData(string name, string bone, Color color, string attachment, SpineBlendModeType blend)
        {
            _name = name;
            _bone = bone;
            _color = color;
            _attachment = attachment;
            _blend = blend;
        }
    }
}