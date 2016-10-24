using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public class SpinePathAttachmnetData :SpineBaseAtachmentData
    {
        [SerializeField]
        private bool _closed;
        public bool Closed => _closed;

        [SerializeField]
        private bool _constantSpeed;
        public bool ConstantSpeed => _constantSpeed;

        [SerializeField]
        private float _length;
        public float Length => _length;

        [SerializeField]
        private int _vertexCount;
        public int VertexCount => _vertexCount;

        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices.AsReadOnly();

        public SpinePathAttachmnetData(string name, Color color, bool closed, bool constantSpeed, float length, int vertexCount, List<float> vertices) : base(SpineAttachmentType.Path, name, color)
        {
            _closed = closed;
            _constantSpeed = constantSpeed;
            _length = length;
            _vertexCount = vertexCount;
            _vertices = vertices;
        }
    }
}