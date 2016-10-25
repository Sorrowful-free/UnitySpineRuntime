 
// This is the output code from your template
// you only get syntax-highlighting here - not intellisense
using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;

using UnitySpine.Runtime.Spine.Runtime.Data ;
using UnitySpine.Runtime.Spine.Runtime.Data.Skins ;
using UnitySpine.Runtime.Spine.Runtime.Data.Constraints ;
using UnitySpine.Runtime.Spine.Runtime.Data.Bones ;
using UnitySpine.Runtime.Spine.Runtime.Data.Slots ;
using UnitySpine.Runtime.Spine.Runtime.Data.Events ;
using UnitySpine.Runtime.Spine.Runtime.Data.Attachments ;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations ;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames ;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.TimeLines ;

//generated classes 34

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    //Type: SpineData BaseType: Object
    public class SpineData_Generated_JsonConverter : BaseSpineJsonConverter<SpineData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _skeleton = jsonArray.TryGet<SpineSkeletonData>("skeleton", serializer);
            var _bones = jsonArray.TryGet<SpineBoneData[]>("bones", serializer);
            var _slots = jsonArray.TryGet<SpineSlotData[]>("slots", serializer);
            var _ik = jsonArray.TryGet<SpineIkConstraintsData[]>("ik", serializer);
            var _transform = jsonArray.TryGet<SpineTransformConstraintsData[]>("transform", serializer);
            var _skins = jsonArray.TryGet<SpineSkinsData>("skins", serializer);
            var _events = jsonArray.TryGet<SpineEventsData>("events", serializer);
            
            return new SpineData(
            _skeleton,
            _bones.ToList(),
            _slots.ToList(),
            _ik.ToList(),
            _transform.ToList(),
            _skins,
            _events
            );  
        }
     }
  

    //Type: SpineSkeletonData BaseType: Object
    public class SpineSkeletonData_Generated_JsonConverter : BaseSpineJsonConverter<SpineSkeletonData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _hash = jsonArray.TryGet<String>("hash", serializer);
            var _version = jsonArray.TryGet<String>("version", serializer);
            var _width = jsonArray.TryGet<Single>("width", serializer);
            var _height = jsonArray.TryGet<Single>("height", serializer);
            var _images = jsonArray.TryGet<String>("images", serializer);
            
            return new SpineSkeletonData(
            _hash,
            _version,
            _width,
            _height,
            _images
            );  
        }
     }
  

    //Type: SpineSkinData BaseType: SerializableReadOnlyDictionary`2
    public class SpineSkinData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineBaseAtachmentData>
    {
    }
  

    //Type: SpineSkinsData BaseType: SerializableReadOnlyDictionary`2
    public class SpineSkinsData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSkinData>
    {
    }
  

    //Type: SpineIkConstraintsData BaseType: Object
    public class SpineIkConstraintsData_Generated_JsonConverter : BaseSpineJsonConverter<SpineIkConstraintsData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _order = jsonArray.TryGet<Int32>("order", serializer);
            var _bones = jsonArray.TryGet<String[]>("bones", serializer);
            var _target = jsonArray.TryGet<String>("target", serializer);
            var _mix = jsonArray.TryGet<Single>("mix", serializer);
            var _bendPositive = jsonArray.TryGet<Boolean>("bendPositive", serializer);
            
            return new SpineIkConstraintsData(
            _name,
            _order,
            _bones.ToList(),
            _target,
            _mix,
            _bendPositive
            );  
        }
     }
  

    //Type: SpinePathConstrantData BaseType: Object
    public class SpinePathConstrantData_Generated_JsonConverter : BaseSpineJsonConverter<SpinePathConstrantData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _order = jsonArray.TryGet<Int32>("order", serializer);
            var _bones = jsonArray.TryGet<String[]>("bones", serializer);
            var _target = jsonArray.TryGet<String>("target", serializer);
            var _positionMode = jsonArray.TryGetEnum<SpinePathConstraintPositionMode>("positionMode", serializer, SpinePathConstraintPositionMode.Fixed);
            var _spacingMode = jsonArray.TryGetEnum<SpinePathConstraintSpacingMode>("spacingMode", serializer, SpinePathConstraintSpacingMode.Length);
            var _rotateMode = jsonArray.TryGetEnum<SpinePathConstraintRotationMode>("rotateMode", serializer, SpinePathConstraintRotationMode.Tangent);
            var _rotation = jsonArray.TryGet<Single>("rotation", serializer);
            var _position = jsonArray.TryGet<Single>("position", serializer);
            var _spacing = jsonArray.TryGet<Single>("spacing", serializer);
            var _rotateMix = jsonArray.TryGet<Single>("rotateMix", serializer);
            var _translateMix = jsonArray.TryGet<Single>("translateMix", serializer);
            
            return new SpinePathConstrantData(
            _name,
            _order,
            _bones.ToList(),
            _target,
            _positionMode,
            _spacingMode,
            _rotateMode,
            _rotation,
            _position,
            _spacing,
            _rotateMix,
            _translateMix
            );  
        }
     }
  

    //Type: SpineTransformConstraintsData BaseType: Object
    public class SpineTransformConstraintsData_Generated_JsonConverter : BaseSpineJsonConverter<SpineTransformConstraintsData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _order = jsonArray.TryGet<Int32>("order", serializer);
            var _bone = jsonArray.TryGet<String>("bone", serializer);
            var _target = jsonArray.TryGet<String>("target", serializer);
            var _rotation = jsonArray.TryGet<Single>("rotation", serializer);
            var _x = jsonArray.TryGet<Single>("x", serializer);
            var _y = jsonArray.TryGet<Single>("y", serializer);
            var _scaleX = jsonArray.TryGet<Single>("scaleX", serializer);
            var _scaleY = jsonArray.TryGet<Single>("scaleY", serializer);
            var _shearX = jsonArray.TryGet<Single>("shearX", serializer);
            var _shearY = jsonArray.TryGet<Single>("shearY", serializer);
            var _rotateMix = jsonArray.TryGet<Single>("rotateMix", serializer);
            var _translateMix = jsonArray.TryGet<Single>("translateMix", serializer);
            var _scaleMix = jsonArray.TryGet<Single>("scaleMix", serializer);
            var _shearMix = jsonArray.TryGet<Single>("shearMix", serializer);
            
            return new SpineTransformConstraintsData(
            _name,
            _order,
            _bone,
            _target,
            _rotation,
            _x,
            _y,
            _scaleX,
            _scaleY,
            _shearX,
            _shearY,
            _rotateMix,
            _translateMix,
            _scaleMix,
            _shearMix
            );  
        }
     }
  

    //Type: SpineBoneData BaseType: Object
    public class SpineBoneData_Generated_JsonConverter : BaseSpineJsonConverter<SpineBoneData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _length = jsonArray.TryGet<Single>("length", serializer);
            var _transform = jsonArray.TryGetEnum<SpineBoneTransformType>("transform", serializer, SpineBoneTransformType.Normal);
            var _x = jsonArray.TryGet<Single>("x", serializer);
            var _y = jsonArray.TryGet<Single>("y", serializer);
            var _rotation = jsonArray.TryGet<Single>("rotation", serializer);
            var _scaleX = jsonArray.TryGet<Single>("scaleX", serializer);
            var _scaleY = jsonArray.TryGet<Single>("scaleY", serializer);
            var _shearX = jsonArray.TryGet<Single>("shearX", serializer);
            var _shearY = jsonArray.TryGet<Single>("shearY", serializer);
            var _inheritScale = jsonArray.TryGet<Boolean>("inheritScale", serializer);
            var _inheritRotation = jsonArray.TryGet<Boolean>("inheritRotation", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            
            return new SpineBoneData(
            _name,
            _length,
            _transform,
            _x,
            _y,
            _rotation,
            _scaleX,
            _scaleY,
            _shearX,
            _shearY,
            _inheritScale,
            _inheritRotation,
            _color
            );  
        }
     }
  

    //Type: SpineSlotData BaseType: Object
    public class SpineSlotData_Generated_JsonConverter : BaseSpineJsonConverter<SpineSlotData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _bone = jsonArray.TryGet<String>("bone", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _attachment = jsonArray.TryGet<String>("attachment", serializer);
            var _blend = jsonArray.TryGetEnum<SpineBlendModeType>("blend", serializer, SpineBlendModeType.Normal);
            
            return new SpineSlotData(
            _name,
            _bone,
            _color,
            _attachment,
            _blend
            );  
        }
     }
  

    //Type: SpineEventData BaseType: Object
    public class SpineEventData_Generated_JsonConverter : BaseSpineJsonConverter<SpineEventData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _int = jsonArray.TryGet<Int32>("int", serializer);
            var _float = jsonArray.TryGet<Single>("float", serializer);
            var _string = jsonArray.TryGet<String>("string", serializer);
            
            return new SpineEventData(
            _int,
            _float,
            _string
            );  
        }
     }
  

    //Type: SpineEventsData BaseType: SerializableReadOnlyDictionary`2
    public class SpineEventsData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineEventData>
    {
    }
  

    //Type: SpineBoundingBoxAttachmentData BaseType: SpineBaseAtachmentData
    public class SpineBoundingBoxAttachmentData_Generated_JsonConverter : BaseSpineJsonConverter<SpineBoundingBoxAttachmentData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _type = jsonArray.TryGetEnum<SpineAttachmentType>("type", serializer, SpineAttachmentType.Region);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _vertexCount = jsonArray.TryGet<Int32>("vertexCount", serializer);
            var _vertices = jsonArray.TryGet<Single[]>("vertices", serializer);
            
            return new SpineBoundingBoxAttachmentData(
            _type,
            _name,
            _color,
            _vertexCount,
            _vertices.ToList()
            );  
        }
     }
  

    //Type: SpineLinkedMeshAttachmentData BaseType: SpineBaseAtachmentData
    public class SpineLinkedMeshAttachmentData_Generated_JsonConverter : BaseSpineJsonConverter<SpineLinkedMeshAttachmentData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _type = jsonArray.TryGetEnum<SpineAttachmentType>("type", serializer, SpineAttachmentType.Region);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _skin = jsonArray.TryGet<String>("skin", serializer);
            var _parent = jsonArray.TryGet<String>("parent", serializer);
            var _deform = jsonArray.TryGet<Boolean>("deform", serializer);
            var _width = jsonArray.TryGet<Single>("width", serializer);
            var _height = jsonArray.TryGet<Single>("height", serializer);
            
            return new SpineLinkedMeshAttachmentData(
            _type,
            _name,
            _color,
            _skin,
            _parent,
            _deform,
            _width,
            _height
            );  
        }
     }
  

    //Type: SpineMeshAttachmentData BaseType: SpineBaseAtachmentData
    public class SpineMeshAttachmentData_Generated_JsonConverter : BaseSpineJsonConverter<SpineMeshAttachmentData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _type = jsonArray.TryGetEnum<SpineAttachmentType>("type", serializer, SpineAttachmentType.Region);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _path = jsonArray.TryGet<String>("path", serializer);
            var _uvs = jsonArray.TryGet<Single[]>("uvs", serializer);
            var _triangles = jsonArray.TryGet<Int32[]>("triangles", serializer);
            var _vertices = jsonArray.TryGet<Single[]>("vertices", serializer);
            var _hull = jsonArray.TryGet<Single[]>("hull", serializer);
            var _edges = jsonArray.TryGet<Int32[]>("edges", serializer);
            var _width = jsonArray.TryGet<Int32>("width", serializer);
            var _height = jsonArray.TryGet<Int32>("height", serializer);
            
            return new SpineMeshAttachmentData(
            _type,
            _name,
            _color,
            _path,
            _uvs.ToList(),
            _triangles.ToList(),
            _vertices.ToList(),
            _hull.ToList(),
            _edges.ToList(),
            _width,
            _height
            );  
        }
     }
  

    //Type: SpinePathAttachmnetData BaseType: SpineBaseAtachmentData
    public class SpinePathAttachmnetData_Generated_JsonConverter : BaseSpineJsonConverter<SpinePathAttachmnetData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _type = jsonArray.TryGetEnum<SpineAttachmentType>("type", serializer, SpineAttachmentType.Region);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _closed = jsonArray.TryGet<Boolean>("closed", serializer);
            var _constantSpeed = jsonArray.TryGet<Boolean>("constantSpeed", serializer);
            var _length = jsonArray.TryGet<Single>("length", serializer);
            var _vertexCount = jsonArray.TryGet<Int32>("vertexCount", serializer);
            var _vertices = jsonArray.TryGet<Single[]>("vertices", serializer);
            
            return new SpinePathAttachmnetData(
            _type,
            _name,
            _color,
            _closed,
            _constantSpeed,
            _length,
            _vertexCount,
            _vertices.ToList()
            );  
        }
     }
  

    //Type: SpineRegionAttachmentData BaseType: SpineBaseAtachmentData
    public class SpineRegionAttachmentData_Generated_JsonConverter : BaseSpineJsonConverter<SpineRegionAttachmentData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _type = jsonArray.TryGetEnum<SpineAttachmentType>("type", serializer, SpineAttachmentType.Region);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            var _path = jsonArray.TryGet<String>("path", serializer);
            var _x = jsonArray.TryGet<Single>("x", serializer);
            var _y = jsonArray.TryGet<Single>("y", serializer);
            var _scaleX = jsonArray.TryGet<Single>("scaleX", serializer);
            var _scaleY = jsonArray.TryGet<Single>("scaleY", serializer);
            var _rotation = jsonArray.TryGet<Single>("rotation", serializer);
            var _width = jsonArray.TryGet<Int32>("width", serializer);
            var _height = jsonArray.TryGet<Int32>("height", serializer);
            
            return new SpineRegionAttachmentData(
            _type,
            _name,
            _color,
            _path,
            _x,
            _y,
            _scaleX,
            _scaleY,
            _rotation,
            _width,
            _height
            );  
        }
     }
  

    //Type: SpineAnimationData BaseType: Object
    public class SpineAnimationData_Generated_JsonConverter : BaseSpineJsonConverter<SpineAnimationData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _bones = jsonArray.TryGet<SpineBonesTimeLineData>("bones", serializer);
            var _slots = jsonArray.TryGet<SpineSlotsTimeLineData>("slots", serializer);
            
            return new SpineAnimationData(
            _bones,
            _slots
            );  
        }
     }
  

    //Type: SpineAnimationsData BaseType: SerializableReadOnlyDictionary`2
    public class SpineAnimationsData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineAnimationData>
    {
    }
  

    //Type: SpineIKConstraintsTimeLineData BaseType: SerializableReadOnlyDictionary`2
    public class SpineIKConstraintsTimeLineData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineIKConstraintTimeLineData>
    {
    }
  

 
    //Type: SpineIKConstraintTimeLineData BaseType: SerializableReadOnlyCollection`1
    public class SpineIKConstraintTimeLineData_Generated_JsonConverter :BaseSpineSerializableReadOnlyCollectionJsonConverter<SpineIKConstraintKeyFrameData>
    {
    }
  

    //Type: SpineColorKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineColorKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineColorKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _color = jsonArray.TryGetColor("color", serializer,"#ffffffff");
            
            return new SpineColorKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _color
            );  
        }
     }
  

    //Type: SpineDeformKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineDeformKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineDeformKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _offset = jsonArray.TryGet<Int32>("offset", serializer);
            var _vertices = jsonArray.TryGet<Single[]>("vertices", serializer);
            
            return new SpineDeformKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _offset,
            _vertices.ToList()
            );  
        }
     }
  

    //Type: SpineDrawOrderKeyFrameData BaseType: SpineBaseKeyFrameData
    public class SpineDrawOrderKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineDrawOrderKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _time = jsonArray.TryGet<Single>("time", serializer);
            var _offsets = jsonArray.TryGet<SpineDrawOrderOffsetKeyFrameData[]>("offsets", serializer);
            
            return new SpineDrawOrderKeyFrameData(
            _time,
            _offsets.ToList()
            );  
        }
     }
  

    //Type: SpineDrawOrderOffsetKeyFrameData BaseType: Object
    public class SpineDrawOrderOffsetKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineDrawOrderOffsetKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _slot = jsonArray.TryGet<String>("slot", serializer);
            var _offset = jsonArray.TryGet<Int32>("offset", serializer);
            
            return new SpineDrawOrderOffsetKeyFrameData(
            _slot,
            _offset
            );  
        }
     }
  

    //Type: SpineEventKeyframeData BaseType: SpineBaseKeyFrameData
    public class SpineEventKeyframeData_Generated_JsonConverter : BaseSpineJsonConverter<SpineEventKeyframeData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _time = jsonArray.TryGet<Single>("time", serializer);
            var _name = jsonArray.TryGet<String>("name", serializer);
            var _int = jsonArray.TryGet<Int32>("int", serializer);
            var _float = jsonArray.TryGet<Single>("float", serializer);
            var _string = jsonArray.TryGet<String>("string", serializer);
            
            return new SpineEventKeyframeData(
            _time,
            _name,
            _int,
            _float,
            _string
            );  
        }
     }
  

    //Type: SpineIKConstraintKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineIKConstraintKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineIKConstraintKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _mix = jsonArray.TryGet<Single>("mix", serializer);
            var _blendPositive = jsonArray.TryGet<Boolean>("blendPositive", serializer);
            
            return new SpineIKConstraintKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _mix,
            _blendPositive
            );  
        }
     }
  

    //Type: SpineRotationKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineRotationKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineRotationKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _angle = jsonArray.TryGet<Single>("angle", serializer);
            
            return new SpineRotationKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _angle
            );  
        }
     }
  

    //Type: SpineAttachmentKeyFrameData BaseType: SpineBaseKeyFrameData
    public class SpineAttachmentKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineAttachmentKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _time = jsonArray.TryGet<Single>("time", serializer);
            var _name = jsonArray.TryGet<String>("name", serializer);
            
            return new SpineAttachmentKeyFrameData(
            _time,
            _name
            );  
        }
     }
  

    //Type: SpineTransformConstraintKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineTransformConstraintKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineTransformConstraintKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _rotateMix = jsonArray.TryGet<Single>("rotateMix", serializer);
            var _translateMix = jsonArray.TryGet<Single>("translateMix", serializer);
            var _scaleMix = jsonArray.TryGet<Single>("scaleMix", serializer);
            var _shearMix = jsonArray.TryGet<Single>("shearMix", serializer);
            
            return new SpineTransformConstraintKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _rotateMix,
            _translateMix,
            _scaleMix,
            _shearMix
            );  
        }
     }
  

    //Type: SpineVectorKeyFrameData BaseType: SpineBaseCurvedKeyFrameData
    public class SpineVectorKeyFrameData_Generated_JsonConverter : BaseSpineJsonConverter<SpineVectorKeyFrameData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _curveType = jsonArray.TryGetEnum<SpineKeyFrameCurveType>("curveType", serializer, SpineKeyFrameCurveType.Linear);
            var _curveData = jsonArray.TryGet<Single[]>("curveData", serializer);
            var _x = jsonArray.TryGet<Single>("x", serializer);
            var _y = jsonArray.TryGet<Single>("y", serializer);
            
            return new SpineVectorKeyFrameData(
            _curveType,
            _curveData.ToList(),
            _x,
            _y
            );  
        }
     }
  

    //Type: SpineSlotsTimeLineData BaseType: SerializableReadOnlyDictionary`2
    public class SpineSlotsTimeLineData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSlotTimeLineData>
    {
    }
  

    //Type: SpineSlotTimeLineData BaseType: Object
    public class SpineSlotTimeLineData_Generated_JsonConverter : BaseSpineJsonConverter<SpineSlotTimeLineData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _attachment = jsonArray.TryGet<SpineAttachmentKeyFrameData[]>("attachment", serializer);
            var _color = jsonArray.TryGet<SpineColorKeyFrameData[]>("color", serializer);
            
            return new SpineSlotTimeLineData(
            _attachment.ToList(),
            _color.ToList()
            );  
        }
     }
  

    //Type: SpineBonesTimeLineData BaseType: SerializableReadOnlyDictionary`2
    public class SpineBonesTimeLineData_Generated_JsonConverter :BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineBoneTimeLineData>
    {
    }
  

    //Type: SpineBoneTimeLineData BaseType: Object
    public class SpineBoneTimeLineData_Generated_JsonConverter : BaseSpineJsonConverter<SpineBoneTimeLineData>
    {
         public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _rotate = jsonArray.TryGet<SpineRotationKeyFrameData[]>("rotate", serializer);
            var _translate = jsonArray.TryGet<SpineVectorKeyFrameData[]>("translate", serializer);
            var _scale = jsonArray.TryGet<SpineVectorKeyFrameData[]>("scale", serializer);
            var _shear = jsonArray.TryGet<SpineVectorKeyFrameData[]>("shear", serializer);
            
            return new SpineBoneTimeLineData(
            _rotate.ToList(),
            _translate.ToList(),
            _scale.ToList(),
            _shear.ToList()
            );  
        }
     }
  

}
 
