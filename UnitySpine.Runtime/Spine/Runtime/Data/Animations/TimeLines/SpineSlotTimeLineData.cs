using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.TimeLines
{
    [SerializeField]
    public class SpineSlotTimeLineData
    {
        [SerializeField]
        private List<SpineAttachmentKeyFrameData> _attachment;
        public ReadOnlyCollection<SpineAttachmentKeyFrameData> Attachment => _attachment.AsReadOnly();

        [SerializeField]
        private List<SpineColorKeyFrameData> _color;
        public ReadOnlyCollection<SpineColorKeyFrameData> Color => _color.AsReadOnly();

        public SpineSlotTimeLineData(List<SpineAttachmentKeyFrameData> attachment, List<SpineColorKeyFrameData> color)
        {
            _attachment = attachment;
            _color = color;
        }

        
    }
}