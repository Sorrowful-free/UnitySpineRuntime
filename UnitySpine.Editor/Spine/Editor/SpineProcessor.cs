using System;
using System.Collections.Generic;
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
                        assetText.Replace("\"curve\": \"stepped\"", "\"curve\": []")
                                 .Replace("\"curve\": \"linear\"", "\"curve\": [0,0,1,1]");
                    var data = JsonConvert.DeserializeObject<SpineData>(assetText);
                    MakeSpine(data);
                }
            }
        }

        private static void MakeSpine(SpineData data)
        {
            var bones = MakeBones(data.Bones);
            var slots = MakeSlots(data.Slots, bones);
            foreach (var skin in data.Skins)
            {
                foreach (var slotInfo in skin.Value)
                {
                    // MakeAttachments(attachmentsData.ToDictionary(e => e.Key, e => e.Value), slots, data.Slots);
                    MakeSlotAttachment(slots[slotInfo.Key], slotInfo.Value.ToDictionary(e => e.Key, e => e.Value));
                }
            }
        }

        private static Dictionary<string, Transform> MakeBones(IEnumerable<SpineBoneData> bones)
        {
            //make bones
            var bonesByName = new Dictionary<string, Transform>();
            foreach (var bone in bones)
            {
                var boneGO = new GameObject(bone.Name);
                bonesByName.Add(bone.Name, boneGO.transform);
            }
            //reparent
            foreach (var bone in bones)
            {
                if (!string.IsNullOrEmpty(bone.Parent))
                {
                    var childBone = bonesByName[bone.Name];
                    var parentBone = bonesByName[bone.Parent];
                    childBone.SetParent(parentBone,false);
                }
            }
            return bonesByName;
        }

        private static Dictionary<string, Transform> MakeSlots(IEnumerable<SpineSlotData> slots,
            Dictionary<string, Transform> bones)
        {
            var slotsByName = new Dictionary<string, Transform>();
            foreach (var slot in slots)
            {
                var slotGO = new GameObject(slot.Name);
                var boneTransform = default(Transform);
                if (bones.TryGetValue(slot.Bone, out boneTransform))
                {
                    slotGO.transform.SetParent(boneTransform);
                }
                slotsByName.Add(slot.Name,slotGO.transform);
            }
            return slotsByName;
        }

        private static void MakeSlotAttachment(Transform slotTransform, Dictionary<string, SpineAttachmentData> attachments)
        {
            foreach (var attachment in attachments)
            {
                var name = string.IsNullOrEmpty(attachment.Value.Name) ? attachment.Key : attachment.Value.Name;
                var attachmentGO = new GameObject(name);
                attachmentGO.transform.SetParent(slotTransform,false);
            }
        }

        //private static Dictionary<string, Transform> MakeAttachments(Dictionary<string,SpineAttachmentData> attachments, Dictionary<string, Transform> slotsByName, IEnumerable<SpineSlotData> slots)
        //{
        //    var attachmentsByName = new Dictionary<string, Transform>();
        //    foreach (var attachment in attachments)
        //    {
        //        var name = string.IsNullOrEmpty(attachment.Value.Name) ? attachment.Key : attachment.Value.Name;
        //        var attachmentGO = new GameObject(name);
        //        attachmentsByName.Add(name, attachmentGO.transform);
        //    }
        //    foreach (var slot in slots)
        //    {
        //        var attachmentTransfrom = default(Transform);
        //        var slotTransform = default(Transform);
        //        if(!string.IsNullOrEmpty(slot.Attachment) && !string.IsNullOrEmpty(slot.Name) && attachmentsByName.TryGetValue(slot.Attachment, out attachmentTransfrom) && slotsByName.TryGetValue(slot.Name,out slotTransform))
        //        {
        //            attachmentTransfrom.SetParent(slotTransform,false);
        //        }

        //    }
        //    return attachmentsByName;
        //}
    }
}
