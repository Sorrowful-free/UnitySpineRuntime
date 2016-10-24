using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data.Constraints;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineTransformConstraintDataJsonConverter : BaseSpineJsonConverter<SpineTransformConstraintsData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var name = jsonArray.TryGet("name", serializer, "");
            var order = jsonArray.TryGet("order", serializer, 0);
            var bone = jsonArray.TryGet("bone", serializer, "");
            var target = jsonArray.TryGet("target", serializer, "");
            var rotation = jsonArray.TryGet("rotation", serializer, 0f);
            var x = jsonArray.TryGet("x", serializer, 0f);
            var y = jsonArray.TryGet("x", serializer, 0f);
            var scaleX = jsonArray.TryGet("scaleX", serializer, 1f);
            var scaleY = jsonArray.TryGet("scaleY", serializer, 1f);
            var shearX = jsonArray.TryGet("shearX", serializer, 0f);
            var shearY = jsonArray.TryGet("shearY", serializer, 0f);
            var rotateMix = jsonArray.TryGet("rotateMix", serializer, 1f);
            var translateMix = jsonArray.TryGet("translateMix", serializer, 1f);
            var scaleMix = jsonArray.TryGet("scaleMix", serializer, 1f);
            var shearMix = jsonArray.TryGet("shearMix", serializer, 1f);

            return new SpineTransformConstraintsData(name, order, bone, target, rotation, x, y, scaleX, scaleY, shearX,
                shearY, rotateMix, translateMix, scaleMix, shearMix);
        }
    }
}
