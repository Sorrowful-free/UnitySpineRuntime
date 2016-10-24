using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Events
{
    public class SpineEventsData : SerializableReadOnlyDictionary<string,SpineEventData>
    {
        public SpineEventsData(IDictionary<string, SpineEventData> dictionary) : base(dictionary)
        {
        }
    }
}