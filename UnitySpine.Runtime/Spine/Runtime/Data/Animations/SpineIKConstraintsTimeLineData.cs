using System.Collections.Generic;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    public class SpineIKConstraintsTimeLineData : SerializableReadOnlyDictionary<string, SpineIKConstraintTimeLineData>
    {
        public SpineIKConstraintsTimeLineData(IDictionary<string, SpineIKConstraintTimeLineData> dictionary) : base(dictionary)
        {
        }
    }
}