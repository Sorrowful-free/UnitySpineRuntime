 


using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine; 

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
// generated enums 6
#region enums
 
    public enum SpineBoneTransformEnum
    {
        Normal,
        OnlyTranslation,
        NoRotationOrReflection,
        NoScale,
        NoScaleOrReflection,
    }
 
    public enum SpineSlotBlendEnum
    {
        Normal,
        Additive,
        Multiply,
        Screen,
    }
 
    public enum SpinePathConstraintPositionModeEnum
    {
        Fixed,
        Percent,
    }
 
    public enum SpinePathConstraintSpacingModeEnum
    {
        Length,
        Fixed,
        Percent,
    }
 
    public enum SpinePathConstraintRotateModeEnum
    {
        Tangent,
        Chain,
        ChainScale,
    }
 
    public enum SpineAttachmentTypeEnum
    {
        Region,
        Mesh,
        Linkedmesh,
        Boundingbox,
        Path,
    }
#endregion


// generated classes 34
#region classes
    [Serializable]
    public class SpineData 
    {
        [SerializeField]
        private SpineSkeletonData _skeleton;
        public SpineSkeletonData Skeleton => _skeleton;

        [SerializeField]
        private List<SpineBoneData> _bones;
        public ReadOnlyCollection<SpineBoneData> Bones => _bones?.AsReadOnly();

        [SerializeField]
        private List<SpineSlotData> _slots;
        public ReadOnlyCollection<SpineSlotData> Slots => _slots?.AsReadOnly();

        [SerializeField]
        private List<SpineIKConstraintData> _ik;
        public ReadOnlyCollection<SpineIKConstraintData> Ik => _ik?.AsReadOnly();

        [SerializeField]
        private List<SpineTransformConstraintData> _transform;
        public ReadOnlyCollection<SpineTransformConstraintData> Transform => _transform?.AsReadOnly();

        [SerializeField]
        private List<SpinePathConstraintData> _path;
        public ReadOnlyCollection<SpinePathConstraintData> Path => _path?.AsReadOnly();

        [SerializeField]
        private SpineEventsData _events;
        public SpineEventsData Events => _events;

        [SerializeField]
        private SpineSkinsData _skins;
        public SpineSkinsData Skins => _skins;

        [SerializeField]
        private SpineAnimationsData _animations;
        public SpineAnimationsData Animations => _animations;

        public SpineData(
        SpineSkeletonData @skeleton,
        SpineBoneData[] @bones,
        SpineSlotData[] @slots,
        SpineIKConstraintData[] @ik,
        SpineTransformConstraintData[] @transform,
        SpinePathConstraintData[] @path,
        SpineEventsData @events,
        SpineSkinsData @skins,
        SpineAnimationsData @animations)
        {
            _skeleton = @skeleton;
            _bones = @bones?.ToList();
            _slots = @slots?.ToList();
            _ik = @ik?.ToList();
            _transform = @transform?.ToList();
            _path = @path?.ToList();
            _events = @events;
            _skins = @skins;
            _animations = @animations;
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

        public SpineSkeletonData(
        string @hash,
        string @version,
        float @width,
        float @height)
        {
            _hash = @hash;
            _version = @version;
            _width = @width;
            _height = @height;
        }
    }

    [Serializable]
    public class SpineBoneData 
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private string _parent;
        public string Parent => _parent;

        [SerializeField]
        private float _length;
        public float Length => _length;

        [SerializeField]
        private SpineBoneTransformEnum _transform;
        public SpineBoneTransformEnum Transform => _transform;

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
        string @parent,
        float @length,
        SpineBoneTransformEnum @transform,
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
            _parent = @parent;
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
        private SpineSlotBlendEnum _blend;
        public SpineSlotBlendEnum Blend => _blend;

        public SpineSlotData(
        string @name,
        string @bone,
        Color @color,
        string @attachment,
        SpineSlotBlendEnum @blend)
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
        public ReadOnlyCollection<string> Bones => _bones?.AsReadOnly();

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
            _bones = @bones?.ToList();
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
        public ReadOnlyCollection<string> Bones => _bones?.AsReadOnly();

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        private SpinePathConstraintPositionModeEnum _positionMode;
        public SpinePathConstraintPositionModeEnum PositionMode => _positionMode;

        [SerializeField]
        private SpinePathConstraintSpacingModeEnum _spacingMode;
        public SpinePathConstraintSpacingModeEnum SpacingMode => _spacingMode;

        [SerializeField]
        private SpinePathConstraintRotateModeEnum _rotateMode;
        public SpinePathConstraintRotateModeEnum RotateMode => _rotateMode;

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
        SpinePathConstraintPositionModeEnum @positionMode,
        SpinePathConstraintSpacingModeEnum @spacingMode,
        SpinePathConstraintRotateModeEnum @rotateMode,
        float @rotation,
        float @position,
        float @spacing,
        float @rotateMix,
        float @translateMix)
        {
            _name = @name;
            _order = @order;
            _bones = @bones?.ToList();
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
        private SpineAttachmentTypeEnum _type;
        public SpineAttachmentTypeEnum Type => _type;

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
        public ReadOnlyCollection<float> Uvs => _uvs?.AsReadOnly();

        [SerializeField]
        private List<int> _triangles;
        public ReadOnlyCollection<int> Triangles => _triangles?.AsReadOnly();

        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices?.AsReadOnly();

        [SerializeField]
        private List<float> _hull;
        public ReadOnlyCollection<float> Hull => _hull?.AsReadOnly();

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
        SpineAttachmentTypeEnum @type,
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
            _uvs = @uvs?.ToList();
            _triangles = @triangles?.ToList();
            _vertices = @vertices?.ToList();
            _hull = @hull?.ToList();
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
    public class SpineAttachmentsData : SerializableReadOnlyDictionary<string,SpineAttachmentData>
    {
        public SpineAttachmentsData(IDictionary<string,SpineAttachmentData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineSkinData : SerializableReadOnlyDictionary<string,SpineAttachmentsData>
    {
        public SpineSkinData(IDictionary<string,SpineAttachmentsData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineSkinsData : SerializableReadOnlyDictionary<string,SpineSkinData>
    {
        public SpineSkinsData(IDictionary<string,SpineSkinData> dictionary) : base(dictionary)
        {
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

    [Serializable]
    public class SpineEventsData : SerializableReadOnlyDictionary<string,SpineEventData>
    {
        public SpineEventsData(IDictionary<string,SpineEventData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineRotateKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

        [SerializeField]
        private float _angle;
        public float Angle => _angle;

        public SpineRotateKeyFrameData(
        float @time,
        float[] @curve,
        float @angle)
        {
            _time = @time;
            _curve = @curve?.ToList();
            _angle = @angle;
        }
    }

    [Serializable]
    public class SpineVectorKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

        [SerializeField]
        private float _x;
        public float X => _x;

        [SerializeField]
        private float _y;
        public float Y => _y;

        public SpineVectorKeyFrameData(
        float @time,
        float[] @curve,
        float @x,
        float @y)
        {
            _time = @time;
            _curve = @curve?.ToList();
            _x = @x;
            _y = @y;
        }
    }

    [Serializable]
    public class SpineBoneTimeLineData 
    {
        [SerializeField]
        private List<SpineRotateKeyFrameData> _rotate;
        public ReadOnlyCollection<SpineRotateKeyFrameData> Rotate => _rotate?.AsReadOnly();

        [SerializeField]
        private List<SpineVectorKeyFrameData> _translate;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Translate => _translate?.AsReadOnly();

        [SerializeField]
        private List<SpineVectorKeyFrameData> _scale;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Scale => _scale?.AsReadOnly();

        [SerializeField]
        private List<SpineVectorKeyFrameData> _shear;
        public ReadOnlyCollection<SpineVectorKeyFrameData> Shear => _shear?.AsReadOnly();

        public SpineBoneTimeLineData(
        SpineRotateKeyFrameData[] @rotate,
        SpineVectorKeyFrameData[] @translate,
        SpineVectorKeyFrameData[] @scale,
        SpineVectorKeyFrameData[] @shear)
        {
            _rotate = @rotate?.ToList();
            _translate = @translate?.ToList();
            _scale = @scale?.ToList();
            _shear = @shear?.ToList();
        }
    }

    [Serializable]
    public class SpineBonesAnimationData : SerializableReadOnlyDictionary<string,SpineBoneTimeLineData>
    {
        public SpineBonesAnimationData(IDictionary<string,SpineBoneTimeLineData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineAttachmentKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private string _name;
        public string Name => _name;

        public SpineAttachmentKeyFrameData(
        float @time,
        string @name)
        {
            _time = @time;
            _name = @name;
        }
    }

    [Serializable]
    public class SpineColorKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

        [SerializeField]
        private Color _color;
        public Color Color => _color;

        public SpineColorKeyFrameData(
        float @time,
        float[] @curve,
        Color @color)
        {
            _time = @time;
            _curve = @curve?.ToList();
            _color = @color;
        }
    }

    [Serializable]
    public class SpineSlotTimeLineData 
    {
        [SerializeField]
        private List<SpineAttachmentKeyFrameData> _attachment;
        public ReadOnlyCollection<SpineAttachmentKeyFrameData> Attachment => _attachment?.AsReadOnly();

        [SerializeField]
        private List<SpineColorKeyFrameData> _color;
        public ReadOnlyCollection<SpineColorKeyFrameData> Color => _color?.AsReadOnly();

        public SpineSlotTimeLineData(
        SpineAttachmentKeyFrameData[] @attachment,
        SpineColorKeyFrameData[] @color)
        {
            _attachment = @attachment?.ToList();
            _color = @color?.ToList();
        }
    }

    [Serializable]
    public class SpineSlotsAnimationData : SerializableReadOnlyDictionary<string,SpineSlotTimeLineData>
    {
        public SpineSlotsAnimationData(IDictionary<string,SpineSlotTimeLineData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineIKConstraintKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

        [SerializeField]
        private float _mix;
        public float Mix => _mix;

        [SerializeField]
        private bool _bendPositive;
        public bool BendPositive => _bendPositive;

        public SpineIKConstraintKeyFrameData(
        float @time,
        float[] @curve,
        float @mix,
        bool @bendPositive)
        {
            _time = @time;
            _curve = @curve?.ToList();
            _mix = @mix;
            _bendPositive = @bendPositive;
        }
    }

    [Serializable]
    public class SpineIKConstraintsAnimationData : SerializableReadOnlyDictionary<string,SpineIKConstraintKeyFrameData[]>
    {
        public SpineIKConstraintsAnimationData(IDictionary<string,SpineIKConstraintKeyFrameData[]> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineTransformConstraintKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

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

        public SpineTransformConstraintKeyFrameData(
        float @time,
        float[] @curve,
        float @rotateMix,
        float @translateMix,
        float @scaleMix,
        float @shearMix)
        {
            _time = @time;
            _curve = @curve?.ToList();
            _rotateMix = @rotateMix;
            _translateMix = @translateMix;
            _scaleMix = @scaleMix;
            _shearMix = @shearMix;
        }
    }

    [Serializable]
    public class SpineTransformConstraintsAnimationData : SerializableReadOnlyDictionary<string,SpineTransformConstraintKeyFrameData[]>
    {
        public SpineTransformConstraintsAnimationData(IDictionary<string,SpineTransformConstraintKeyFrameData[]> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineDeformKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private int _offset;
        public int Offset => _offset;

        [SerializeField]
        private List<float> _vertices;
        public ReadOnlyCollection<float> Vertices => _vertices?.AsReadOnly();

        [SerializeField]
        private List<float> _curve;
        public ReadOnlyCollection<float> Curve => _curve?.AsReadOnly();

        public SpineDeformKeyFrameData(
        float @time,
        int @offset,
        float[] @vertices,
        float[] @curve)
        {
            _time = @time;
            _offset = @offset;
            _vertices = @vertices?.ToList();
            _curve = @curve?.ToList();
        }
    }

    [Serializable]
    public class SpineDeformTimeLineData : SerializableReadOnlyDictionary<string,SpineDeformKeyFrameData[]>
    {
        public SpineDeformTimeLineData(IDictionary<string,SpineDeformKeyFrameData[]> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineDeformSlotTimeLineData : SerializableReadOnlyDictionary<string,SpineDeformTimeLineData>
    {
        public SpineDeformSlotTimeLineData(IDictionary<string,SpineDeformTimeLineData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineDeformsAnimationData : SerializableReadOnlyDictionary<string,SpineDeformSlotTimeLineData>
    {
        public SpineDeformsAnimationData(IDictionary<string,SpineDeformSlotTimeLineData> dictionary) : base(dictionary)
        {
        }
    }

    [Serializable]
    public class SpineEventKeyframeData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

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

        public SpineEventKeyframeData(
        float @time,
        string @name,
        int @int,
        float @float,
        string @string)
        {
            _time = @time;
            _name = @name;
            _int = @int;
            _float = @float;
            _string = @string;
        }
    }

    [Serializable]
    public class SpineDrawOrderSlotKeyFrameData 
    {
        [SerializeField]
        private string _slot;
        public string Slot => _slot;

        [SerializeField]
        private int _offset;
        public int Offset => _offset;

        public SpineDrawOrderSlotKeyFrameData(
        string @slot,
        int @offset)
        {
            _slot = @slot;
            _offset = @offset;
        }
    }

    [Serializable]
    public class SpineDrawOrderKeyFrameData 
    {
        [SerializeField]
        private float _time;
        public float Time => _time;

        [SerializeField]
        private SpineDrawOrderSlotKeyFrameData _offsets;
        public SpineDrawOrderSlotKeyFrameData Offsets => _offsets;

        public SpineDrawOrderKeyFrameData(
        float @time,
        SpineDrawOrderSlotKeyFrameData @offsets)
        {
            _time = @time;
            _offsets = @offsets;
        }
    }

    [Serializable]
    public class SpineAnimationData 
    {
        [SerializeField]
        private SpineBonesAnimationData _bones;
        public SpineBonesAnimationData Bones => _bones;

        [SerializeField]
        private SpineSlotsAnimationData _slots;
        public SpineSlotsAnimationData Slots => _slots;

        [SerializeField]
        private SpineIKConstraintsAnimationData _ik;
        public SpineIKConstraintsAnimationData Ik => _ik;

        [SerializeField]
        private SpineTransformConstraintsAnimationData _transform;
        public SpineTransformConstraintsAnimationData Transform => _transform;

        [SerializeField]
        private SpineDeformsAnimationData _deform;
        public SpineDeformsAnimationData Deform => _deform;

        [SerializeField]
        private List<SpineEventKeyframeData> _events;
        public ReadOnlyCollection<SpineEventKeyframeData> Events => _events?.AsReadOnly();

        [SerializeField]
        private List<SpineDrawOrderKeyFrameData> _draworder;
        public ReadOnlyCollection<SpineDrawOrderKeyFrameData> Draworder => _draworder?.AsReadOnly();

        public SpineAnimationData(
        SpineBonesAnimationData @bones,
        SpineSlotsAnimationData @slots,
        SpineIKConstraintsAnimationData @ik,
        SpineTransformConstraintsAnimationData @transform,
        SpineDeformsAnimationData @deform,
        SpineEventKeyframeData[] @events,
        SpineDrawOrderKeyFrameData[] @draworder)
        {
            _bones = @bones;
            _slots = @slots;
            _ik = @ik;
            _transform = @transform;
            _deform = @deform;
            _events = @events?.ToList();
            _draworder = @draworder?.ToList();
        }
    }

    [Serializable]
    public class SpineAnimationsData : SerializableReadOnlyDictionary<string,SpineAnimationData>
    {
        public SpineAnimationsData(IDictionary<string,SpineAnimationData> dictionary) : base(dictionary)
        {
        }
    }

#endregion
}

