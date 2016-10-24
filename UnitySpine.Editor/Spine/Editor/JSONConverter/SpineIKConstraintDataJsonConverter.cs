using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;
using UnitySpine.Runtime.Spine.Runtime.Data.Constraints;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineIKConstraintDataJsonConverter : BaseSpineJsonConverter<SpineIkConstraintsData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var name = jsonArray.TryGet("name", serializer, "");
            var order = jsonArray.TryGet("order", serializer, 0);
            var bones = jsonArray.TryGet<string[]>("bones", serializer);
            var target = jsonArray.TryGet("target", serializer, "");
            var mix = jsonArray.TryGet("mix", serializer, 1f);
            var blendPositive = jsonArray.TryGet("bendPositive", serializer, false);

            return new SpineIkConstraintsData(name,order,bones.ToList(),target,mix,blendPositive);
        }
    }
}
