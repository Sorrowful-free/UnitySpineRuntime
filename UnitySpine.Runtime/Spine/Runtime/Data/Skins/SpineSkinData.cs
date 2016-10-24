using System.Collections.Generic;
using UnitySpine.Runtime.Spine.Runtime.Data.Attachments;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Skins
{
    public class SpineSkinData : SerializableReadOnlyDictionary<string, SpineBaseAtachmentData>
    {
        public SpineSkinData(IDictionary<string, SpineBaseAtachmentData> dictionary) : base(dictionary)
        {
        }
    }
}