using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnitySpine.Editor.Spine.Editor.JSONExtention;
using UnitySpine.Runtime.Spine.Runtime.Data;
using UnitySpine.Runtime.Spine.Runtime.Data.Attachments;

namespace UnitySpine.Editor.Spine.Editor.JSONConverter
{
    public class SpineAttachmentDataJsonConverter : BaseSpineJsonConverter<SpineBaseAtachmentData>
    {
        public override bool CanConvert(Type objectType)
            => objectType == typeof (SpineBaseAtachmentData) || objectType.IsSubclassOf(typeof (SpineBaseAtachmentData));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType == JsonToken.Null) return null;
            var jsonArray = JArray.Load(reader);
            var type = jsonArray.TryGet("type", serializer, "region");
            switch (type)
            {
                default:
                case "region":
                    return MakeRegionAttachmentData(jsonArray,serializer);
                    break;
                case "mesh":
                    return MakeMeshAttachmentData(jsonArray, serializer);
                case "linkedmesh":
                    return MakeLinkedMeshAttachmentData(jsonArray,serializer);
                case "boundingbox":
                    return MakeBoundBoxAttachmentData(jsonArray,serializer);
                case "path":
                    return MakePathAttachmentData(jsonArray,serializer);
            }
        }
        
        private SpineRegionAttachmentData MakeRegionAttachmentData(JArray array, JsonSerializer serializer)
        {
            var name = array.TryGet("name", serializer, "region");
            var color = array.TryGetColor("color",serializer,"#FFFFFFFF");
            var path = array.TryGet("path",serializer,"");
            var x = array.TryGet("x", serializer, 0f);
            var y = array.TryGet("y", serializer, 0f);
            var scaleX = array.TryGet("scaleX", serializer, 1f);
            var scaleY = array.TryGet("scaleY", serializer, 1f);
            var rotation = array.TryGet("rotation", serializer, 0f);
            var width = array.TryGet("width", serializer, 0);
            var height = array.TryGet("height", serializer, 0);

            return new SpineRegionAttachmentData(name, color, path, x, y, scaleX, scaleY, rotation, width, height);
        }

        private SpineMeshAttachmentData MakeMeshAttachmentData(JArray array, JsonSerializer serializer)
        {
            var name = array.TryGet("name", serializer, "");
            var color = array.TryGetColor("color", serializer, "#FFFFFFFF");
            var path = array.TryGet("path", serializer, "");
            var uvs = array.TryGet("uvs", serializer, default(float[]));
            var triangles = array.TryGet("triangles", serializer, default(int[]));
            var vertices = array.TryGet("vertices", serializer, default(float[]));
            var hull = array.TryGet("hull", serializer, default(float[]));
            var edges = array.TryGet("edges", serializer, default(int[]));
            var width = array.TryGet("width", serializer, 0);
            var height = array.TryGet("height", serializer, 0);

            return new SpineMeshAttachmentData(name, color, path, uvs.ToList(), triangles.ToList(), vertices.ToList(),
                hull.ToList(), edges.ToList(), width, height);
        }

        private SpineLinkedMeshAttachmentData MakeLinkedMeshAttachmentData(JArray array, JsonSerializer serializer)
        {
            var name = array.TryGet("name", serializer, "");
            var color = array.TryGetColor("color", serializer, "#FFFFFFFF");
            var skin = array.TryGet("skin", serializer, "");
            var parent = array.TryGet("parent", serializer, "");
            var deform = array.TryGet("deform", serializer, true);
            var width = array.TryGet("width", serializer, 0);
            var height = array.TryGet("height", serializer, 0);

            return new SpineLinkedMeshAttachmentData(name, color, skin, parent, deform, width, height);
        }

        private SpineBoundingBoxAttachmentData MakeBoundBoxAttachmentData(JArray array, JsonSerializer serializer)
        {
            var name = array.TryGet("name", serializer, "");
            var color = array.TryGetColor("color", serializer, "#60F000FF");
            var vertexCount = array.TryGet("vertexCount", serializer, 0);
            var vertices = array.TryGet("vertices", serializer, default(float[]));

            return new SpineBoundingBoxAttachmentData(name,color,vertexCount,vertices.ToList());
        }

        private SpinePathAttachmnetData MakePathAttachmentData(JArray array, JsonSerializer serializer)
        {
            var name = array.TryGet("name", serializer, "");
            var color = array.TryGetColor("color", serializer, "#FF7F00FF");
            var closed = array.TryGet("closed", serializer, false);
            var constantSpeed = array.TryGet("constantSpeed", serializer, true);
            var lengths = array.TryGet("lengths", serializer, 0);
            var vertexCount = array.TryGet("vertexCount", serializer, 0);
            var vertices = array.TryGet("vertices", serializer, default(float[]));
            return new SpinePathAttachmnetData(name,color,closed,constantSpeed,lengths,vertexCount,vertices.ToList());
        }
    }
}
