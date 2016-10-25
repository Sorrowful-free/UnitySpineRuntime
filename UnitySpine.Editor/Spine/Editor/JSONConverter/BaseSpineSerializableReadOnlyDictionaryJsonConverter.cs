using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class BaseSpineSerializableReadOnlyDictionaryJsonConverter<TValue> : BaseSpineJsonConverter<SerializableReadOnlyDictionary<string, TValue>>
    {
        public override bool CanConvert(Type objectType)
            =>
                objectType == typeof (SerializableReadOnlyDictionary<string, TValue>) ||
                objectType.IsSubclassOf(typeof (SerializableReadOnlyDictionary<string, TValue>));
        

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var data = new Dictionary<string,TValue>();
            foreach (var jObj in jsonArray)
            {
                data.Add(jObj.Path,jObj.ToObject<TValue>(serializer));
            }
            var result = Activator.CreateInstance(objectType, data);
            return result;
        }
    }
}
