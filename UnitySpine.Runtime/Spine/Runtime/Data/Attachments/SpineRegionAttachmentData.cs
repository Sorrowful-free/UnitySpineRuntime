using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Attachments
{
    [Serializable]
    public class SpineRegionAttachmentData : SpineBaseAtachmentData
    {
        [SerializeField]
        private string _path;
        public string Path => _path;

        [SerializeField]
        private float _x;
        public float X => _x;

        [SerializeField]
        private float _y;
        public float Y => _y;

        [SerializeField]
        private float _scaleX;
        public float ScaleX => _scaleX;

        [SerializeField]
        private float _scaleY;
        public float ScaleY => _scaleY;

        [SerializeField]
        private float _rotation;
        public float Rotation => _rotation;

        [SerializeField]
        private int _width;
        public int Width => _width;

        [SerializeField]
        private int _height;
        public int Height => _height;

        public SpineRegionAttachmentData(string name, Color color, string path, float x, float y, float scaleX, float scaleY, float rotation, int width, int height) : base(SpineAttachmentType.Region, name, color)
        {
            _path = path;
            _x = x;
            _y = y;
            _scaleX = scaleX;
            _scaleY = scaleY;
            _rotation = rotation;
            _width = width;
            _height = height;
        }
    }
}