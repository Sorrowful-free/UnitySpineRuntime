using System.Collections.Generic;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations
{
    public class SpineIKConstraintTimeLineData : SerializableReadOnlyCollection<SpineIKConstraintKeyFrameData>
    {
        public SpineIKConstraintTimeLineData(IEnumerable<SpineIKConstraintKeyFrameData> collection) : base(collection)
        {
        }
    }
}