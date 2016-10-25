using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;
using UnitySpine.Runtime.Spine.Runtime.Data.Attachments;
using UnitySpine.Runtime.Spine.Runtime.Data.Skins;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineSkinDataJsonConverter : BaseSpineJsonConverter<SpineSkinData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var skinData = new Dictionary<string,SpineBaseAtachmentData>();
            var jsonArray = JArray.Load(reader);
            foreach (var jsonObject in jsonArray)
            {
                var key = jsonObject.Path;
                if (!skinData.ContainsKey(key))
                {
                    skinData.Add(key,jsonArray.TryGet<SpineBaseAtachmentData>(key,serializer));
                }
            }
            return new SpineSkinData(skinData);
        }
    }
}
