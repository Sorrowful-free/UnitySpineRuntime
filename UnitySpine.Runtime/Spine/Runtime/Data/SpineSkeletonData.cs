using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
    [Serializable]
    public class SpineSkeletonData
    {
        [SerializeField]
        private string _hash;
        public string Hash => _hash;


        [SerializeField]
        private string _version;
        public string Version => _version;


        [SerializeField]
        private float _width;
        public float Width => _width;


        [SerializeField]
        private float _height;
        public float Height => _height;


        [SerializeField]
        private string _images;
        public string Images => _images;

        public SpineSkeletonData(string hash, string version, float width, float height, string images)
        {
            _hash = hash;
            _version = version;
            _width = width;
            _height = height;
            _images = images;
        }

        









    }
}