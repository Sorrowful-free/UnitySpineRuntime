using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data.Bones;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineBoneDataJsonConverter : BaseSpineJsonConverter<SpineBoneData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var name = jsonArray.TryGet("name", serializer,"");
            var length = jsonArray.TryGet("length", serializer, 0f);
            var transform = jsonArray.TryGetEnum<SpineBoneTransformType>("transform", serializer,
                SpineBoneTransformType.Normal);
            var x = jsonArray.TryGet("x", serializer, 0f);
            var y = jsonArray.TryGet("x", serializer, 0f);
            var rotation = jsonArray.TryGet("rotation", serializer, 0f);
            var scaleX = jsonArray.TryGet("scaleX", serializer, 1f);
            var scaleY = jsonArray.TryGet("scaleY", serializer, 1f);
            var shearX = jsonArray.TryGet("shearX", serializer, 0f);
            var shearY = jsonArray.TryGet("shearY", serializer, 0f);
            var inheritScale = jsonArray.TryGet("inheritScale", serializer, true);
            var inheritRotation = jsonArray.TryGet("inheritRotation", serializer, true);
            var color = jsonArray.TryGetColor("color", serializer, "#989898FF");

            return new SpineBoneData(name, length, transform, x, y, rotation, scaleX, scaleY, shearX, shearY,
                inheritScale, inheritRotation, color);

        }
    }
}
