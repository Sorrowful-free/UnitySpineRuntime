using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data.Events;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineEventDataJsonConverter : BaseSpineJsonConverter<SpineEventData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var _int = jsonArray.TryGet("int", serializer, 0);
            var _float = jsonArray.TryGet("float", serializer, 0f);
            var _string = jsonArray.TryGet("string", serializer, "");

            return new SpineEventData(_int,_float,_string);
        }
    }
}
