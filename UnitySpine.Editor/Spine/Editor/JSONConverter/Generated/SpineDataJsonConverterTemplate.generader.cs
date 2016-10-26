 

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
// generated converters 33

    public class SpineDataJsonConverter : BaseSpineJsonConverter<SpineData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @skeleton = jsonArray.TryGet<SpineSkeletonData>("skeleton", serializer);
            var @bones = jsonArray.TryGet<SpineBoneData[]>("bones", serializer);
            var @slots = jsonArray.TryGet<SpineSlotData[]>("slots", serializer);
            var @ik = jsonArray.TryGet<SpineIKConstraintData[]>("ik", serializer);
            var @transform = jsonArray.TryGet<SpineTransformConstraintData[]>("transform", serializer);
            var @path = jsonArray.TryGet<SpinePathConstraintData[]>("path", serializer);
            var @events = jsonArray.TryGet<SpineEventsData>("events", serializer);
            var @skins = jsonArray.TryGet<SpineSkinsData>("skins", serializer);

            return new SpineData(
            @skeleton,
            @bones,
            @slots,
            @ik,
            @transform,
            @path,
            @events,
            @skins);
        }
    }

    public class SpineSkeletonDataJsonConverter : BaseSpineJsonConverter<SpineSkeletonData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @hash = jsonArray.TryGet<string>("hash", serializer);
            var @version = jsonArray.TryGet<string>("version", serializer);
            var @width = jsonArray.TryGet<float>("width", serializer);
            var @height = jsonArray.TryGet<float>("height", serializer);
            var @images = jsonArray.TryGet<string>("images", serializer);

            return new SpineSkeletonData(
            @hash,
            @version,
            @width,
            @height,
            @images);
        }
    }

    public class SpineBoneDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @length = jsonArray.TryGet<float>("length", serializer);
            var @transform = jsonArray.TryGetEnum<SpineBoneTransformType>("transform", serializer,SpineBoneTransformType.Normal);
            var @x = jsonArray.TryGet<float>("x", serializer);
            var @y = jsonArray.TryGet<float>("y", serializer);
            var @rotation = jsonArray.TryGet<float>("rotation", serializer);
            var @scaleX = jsonArray.TryGet<float>("scaleX", serializer,1);
            var @scaleY = jsonArray.TryGet<float>("scaleY", serializer,1);
            var @shearX = jsonArray.TryGet<float>("shearX", serializer);
            var @shearY = jsonArray.TryGet<float>("shearY", serializer);
            var @inheritScale = jsonArray.TryGet<bool>("inheritScale", serializer,true);
            var @inheritRotation = jsonArray.TryGet<bool>("inheritRotation", serializer,true);

            return new SpineBoneData(
            @name,
            @length,
            @transform,
            @x,
            @y,
            @rotation,
            @scaleX,
            @scaleY,
            @shearX,
            @shearY,
            @inheritScale,
            @inheritRotation);
        }
    }

    public class SpineSlotDataJsonConverter : BaseSpineJsonConverter<SpineSlotData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @bone = jsonArray.TryGet<string>("bone", serializer);
            var @color = jsonArray.TryGetColor("color", serializer,"0xFFFFFFFF");
            var @attachment = jsonArray.TryGet<string>("attachment", serializer);
            var @blend = jsonArray.TryGetEnum<SpineSlotBlendType>("blend", serializer,SpineSlotBlendType.Normal);

            return new SpineSlotData(
            @name,
            @bone,
            @color,
            @attachment,
            @blend);
        }
    }

    public class SpineIKConstraintDataJsonConverter : BaseSpineJsonConverter<SpineIKConstraintData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @order = jsonArray.TryGet<int>("order", serializer);
            var @bones = jsonArray.TryGet<string[]>("bones", serializer);
            var @target = jsonArray.TryGet<string>("target", serializer);
            var @mix = jsonArray.TryGet<float>("mix", serializer,1);
            var @bendPositive = jsonArray.TryGet<bool>("bendPositive", serializer,false);

            return new SpineIKConstraintData(
            @name,
            @order,
            @bones,
            @target,
            @mix,
            @bendPositive);
        }
    }

    public class SpineTransformConstraintDataJsonConverter : BaseSpineJsonConverter<SpineTransformConstraintData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @order = jsonArray.TryGet<int>("order", serializer);
            var @bone = jsonArray.TryGet<string>("bone", serializer);
            var @target = jsonArray.TryGet<string>("target", serializer);
            var @rotation = jsonArray.TryGet<float>("rotation", serializer);
            var @x = jsonArray.TryGet<float>("x", serializer);
            var @y = jsonArray.TryGet<float>("y", serializer);
            var @scaleX = jsonArray.TryGet<float>("scaleX", serializer,1);
            var @scaleY = jsonArray.TryGet<float>("scaleY", serializer,1);
            var @shearX = jsonArray.TryGet<float>("shearX", serializer);
            var @shearY = jsonArray.TryGet<float>("shearY", serializer);
            var @rotateMix = jsonArray.TryGet<float>("rotateMix", serializer,1);
            var @translateMix = jsonArray.TryGet<float>("translateMix", serializer,1);
            var @scaleMix = jsonArray.TryGet<float>("scaleMix", serializer,1);
            var @shearMix = jsonArray.TryGet<float>("shearMix", serializer,1);

            return new SpineTransformConstraintData(
            @name,
            @order,
            @bone,
            @target,
            @rotation,
            @x,
            @y,
            @scaleX,
            @scaleY,
            @shearX,
            @shearY,
            @rotateMix,
            @translateMix,
            @scaleMix,
            @shearMix);
        }
    }

    public class SpinePathConstraintDataJsonConverter : BaseSpineJsonConverter<SpinePathConstraintData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @order = jsonArray.TryGet<int>("order", serializer);
            var @bones = jsonArray.TryGet<string[]>("bones", serializer);
            var @target = jsonArray.TryGet<string>("target", serializer);
            var @positionMode = jsonArray.TryGetEnum<SpinePathConstraintPositionModeType>("positionMode", serializer,SpinePathConstraintPositionModeType.Percent);
            var @spacingMode = jsonArray.TryGetEnum<SpinePathConstraintSpacingModeType>("spacingMode", serializer,SpinePathConstraintSpacingModeType.Length);
            var @rotateMode = jsonArray.TryGetEnum<SpinePathConstraintRotateModeType>("rotateMode", serializer,SpinePathConstraintRotateModeType.Tangent);
            var @rotation = jsonArray.TryGet<float>("rotation", serializer);
            var @position = jsonArray.TryGet<float>("position", serializer);
            var @spacing = jsonArray.TryGet<float>("spacing", serializer);
            var @rotateMix = jsonArray.TryGet<float>("rotateMix", serializer,1);
            var @translateMix = jsonArray.TryGet<float>("translateMix", serializer,1);

            return new SpinePathConstraintData(
            @name,
            @order,
            @bones,
            @target,
            @positionMode,
            @spacingMode,
            @rotateMode,
            @rotation,
            @position,
            @spacing,
            @rotateMix,
            @translateMix);
        }
    }

    public class SpineAttachmentDataJsonConverter : BaseSpineJsonConverter<SpineAttachmentData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @type = jsonArray.TryGetEnum<SpineAttachmentTypeType>("type", serializer,SpineAttachmentTypeType.Region);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @path = jsonArray.TryGet<string>("path", serializer);
            var @x = jsonArray.TryGet<float>("x", serializer);
            var @y = jsonArray.TryGet<float>("y", serializer);
            var @scaleX = jsonArray.TryGet<float>("scaleX", serializer,1);
            var @scaleY = jsonArray.TryGet<float>("scaleY", serializer,1);
            var @rotation = jsonArray.TryGet<float>("rotation", serializer);
            var @width = jsonArray.TryGet<int>("width", serializer);
            var @height = jsonArray.TryGet<int>("height", serializer);
            var @color = jsonArray.TryGetColor("color", serializer,"0xFFFFFFFF");
            var @uvs = jsonArray.TryGet<float[]>("uvs", serializer);
            var @triangles = jsonArray.TryGet<int[]>("triangles", serializer);
            var @vertices = jsonArray.TryGet<float[]>("vertices", serializer);
            var @hull = jsonArray.TryGet<float[]>("hull", serializer);
            var @edges = jsonArray.TryGet<int[]>("edges", serializer);
            var @skin = jsonArray.TryGet<string>("skin", serializer);
            var @parent = jsonArray.TryGet<string>("parent", serializer);
            var @deform = jsonArray.TryGet<bool>("deform", serializer,true);
            var @vertexColor = jsonArray.TryGet<int>("vertexColor", serializer);
            var @closed = jsonArray.TryGet<bool>("closed", serializer);
            var @constantSpeed = jsonArray.TryGet<bool>("constantSpeed", serializer,true);
            var @lengths = jsonArray.TryGet<float>("lengths", serializer);

            return new SpineAttachmentData(
            @type,
            @name,
            @path,
            @x,
            @y,
            @scaleX,
            @scaleY,
            @rotation,
            @width,
            @height,
            @color,
            @uvs,
            @triangles,
            @vertices,
            @hull,
            @edges,
            @skin,
            @parent,
            @deform,
            @vertexColor,
            @closed,
            @constantSpeed,
            @lengths);
        }
    }

    public class SpineSkinDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSkinData>
    {
    }

    public class SpineSkinsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSkinsData>
    {
    }

    public class SpineEventDataJsonConverter : BaseSpineJsonConverter<SpineEventData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @int = jsonArray.TryGet<int>("int", serializer);
            var @float = jsonArray.TryGet<float>("float", serializer);
            var @string = jsonArray.TryGet<string>("string", serializer);

            return new SpineEventData(
            @name,
            @int,
            @float,
            @string);
        }
    }

    public class SpineEventsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineEventsData>
    {
    }

    public class SpineRotateKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineRotateKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");
            var @angle = jsonArray.TryGet<float>("angle", serializer);

            return new SpineRotateKeyFrameData(
            @time,
            @curve,
            @angle);
        }
    }

    public class SpineVectorKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineVectorKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");
            var @x = jsonArray.TryGet<float>("x", serializer);
            var @y = jsonArray.TryGet<float>("y", serializer);

            return new SpineVectorKeyFrameData(
            @time,
            @curve,
            @x,
            @y);
        }
    }

    public class SpineBoneTimeLineDataJsonConverter : BaseSpineJsonConverter<SpineBoneTimeLineData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @rotate = jsonArray.TryGet<SpineRotateKeyFrameData[]>("rotate", serializer);
            var @translate = jsonArray.TryGet<SpineVectorKeyFrameData[]>("translate", serializer);
            var @scale = jsonArray.TryGet<SpineVectorKeyFrameData[]>("scale", serializer);
            var @shear = jsonArray.TryGet<SpineVectorKeyFrameData[]>("shear", serializer);

            return new SpineBoneTimeLineData(
            @rotate,
            @translate,
            @scale,
            @shear);
        }
    }

    public class SpineBonesAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineBonesAnimationData>
    {
    }

    public class SpineAttachmentKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineAttachmentKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @name = jsonArray.TryGet<string>("name", serializer);

            return new SpineAttachmentKeyFrameData(
            @time,
            @name);
        }
    }

    public class SpineColorKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineColorKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");
            var @color = jsonArray.TryGetColor("color", serializer,"0xFFFFFFFF");

            return new SpineColorKeyFrameData(
            @time,
            @curve,
            @color);
        }
    }

    public class SpineSlotTimeLineDataJsonConverter : BaseSpineJsonConverter<SpineSlotTimeLineData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @attachment = jsonArray.TryGet<SpineAttachmentKeyFrameData[]>("attachment", serializer);
            var @color = jsonArray.TryGet<SpineColorKeyFrameData[]>("color", serializer);

            return new SpineSlotTimeLineData(
            @attachment,
            @color);
        }
    }

    public class SpineSlotsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSlotsAnimationData>
    {
    }

    public class SpineIKConstraintKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineIKConstraintKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");
            var @mix = jsonArray.TryGet<float>("mix", serializer);
            var @bendPositive = jsonArray.TryGet<bool>("bendPositive", serializer);

            return new SpineIKConstraintKeyFrameData(
            @time,
            @curve,
            @mix,
            @bendPositive);
        }
    }

    public class SpineIKConstraintsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineIKConstraintsAnimationData>
    {
    }

    public class SpineTransformConstraintKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineTransformConstraintKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");
            var @rotateMix = jsonArray.TryGet<float>("rotateMix", serializer,1);
            var @translateMix = jsonArray.TryGet<float>("translateMix", serializer,1);
            var @scaleMix = jsonArray.TryGet<float>("scaleMix", serializer,1);
            var @shearMix = jsonArray.TryGet<float>("shearMix", serializer,1);

            return new SpineTransformConstraintKeyFrameData(
            @time,
            @curve,
            @rotateMix,
            @translateMix,
            @scaleMix,
            @shearMix);
        }
    }

    public class SpineTransformConstraintsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineTransformConstraintsAnimationData>
    {
    }

    public class SpineDeformKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineDeformKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @offset = jsonArray.TryGet<int>("offset", serializer);
            var @vertices = jsonArray.TryGet<float[]>("vertices", serializer);
            var @curve = jsonArray.TryGet<string>("curve", serializer,"linear");

            return new SpineDeformKeyFrameData(
            @time,
            @offset,
            @vertices,
            @curve);
        }
    }

    public class SpineDeformTimeLineDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformTimeLineData>
    {
    }

    public class SpineDeformSlotTimeLineDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformSlotTimeLineData>
    {
    }

    public class SpineDeformsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformsAnimationData>
    {
    }

    public class SpineEventKeyframeDataJsonConverter : BaseSpineJsonConverter<SpineEventKeyframeData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @name = jsonArray.TryGet<string>("name", serializer);
            var @int = jsonArray.TryGet<int>("int", serializer);
            var @float = jsonArray.TryGet<float>("float", serializer);
            var @string = jsonArray.TryGet<string>("string", serializer);

            return new SpineEventKeyframeData(
            @time,
            @name,
            @int,
            @float,
            @string);
        }
    }

    public class SpineDrawOrderSlotKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineDrawOrderSlotKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @slot = jsonArray.TryGet<string>("slot", serializer);
            var @offset = jsonArray.TryGet<int>("offset", serializer);

            return new SpineDrawOrderSlotKeyFrameData(
            @slot,
            @offset);
        }
    }

    public class SpineDrawOrderKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineDrawOrderKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @time = jsonArray.TryGet<float>("time", serializer);
            var @offsets = jsonArray.TryGet<SpineDrawOrderSlotKeyFrameData>("offsets", serializer);

            return new SpineDrawOrderKeyFrameData(
            @time,
            @offsets);
        }
    }

    public class SpineAnimationDataJsonConverter : BaseSpineJsonConverter<SpineAnimationData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonArray = JArray.Load(reader);
            var @bones = jsonArray.TryGet<SpineBonesAnimationData>("bones", serializer);
            var @slots = jsonArray.TryGet<SpineSlotsAnimationData>("slots", serializer);
            var @ik = jsonArray.TryGet<SpineIKConstraintsAnimationData>("ik", serializer);
            var @transform = jsonArray.TryGet<SpineTransformConstraintsAnimationData>("transform", serializer);
            var @deform = jsonArray.TryGet<SpineDeformsAnimationData>("deform", serializer);
            var @events = jsonArray.TryGet<SpineEventKeyframeData[]>("events", serializer);
            var @draworder = jsonArray.TryGet<SpineDrawOrderKeyFrameData[]>("draworder", serializer);

            return new SpineAnimationData(
            @bones,
            @slots,
            @ik,
            @transform,
            @deform,
            @events,
            @draworder);
        }
    }

    public class SpineAnimationsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineAnimationsData>
    {
    }
}
