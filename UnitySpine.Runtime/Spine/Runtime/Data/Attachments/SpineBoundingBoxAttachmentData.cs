using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public class SpineBoundingBoxAttachmentData : SpineBaseAtachmentData
    {
        [SerializeField]
        private int _vertexCount;
        public int VertexCount => _vertexCount;

        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices.AsReadOnly();

        public SpineBoundingBoxAttachmentData(string name, Color color, int vertexCount, List<float> vertices) : base(SpineAttachmentType.BoundingBox, name, color)
        {
            _vertexCount = vertexCount;
            _vertices = vertices;
        }
    }
}