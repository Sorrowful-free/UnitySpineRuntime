 

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
// generated converters 34

    public class SpineDataJsonConverter : BaseSpineJsonConverter<SpineData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @skeleton = jsonObj.TryGet<SpineSkeletonData>("skeleton", serializer);
            var @bones = jsonObj.TryGet<SpineBoneData[]>("bones", serializer);
            var @slots = jsonObj.TryGet<SpineSlotData[]>("slots", serializer);
            var @ik = jsonObj.TryGet<SpineIKConstraintData[]>("ik", serializer);
            var @transform = jsonObj.TryGet<SpineTransformConstraintData[]>("transform", serializer);
            var @path = jsonObj.TryGet<SpinePathConstraintData[]>("path", serializer);
            var @events = jsonObj.TryGet<SpineEventsData>("events", serializer);
            var @skins = jsonObj.TryGet<SpineSkinsData>("skins", serializer);
            var @animations = jsonObj.TryGet<SpineAnimationsData>("animations", serializer);

            return new SpineData(
            @skeleton,
            @bones,
            @slots,
            @ik,
            @transform,
            @path,
            @events,
            @skins,
            @animations);
        }
    }

    public class SpineSkeletonDataJsonConverter : BaseSpineJsonConverter<SpineSkeletonData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @hash = jsonObj.TryGet<string>("hash", serializer);
            var @version = jsonObj.TryGet<string>("version", serializer);
            var @width = jsonObj.TryGet<float>("width", serializer);
            var @height = jsonObj.TryGet<float>("height", serializer);

            return new SpineSkeletonData(
            @hash,
            @version,
            @width,
            @height);
        }
    }

    public class SpineBoneDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @parent = jsonObj.TryGet<string>("parent", serializer);
            var @length = jsonObj.TryGet<float>("length", serializer);
            var @transform = jsonObj.TryGetEnum<SpineBoneTransformEnum>("transform", serializer, SpineBoneTransformEnum.Normal);
            var @x = jsonObj.TryGet<float>("x", serializer);
            var @y = jsonObj.TryGet<float>("y", serializer);
            var @rotation = jsonObj.TryGet<float>("rotation", serializer);
            var @scaleX = jsonObj.TryGet<float>("scaleX", serializer, 1);
            var @scaleY = jsonObj.TryGet<float>("scaleY", serializer, 1);
            var @shearX = jsonObj.TryGet<float>("shearX", serializer);
            var @shearY = jsonObj.TryGet<float>("shearY", serializer);
            var @inheritScale = jsonObj.TryGet<bool>("inheritScale", serializer, true);
            var @inheritRotation = jsonObj.TryGet<bool>("inheritRotation", serializer, true);

            return new SpineBoneData(
            @name,
            @parent,
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
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @bone = jsonObj.TryGet<string>("bone", serializer);
            var @color = jsonObj.TryGetColor("color", serializer, "0xFFFFFFFF");
            var @attachment = jsonObj.TryGet<string>("attachment", serializer);
            var @blend = jsonObj.TryGetEnum<SpineSlotBlendEnum>("blend", serializer, SpineSlotBlendEnum.Normal);

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
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @order = jsonObj.TryGet<int>("order", serializer);
            var @bones = jsonObj.TryGet<string[]>("bones", serializer);
            var @target = jsonObj.TryGet<string>("target", serializer);
            var @mix = jsonObj.TryGet<float>("mix", serializer, 1);
            var @bendPositive = jsonObj.TryGet<bool>("bendPositive", serializer, false);

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
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @order = jsonObj.TryGet<int>("order", serializer);
            var @bone = jsonObj.TryGet<string>("bone", serializer);
            var @target = jsonObj.TryGet<string>("target", serializer);
            var @rotation = jsonObj.TryGet<float>("rotation", serializer);
            var @x = jsonObj.TryGet<float>("x", serializer);
            var @y = jsonObj.TryGet<float>("y", serializer);
            var @scaleX = jsonObj.TryGet<float>("scaleX", serializer, 1);
            var @scaleY = jsonObj.TryGet<float>("scaleY", serializer, 1);
            var @shearX = jsonObj.TryGet<float>("shearX", serializer);
            var @shearY = jsonObj.TryGet<float>("shearY", serializer);
            var @rotateMix = jsonObj.TryGet<float>("rotateMix", serializer, 1);
            var @translateMix = jsonObj.TryGet<float>("translateMix", serializer, 1);
            var @scaleMix = jsonObj.TryGet<float>("scaleMix", serializer, 1);
            var @shearMix = jsonObj.TryGet<float>("shearMix", serializer, 1);

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
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @order = jsonObj.TryGet<int>("order", serializer);
            var @bones = jsonObj.TryGet<string[]>("bones", serializer);
            var @target = jsonObj.TryGet<string>("target", serializer);
            var @positionMode = jsonObj.TryGetEnum<SpinePathConstraintPositionModeEnum>("positionMode", serializer, SpinePathConstraintPositionModeEnum.Percent);
            var @spacingMode = jsonObj.TryGetEnum<SpinePathConstraintSpacingModeEnum>("spacingMode", serializer, SpinePathConstraintSpacingModeEnum.Length);
            var @rotateMode = jsonObj.TryGetEnum<SpinePathConstraintRotateModeEnum>("rotateMode", serializer, SpinePathConstraintRotateModeEnum.Tangent);
            var @rotation = jsonObj.TryGet<float>("rotation", serializer);
            var @position = jsonObj.TryGet<float>("position", serializer);
            var @spacing = jsonObj.TryGet<float>("spacing", serializer);
            var @rotateMix = jsonObj.TryGet<float>("rotateMix", serializer, 1);
            var @translateMix = jsonObj.TryGet<float>("translateMix", serializer, 1);

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
            var jsonObj = JObject.Load(reader);
            var @type = jsonObj.TryGetEnum<SpineAttachmentTypeEnum>("type", serializer, SpineAttachmentTypeEnum.Region);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @path = jsonObj.TryGet<string>("path", serializer);
            var @x = jsonObj.TryGet<float>("x", serializer);
            var @y = jsonObj.TryGet<float>("y", serializer);
            var @scaleX = jsonObj.TryGet<float>("scaleX", serializer, 1);
            var @scaleY = jsonObj.TryGet<float>("scaleY", serializer, 1);
            var @rotation = jsonObj.TryGet<float>("rotation", serializer);
            var @width = jsonObj.TryGet<int>("width", serializer);
            var @height = jsonObj.TryGet<int>("height", serializer);
            var @color = jsonObj.TryGetColor("color", serializer, "0xFFFFFFFF");
            var @uvs = jsonObj.TryGet<float[]>("uvs", serializer);
            var @triangles = jsonObj.TryGet<int[]>("triangles", serializer);
            var @vertices = jsonObj.TryGet<float[]>("vertices", serializer);
            var @hull = jsonObj.TryGet<float[]>("hull", serializer);
            var @skin = jsonObj.TryGet<string>("skin", serializer);
            var @parent = jsonObj.TryGet<string>("parent", serializer);
            var @deform = jsonObj.TryGet<bool>("deform", serializer, true);
            var @vertexColor = jsonObj.TryGet<int>("vertexColor", serializer);
            var @closed = jsonObj.TryGet<bool>("closed", serializer, true);
            var @constantSpeed = jsonObj.TryGet<bool>("constantSpeed", serializer, true);
            var @lengths = jsonObj.TryGet<float>("lengths", serializer);

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
            @skin,
            @parent,
            @deform,
            @vertexColor,
            @closed,
            @constantSpeed,
            @lengths);
        }
    }

    public class SpineAttachmentsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineAttachmentData>
    {
    }

    public class SpineSkinDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineAttachmentsData>
    {
    }

    public class SpineSkinsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSkinData>
    {
    }

    public class SpineEventDataJsonConverter : BaseSpineJsonConverter<SpineEventData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @int = jsonObj.TryGet<int>("int", serializer);
            var @float = jsonObj.TryGet<float>("float", serializer);
            var @string = jsonObj.TryGet<string>("string", serializer);

            return new SpineEventData(
            @name,
            @int,
            @float,
            @string);
        }
    }

    public class SpineEventsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineEventData>
    {
    }

    public class SpineRotateKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineRotateKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});
            var @angle = jsonObj.TryGet<float>("angle", serializer);

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
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});
            var @x = jsonObj.TryGet<float>("x", serializer);
            var @y = jsonObj.TryGet<float>("y", serializer);

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
            var jsonObj = JObject.Load(reader);
            var @rotate = jsonObj.TryGet<SpineRotateKeyFrameData[]>("rotate", serializer);
            var @translate = jsonObj.TryGet<SpineVectorKeyFrameData[]>("translate", serializer);
            var @scale = jsonObj.TryGet<SpineVectorKeyFrameData[]>("scale", serializer);
            var @shear = jsonObj.TryGet<SpineVectorKeyFrameData[]>("shear", serializer);

            return new SpineBoneTimeLineData(
            @rotate,
            @translate,
            @scale,
            @shear);
        }
    }

    public class SpineBonesAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineBoneTimeLineData>
    {
    }

    public class SpineAttachmentKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineAttachmentKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @name = jsonObj.TryGet<string>("name", serializer);

            return new SpineAttachmentKeyFrameData(
            @time,
            @name);
        }
    }

    public class SpineColorKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineColorKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});
            var @color = jsonObj.TryGetColor("color", serializer, "0xFFFFFFFF");

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
            var jsonObj = JObject.Load(reader);
            var @attachment = jsonObj.TryGet<SpineAttachmentKeyFrameData[]>("attachment", serializer);
            var @color = jsonObj.TryGet<SpineColorKeyFrameData[]>("color", serializer);

            return new SpineSlotTimeLineData(
            @attachment,
            @color);
        }
    }

    public class SpineSlotsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineSlotTimeLineData>
    {
    }

    public class SpineIKConstraintKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineIKConstraintKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});
            var @mix = jsonObj.TryGet<float>("mix", serializer);
            var @bendPositive = jsonObj.TryGet<bool>("bendPositive", serializer);

            return new SpineIKConstraintKeyFrameData(
            @time,
            @curve,
            @mix,
            @bendPositive);
        }
    }

    public class SpineIKConstraintsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineIKConstraintKeyFrameData[]>
    {
    }

    public class SpineTransformConstraintKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineTransformConstraintKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});
            var @rotateMix = jsonObj.TryGet<float>("rotateMix", serializer, 1);
            var @translateMix = jsonObj.TryGet<float>("translateMix", serializer, 1);
            var @scaleMix = jsonObj.TryGet<float>("scaleMix", serializer, 1);
            var @shearMix = jsonObj.TryGet<float>("shearMix", serializer, 1);

            return new SpineTransformConstraintKeyFrameData(
            @time,
            @curve,
            @rotateMix,
            @translateMix,
            @scaleMix,
            @shearMix);
        }
    }

    public class SpineTransformConstraintsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineTransformConstraintKeyFrameData[]>
    {
    }

    public class SpineDeformKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineDeformKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @offset = jsonObj.TryGet<int>("offset", serializer);
            var @vertices = jsonObj.TryGet<float[]>("vertices", serializer);
            var @curve = jsonObj.TryGet<float[]>("curve", serializer, new float[] {0,0,1,1});

            return new SpineDeformKeyFrameData(
            @time,
            @offset,
            @vertices,
            @curve);
        }
    }

    public class SpineDeformTimeLineDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformKeyFrameData[]>
    {
    }

    public class SpineDeformSlotTimeLineDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformTimeLineData>
    {
    }

    public class SpineDeformsAnimationDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineDeformSlotTimeLineData>
    {
    }

    public class SpineEventKeyframeDataJsonConverter : BaseSpineJsonConverter<SpineEventKeyframeData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @name = jsonObj.TryGet<string>("name", serializer);
            var @int = jsonObj.TryGet<int>("int", serializer);
            var @float = jsonObj.TryGet<float>("float", serializer);
            var @string = jsonObj.TryGet<string>("string", serializer);

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
            var jsonObj = JObject.Load(reader);
            var @slot = jsonObj.TryGet<string>("slot", serializer);
            var @offset = jsonObj.TryGet<int>("offset", serializer);

            return new SpineDrawOrderSlotKeyFrameData(
            @slot,
            @offset);
        }
    }

    public class SpineDrawOrderKeyFrameDataJsonConverter : BaseSpineJsonConverter<SpineDrawOrderKeyFrameData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @time = jsonObj.TryGet<float>("time", serializer);
            var @offsets = jsonObj.TryGet<SpineDrawOrderSlotKeyFrameData>("offsets", serializer);

            return new SpineDrawOrderKeyFrameData(
            @time,
            @offsets);
        }
    }

    public class SpineAnimationDataJsonConverter : BaseSpineJsonConverter<SpineAnimationData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jsonObj = JObject.Load(reader);
            var @bones = jsonObj.TryGet<SpineBonesAnimationData>("bones", serializer);
            var @slots = jsonObj.TryGet<SpineSlotsAnimationData>("slots", serializer);
            var @ik = jsonObj.TryGet<SpineIKConstraintsAnimationData>("ik", serializer);
            var @transform = jsonObj.TryGet<SpineTransformConstraintsAnimationData>("transform", serializer);
            var @deform = jsonObj.TryGet<SpineDeformsAnimationData>("deform", serializer);
            var @events = jsonObj.TryGet<SpineEventKeyframeData[]>("events", serializer);
            var @draworder = jsonObj.TryGet<SpineDrawOrderKeyFrameData[]>("draworder", serializer);

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

    public class SpineAnimationsDataJsonConverter : BaseSpineSerializableReadOnlyDictionaryJsonConverter<SpineAnimationData>
    {
    }
}
