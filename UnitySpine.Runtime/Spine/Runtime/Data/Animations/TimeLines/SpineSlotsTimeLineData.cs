using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    public class SpineSlotsTimeLineData : SerializableReadOnlyDictionary<string,SpineSlotTimeLineData>
    {
        public SpineSlotsTimeLineData(IDictionary<string, SpineSlotTimeLineData> dictionary) : base(dictionary)
        {
        }
    }
}