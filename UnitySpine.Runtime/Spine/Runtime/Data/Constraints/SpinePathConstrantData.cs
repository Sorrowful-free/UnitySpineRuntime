using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Constraints
{
    [Serializable]
    public class SpinePathConstrantData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _order;
        public int Order => _order;

        [SerializeField]
        private List<string> _bones;
        public ReadOnlyCollection<string> Bone => _bones.AsReadOnly();

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        private SpinePathConstraintPositionMode _positionMode;
        public SpinePathConstraintPositionMode PositionMode => _positionMode;

        [SerializeField]
        private SpinePathConstraintSpacingMode _spacingMode;
        public SpinePathConstraintSpacingMode SpacingMode => _spacingMode;

        [SerializeField]
        private SpinePathConstraintRotationMode _rotateMode;
        public SpinePathConstraintRotationMode RotateMode => _rotateMode;

        [SerializeField]
        private float _rotation;
        public float Rotation => _rotation;

        [SerializeField]
        private float _position;
        public float Position => _position;

        [SerializeField]
        private float _spacing;
        public float Spacing => _spacing;

        [SerializeField]
        [Range(0,1)]
        private float _rotateMix;
        public float RotateMix => _rotateMix;

        [SerializeField]
        [Range(0, 1)]
        private float _translateMix;
        public float TranslateMix => _translateMix;
        public SpinePathConstrantData(string name, int order, List<string> bones, string target, SpinePathConstraintPositionMode positionMode, SpinePathConstraintSpacingMode spacingMode, SpinePathConstraintRotationMode rotateMode, float rotation, float position, float spacing, float rotateMix, float translateMix)
        {
            _name = name;
            _order = order;
            _bones = bones;
            _target = target;
            _positionMode = positionMode;
            _spacingMode = spacingMode;
            _rotateMode = rotateMode;
            _rotation = rotation;
            _position = position;
            _spacing = spacing;
            _rotateMix = rotateMix;
            _translateMix = translateMix;
        }
    }
}
