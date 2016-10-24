using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;
using UnitySpine.Runtime.Spine.Runtime.Data.Slots;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineSlotDataJsonConverter: BaseSpineJsonConverter<SpineSlotData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var name = jsonArray.TryGet("name", serializer, "");
            var bone = jsonArray.TryGet("bone", serializer, "");
            var color = jsonArray.TryGetColor("color", serializer, "#FFFFFFFF");
            var attachment = jsonArray.TryGet("bone", serializer, "");
            var blend = jsonArray.TryGetEnum("blend", serializer, SpineBlendModeType.Normal);

            return new SpineSlotData(name,bone,color,attachment,blend);
        }
    }
}
