using System;
using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    [Serializable]
    public class SpineBonesTimeLineData : SerializableReadOnlyDictionary<string, SpineBoneTimeLineData>
    {
        public SpineBonesTimeLineData(IDictionary<string, SpineBoneTimeLineData> dictionary) : base(dictionary)
        {
        }
    }
}