using System;
using Newtonsoft.Json;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class BaseSpineSerializableReadOnlyCollectionJsonConverter<TValue> : BaseSpineJsonConverter<SerializableReadOnlyCollection<TValue>>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            return null;
        }
    }
}
