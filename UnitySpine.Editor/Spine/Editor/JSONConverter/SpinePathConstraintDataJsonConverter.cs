using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data.Constraints;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpinePathConstraintDataJsonConverter:BaseSpineJsonConverter<SpinePathConstrantData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var name = jsonArray.TryGet("name", serializer, "");
            var order = jsonArray.TryGet("order", serializer, 0);
            var bones = jsonArray.TryGet("bones", serializer, default(string[]));
            var target = jsonArray.TryGet("target", serializer, "");
            var positionMode = jsonArray.TryGetEnum("positionMode", serializer, SpinePathConstraintPositionMode.Percent);
            var spacingMode = jsonArray.TryGetEnum("spacingMode", serializer, SpinePathConstraintSpacingMode.Length);
            var rotateMode = jsonArray.TryGetEnum("rotateMode", serializer, SpinePathConstraintRotationMode.Tangent);
            var rotation = jsonArray.TryGet("rotation", serializer, 0f);
            var position = jsonArray.TryGet("position", serializer, 0f);
            var spacing = jsonArray.TryGet("spacing", serializer, 0f);
            var rotateMix = jsonArray.TryGet("rotateMix", serializer, 1f);
            var translateMix = jsonArray.TryGet("translateMix", serializer, 1f);
            
            return new SpinePathConstrantData(name,order,bones.ToList(),target,positionMode,spacingMode,rotateMode,rotation,position,spacing,rotateMix,translateMix);
        }
    }
}
