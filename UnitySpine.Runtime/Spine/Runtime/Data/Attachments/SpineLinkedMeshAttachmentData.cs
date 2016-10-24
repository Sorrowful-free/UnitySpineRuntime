using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public class SpineLinkedMeshAttachmentData : SpineBaseAtachmentData
    {
        [SerializeField]
        private string _skin;
        public string Skin => _skin;

        [SerializeField]
        private string _parent;
        public string Parent => _parent;

        [SerializeField]
        private bool _deform;
        public bool Deform => _deform;

        [SerializeField]
        private float _width;
        public float Width => _width;

        [SerializeField]
        private float _height;
        public float Height => _height;

        public SpineLinkedMeshAttachmentData(string name, Color color, string skin, string parent, bool deform, float width, float height) : base(SpineAttachmentType.LinkedMesh, name, color)
        {
            _skin = skin;
            _parent = parent;
            _deform = deform;
            _width = width;
            _height = height;
        }
    }
}