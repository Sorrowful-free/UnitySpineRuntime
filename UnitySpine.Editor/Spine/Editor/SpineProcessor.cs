using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEditor;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Data;

namespace UnitySpine.Editor.Spine.Editor
{
    public class SpineProcessor : AssetPostprocessor
    {

        public static JsonSerializerSettings defaultSettings = new JsonSerializerSettings()
        {
            Converters = AppDomain.CurrentDomain.GetAssemblies(

                ).SelectMany(_v => _v.GetTypes()
                ).Where(_v => typeof(JsonConverter).IsAssignableFrom(_v)
                ).Where(_v => (!_v.IsAbstract && !_v.IsGenericTypeDefinition)
                ).Where(_v => null != _v.GetConstructor(new Type[0])
                ).Union(new[] { typeof(StringEnumConverter), typeof(VersionConverter) }
                ).Select(_v => (JsonConverter)Activator.CreateInstance(_v)

            ).ToList(),
            MaxDepth = 999
        };

        static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,string[] movedFromAssetPaths)
        {
            if (null == JsonConvert.DefaultSettings) JsonConvert.DefaultSettings = () => defaultSettings;
            
            foreach (var importedAsset in importedAssets)
            {
                
                var asset = AssetDatabase.LoadAssetAtPath<TextAsset>(importedAsset);
                if (asset != null)
                {
                    var assetText = asset.text;
                    assetText =
                        assetText.Replace("\"curve\": \"stepped\"", "\"curve\": [2,0,1,-1]")
                            .Replace("\"curve\": \"linear\"", "\"curve\": [0,0,1,1]");
                    var data = JsonConvert.DeserializeObject<SpineData>(assetText);
                    
                    Debug.Log($"bones:{data.Bones.Count}\n{string.Join("\n", data.Bones.Select(e => $"name:{e.Name}, length:{e.Length}, parent:{e.Parent}").ToArray())}");
                    Debug.Log($"slots:{data.Slots.Count}\n{string.Join("\n", data.Slots.Select(e => $"name:{e.Name}, Attachment:{e.Attachment}").ToArray())}");
                    Debug.Log($"skins:{data.Skins.Count}\n{string.Join("\n", data.Skins.Select(e => $"name:{e.Key}, elementCount:{e.Value.Count}").ToArray())}");
                    Debug.Log($"animations:{data.Animations.Count}\n{string.Join("\n", data.Animations.Select(e => $"name:{e.Key},boneTimeLines:{e.Value.Bones.Count}").ToArray())}");
                }
            }
        }
    }
}
