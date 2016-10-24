using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Skins
{
    public class SpineSkinsData : SerializableReadOnlyDictionary<string, SpineSkinData>
    {
        public SpineSkinsData(IDictionary<string, SpineSkinData> dictionary) : base(dictionary)
        {
        }
    }

}