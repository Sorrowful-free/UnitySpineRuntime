using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace UnitySpine.Editor.Spine.Editor.JSONExtention
{
    public static class JsonExtention
    {
        public static T TryGet<T>(this JArray array, string name, JsonSerializer serializer, T defaultValue = default (T))
        {
            var token = array[name];
            if (!token.HasValues || token.Type == JTokenType.Null || token.Type == JTokenType.None ||
                token.Type == JTokenType.Undefined)
                return defaultValue;
            return token.ToObject<T>(serializer);
        }

        public static Color TryGetColor(this JArray array, string name, JsonSerializer serializer, string defaultValue)
        {
            var token = array[name];
            var colorString = defaultValue;
            if ( token.HasValues && token.Type != JTokenType.Null && token.Type != JTokenType.None && token.Type != JTokenType.Undefined && !string.IsNullOrEmpty(colorString))
            {
                if (string.IsNullOrEmpty(colorString))
                    return Color.white;
                var color = default(Color);
                ColorUtility.TryParseHtmlString(colorString.ToLower().Replace("0x", "#"), out color);
                return color;
            }
            return Color.white;
        }

        public static TEnum TryGetEnum<TEnum>(this JArray array, string name, JsonSerializer serializer,
            TEnum defaultValue) where TEnum : struct
        {
            var token = array[name];
            if (!token.HasValues || token.Type == JTokenType.Null || token.Type == JTokenType.None ||
                token.Type == JTokenType.Undefined)
                return defaultValue;

            var enumName = token.ToObject<string>(serializer);

            var enumsValues = Enum.GetValues(typeof (TEnum));
            var enumValue = enumsValues.Cast<TEnum>().FirstOrDefault(e => e.ToString().ToLower() == enumName.ToLower());
            return enumValue;
        }
    }
}
