using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Constraints
{
    [Serializable]
    public class SpineTransformConstraintsData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _order;
        public int Order => _order;

        [SerializeField]
        private string _bone;
        public string Bone => _bone;

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        private float _rotation;
        public float Rotation => _rotation;

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
        private float _shearX;
        public float ShearX => _shearX;

        [SerializeField]
        private float _shearY;
        public float ShearY => _shearY;

        [SerializeField]
        [Range(0, 1)]
        private float _rotateMix;
        public float RotateMix => _rotateMix;

        [SerializeField]
        [Range(0, 1)]
        private float _translateMix;
        public float TranslateMix => _translateMix;

        [SerializeField]
        [Range(0, 1)]
        private float _scaleMix;
        public float ScaleMix => _scaleMix;

        [SerializeField]
        [Range(0, 1)]
        private float _shearMix;
        public float ShearMix => _shearMix;
        public SpineTransformConstraintsData(string name, int order, string bone, string target, float rotation, float x, float y, float scaleX, float scaleY, float shearX, float shearY, float rotateMix, float translateMix, float scaleMix, float shearMix)
        {
            _name = name;
            _order = order;
            _bone = bone;
            _target = target;
            _rotation = rotation;
            _x = x;
            _y = y;
            _scaleX = scaleX;
            _scaleY = scaleY;
            _shearX = shearX;
            _shearY = shearY;
            _rotateMix = rotateMix;
            _translateMix = translateMix;
            _scaleMix = scaleMix;
            _shearMix = shearMix;
        }
    }
}