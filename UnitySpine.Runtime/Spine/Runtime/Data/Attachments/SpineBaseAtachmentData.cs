using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public abstract class SpineBaseAtachmentData
    {
        [SerializeField]
        private SpineAttachmentType _type;
        public SpineAttachmentType Type => _type;

        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private Color _color;
        public Color Color => _color;

        protected SpineBaseAtachmentData (SpineAttachmentType type, string name, Color color)
        {
            _type = type;
            _name = name;
            _color = color;
        }
    }
}