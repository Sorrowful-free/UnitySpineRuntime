using System;
using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    [Serializable]
    public class SpineAnimationsData :SerializableReadOnlyDictionary<string,SpineAnimationData>
    {
        public SpineAnimationsData(IDictionary<string, SpineAnimationData> dictionary) : base(dictionary)
        {
        }
    }
}
