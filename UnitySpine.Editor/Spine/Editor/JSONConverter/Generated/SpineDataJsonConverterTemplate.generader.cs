 

using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
// generated converters 9

    public class SpineDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

            return new SpineData(
            @skeleton,
            @bones,
            @slots,
            @ik,
            @transform,
            @path);
        }
    }

    public class SpineSkeletonDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpineSlotDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpineIKConstraintDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpineTransformConstraintDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpinePathConstraintDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpineAttachmentDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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

    public class SpineEventDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
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
}
