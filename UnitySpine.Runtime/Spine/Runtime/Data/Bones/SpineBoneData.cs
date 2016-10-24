using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Bones
{
    [Serializable]
    public class SpineBoneData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;


        [SerializeField]
        private float _length;
        public float Length => _length;


        [SerializeField]
        private SpineBoneTransformType _transform;
        public SpineBoneTransformType Transform => _transform;
        

        [SerializeField]
        private float _x;
        public float X => _x;


        [SerializeField]
        private float _y;
        public float Y => _y;


        [SerializeField]
        private float _rotation;
        public float Rotation => _rotation;


        [SerializeField]
        private float _scaleX;
        public float ScaleX => _scaleX;


        [SerializeField]
        private float _scaleY;
        public float ScaleY => _scaleY;


        [SerializeField]
        private float _shearX;
        public float ShearX => _shearX;


        [SerializeField]
        private float _shearY;
        public float ShearY => _shearY;


        [SerializeField]
        private bool _inheritScale;
        public bool InheritScale => _inheritScale;


        [SerializeField]
        private bool _inheritRotation;
        public bool InheritRotation => _inheritRotation;


        [SerializeField] private Color _color;
        public Color Color => _color;
        public SpineBoneData(string name, float length, SpineBoneTransformType transform, float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY, bool inheritScale, bool inheritRotation, Color color)
        {
            _name = name;
            _length = length;
            _transform = transform;
            _x = x;
            _y = y;
            _rotation = rotation;
            _scaleX = scaleX;
            _scaleY = scaleY;
            _shearX = shearX;
            _shearY = shearY;
            _inheritScale = inheritScale;
            _inheritRotation = inheritRotation;
            _color = color;
        }
    }
}