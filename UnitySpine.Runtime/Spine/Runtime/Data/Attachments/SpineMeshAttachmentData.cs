using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public class SpineMeshAttachmentData : SpineBaseAtachmentData
    {
        [SerializeField]
        private string _path;
        public string Path => _path;

        [SerializeField]
        private List<float> _uvs;
        public ReadOnlyCollection<float> UVs => _uvs.AsReadOnly();

        [SerializeField]
        private List<int> _triangles;
        public ReadOnlyCollection<int> Triangles => _triangles.AsReadOnly();

        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices.AsReadOnly();

        [SerializeField]
        private List<float> _hull;
        public ReadOnlyCollection<float> Hull => _hull.AsReadOnly();

        [SerializeField]
        private List<int> _edges;
        public ReadOnlyCollection<int> Edges => _edges.AsReadOnly();

        [SerializeField]
        private int _width;
        public int Width => _width;

        [SerializeField]
        private int _height;
        public int Height => _height;

        public SpineMeshAttachmentData(string name, Color color, string path, List<float> uvs, List<int> triangles, List<float> vertices, List<float> hull, List<int> edges, int width, int height) : base(SpineAttachmentType.Mesh, name, color)
        {
            _path = path;
            _uvs = uvs;
            _triangles = triangles;
            _vertices = vertices;
            _hull = hull;
            _edges = edges;
            _width = width;
            _height = height;
        }
    }
}