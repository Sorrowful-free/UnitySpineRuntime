 


using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine; 

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
// generated enums 6
#region enums
 
    public enum SpineBoneTransformType
    {
        Normal,
        OnlyTranslation,
        NoRotationOrReflection,
        NoScale,
        NoScaleOrReflection,
    }
 
    public enum SpineSlotBlendType
    {
        Normal,
        Additive,
        Multiply,
        Screen,
    }
 
    public enum SpinePathConstraintPositionModeType
    {
        Fixed,
        Percent,
    }
 
    public enum SpinePathConstraintSpacingModeType
    {
        Length,
        Fixed,
        Percent,
    }
 
    public enum SpinePathConstraintRotateModeType
    {
        Tangent,
        Chain,
        ChainScale,
    }
 
    public enum SpineAttachmentTypeType
    {
        Region,
        Mesh,
        Linkedmesh,
        Boundingbox,
        Path,
    }
#endregion


// generated classes 9
#region classes
    [Serializable]
    public class SpineData
    {
        [SerializeField]
        private SpineSkeletonData _skeleton;
        public SpineSkeletonData Skeleton => _skeleton;

        [SerializeField]
        private List<SpineBoneData> _bones;
        public ReadOnlyCollection<SpineBoneData> Bones => _bones.AsReadOnly();

        [SerializeField]
        private List<SpineSlotData> _slots;
        public ReadOnlyCollection<SpineSlotData> Slots => _slots.AsReadOnly();

        [SerializeField]
        private List<SpineIKConstraintData> _ik;
        public ReadOnlyCollection<SpineIKConstraintData> Ik => _ik.AsReadOnly();

        [SerializeField]
        private List<SpineTransformConstraintData> _transform;
        public ReadOnlyCollection<SpineTransformConstraintData> Transform => _transform.AsReadOnly();

        [SerializeField]
        private List<SpinePathConstraintData> _path;
        public ReadOnlyCollection<SpinePathConstraintData> Path => _path.AsReadOnly();

        public SpineData(
        SpineSkeletonData @skeleton,
        SpineBoneData[] @bones,
        SpineSlotData[] @slots,
        SpineIKConstraintData[] @ik,
        SpineTransformConstraintData[] @transform,
        SpinePathConstraintData[] @path)
        {
            _skeleton = @skeleton;
            _bones = @bones.ToList();
            _slots = @slots.ToList();
            _ik = @ik.ToList();
            _transform = @transform.ToList();
            _path = @path.ToList();
        }
    }

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

        public SpineSkeletonData(
        string @hash,
        string @version,
        float @width,
        float @height,
        string @images)
        {
            _hash = @hash;
            _version = @version;
            _width = @width;
            _height = @height;
            _images = @images;
        }
    }

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

        public SpineBoneData(
        string @name,
        float @length,
        SpineBoneTransformType @transform,
        float @x,
        float @y,
        float @rotation,
        float @scaleX,
        float @scaleY,
        float @shearX,
        float @shearY,
        bool @inheritScale,
        bool @inheritRotation)
        {
            _name = @name;
            _length = @length;
            _transform = @transform;
            _x = @x;
            _y = @y;
            _rotation = @rotation;
            _scaleX = @scaleX;
            _scaleY = @scaleY;
            _shearX = @shearX;
            _shearY = @shearY;
            _inheritScale = @inheritScale;
            _inheritRotation = @inheritRotation;
        }
    }

    [Serializable]
    public class SpineSlotData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private string _bone;
        public string Bone => _bone;

        [SerializeField]
        private Color _color;
        public Color Color => _color;

        [SerializeField]
        private string _attachment;
        public string Attachment => _attachment;

        [SerializeField]
        private SpineSlotBlendType _blend;
        public SpineSlotBlendType Blend => _blend;

        public SpineSlotData(
        string @name,
        string @bone,
        Color @color,
        string @attachment,
        SpineSlotBlendType @blend)
        {
            _name = @name;
            _bone = @bone;
            _color = @color;
            _attachment = @attachment;
            _blend = @blend;
        }
    }

    [Serializable]
    public class SpineIKConstraintData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _order;
        public int Order => _order;

        [SerializeField]
        private List<string> _bones;
        public ReadOnlyCollection<string> Bones => _bones.AsReadOnly();

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        private float _mix;
        public float Mix => _mix;

        [SerializeField]
        private bool _bendPositive;
        public bool BendPositive => _bendPositive;

        public SpineIKConstraintData(
        string @name,
        int @order,
        string[] @bones,
        string @target,
        float @mix,
        bool @bendPositive)
        {
            _name = @name;
            _order = @order;
            _bones = @bones.ToList();
            _target = @target;
            _mix = @mix;
            _bendPositive = @bendPositive;
        }
    }

    [Serializable]
    public class SpineTransformConstraintData
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
        private float _rotateMix;
        public float RotateMix => _rotateMix;

        [SerializeField]
        private float _translateMix;
        public float TranslateMix => _translateMix;

        [SerializeField]
        private float _scaleMix;
        public float ScaleMix => _scaleMix;

        [SerializeField]
        private float _shearMix;
        public float ShearMix => _shearMix;

        public SpineTransformConstraintData(
        string @name,
        int @order,
        string @bone,
        string @target,
        float @rotation,
        float @x,
        float @y,
        float @scaleX,
        float @scaleY,
        float @shearX,
        float @shearY,
        float @rotateMix,
        float @translateMix,
        float @scaleMix,
        float @shearMix)
        {
            _name = @name;
            _order = @order;
            _bone = @bone;
            _target = @target;
            _rotation = @rotation;
            _x = @x;
            _y = @y;
            _scaleX = @scaleX;
            _scaleY = @scaleY;
            _shearX = @shearX;
            _shearY = @shearY;
            _rotateMix = @rotateMix;
            _translateMix = @translateMix;
            _scaleMix = @scaleMix;
            _shearMix = @shearMix;
        }
    }

    [Serializable]
    public class SpinePathConstraintData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _order;
        public int Order => _order;

        [SerializeField]
        private List<string> _bones;
        public ReadOnlyCollection<string> Bones => _bones.AsReadOnly();

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        private SpinePathConstraintPositionModeType _positionMode;
        public SpinePathConstraintPositionModeType PositionMode => _positionMode;

        [SerializeField]
        private SpinePathConstraintSpacingModeType _spacingMode;
        public SpinePathConstraintSpacingModeType SpacingMode => _spacingMode;

        [SerializeField]
        private SpinePathConstraintRotateModeType _rotateMode;
        public SpinePathConstraintRotateModeType RotateMode => _rotateMode;

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
        private float _rotateMix;
        public float RotateMix => _rotateMix;

        [SerializeField]
        private float _translateMix;
        public float TranslateMix => _translateMix;

        public SpinePathConstraintData(
        string @name,
        int @order,
        string[] @bones,
        string @target,
        SpinePathConstraintPositionModeType @positionMode,
        SpinePathConstraintSpacingModeType @spacingMode,
        SpinePathConstraintRotateModeType @rotateMode,
        float @rotation,
        float @position,
        float @spacing,
        float @rotateMix,
        float @translateMix)
        {
            _name = @name;
            _order = @order;
            _bones = @bones.ToList();
            _target = @target;
            _positionMode = @positionMode;
            _spacingMode = @spacingMode;
            _rotateMode = @rotateMode;
            _rotation = @rotation;
            _position = @position;
            _spacing = @spacing;
            _rotateMix = @rotateMix;
            _translateMix = @translateMix;
        }
    }

    [Serializable]
    public class SpineAttachmentData
    {
        [SerializeField]
        private SpineAttachmentTypeType _type;
        public SpineAttachmentTypeType Type => _type;

        [SerializeField]
        private string _name;
        public string Name => _name;

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

        [SerializeField]
        private Color _color;
        public Color Color => _color;

        [SerializeField]
        private List<float> _uvs;
        public ReadOnlyCollection<float> Uvs => _uvs.AsReadOnly();

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
        private string _skin;
        public string Skin => _skin;

        [SerializeField]
        private string _parent;
        public string Parent => _parent;

        [SerializeField]
        private bool _deform;
        public bool Deform => _deform;

        [SerializeField]
        private int _vertexColor;
        public int VertexColor => _vertexColor;

        [SerializeField]
        private bool _closed;
        public bool Closed => _closed;

        [SerializeField]
        private bool _constantSpeed;
        public bool ConstantSpeed => _constantSpeed;

        [SerializeField]
        private float _lengths;
        public float Lengths => _lengths;

        public SpineAttachmentData(
        SpineAttachmentTypeType @type,
        string @name,
        string @path,
        float @x,
        float @y,
        float @scaleX,
        float @scaleY,
        float @rotation,
        int @width,
        int @height,
        Color @color,
        float[] @uvs,
        int[] @triangles,
        float[] @vertices,
        float[] @hull,
        int[] @edges,
        string @skin,
        string @parent,
        bool @deform,
        int @vertexColor,
        bool @closed,
        bool @constantSpeed,
        float @lengths)
        {
            _type = @type;
            _name = @name;
            _path = @path;
            _x = @x;
            _y = @y;
            _scaleX = @scaleX;
            _scaleY = @scaleY;
            _rotation = @rotation;
            _width = @width;
            _height = @height;
            _color = @color;
            _uvs = @uvs.ToList();
            _triangles = @triangles.ToList();
            _vertices = @vertices.ToList();
            _hull = @hull.ToList();
            _edges = @edges.ToList();
            _skin = @skin;
            _parent = @parent;
            _deform = @deform;
            _vertexColor = @vertexColor;
            _closed = @closed;
            _constantSpeed = @constantSpeed;
            _lengths = @lengths;
        }
    }

    [Serializable]
    public class SpineEventData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _int;
        public int Int => _int;

        [SerializeField]
        private float _float;
        public float Float => _float;

        [SerializeField]
        private string _string;
        public string String => _string;

        public SpineEventData(
        string @name,
        int @int,
        float @float,
        string @string)
        {
            _name = @name;
            _int = @int;
            _float = @float;
            _string = @string;
        }
    }

#endregion

   
}

