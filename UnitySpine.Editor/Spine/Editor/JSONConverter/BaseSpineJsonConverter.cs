using System;
using Newtonsoft.Json;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public abstract class BaseSpineJsonConverter<T>: JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new System.NotImplementedException();
        }

        public override bool CanConvert(Type objectType) => objectType == typeof (T);

        public abstract override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer);
    }
}
