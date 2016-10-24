using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineSkeletonDataJsonConverter : BaseSpineJsonConverter<SpineSkeletonData>
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (JsonToken.Null == reader.TokenType) return null;
            var jsonArray = JArray.Load(reader);
            var hash = jsonArray.TryGet("hash", serializer,"-1");
            var version = jsonArray.TryGet("version", serializer, "-1");
            var width = jsonArray.TryGet("width", serializer, -1f);
            var height = jsonArray.TryGet("height", serializer, -1f);
            var images = jsonArray.TryGet("images", serializer, "/");

            return new SpineSkeletonData(hash, version, width, height, images);
        }
    }
}
