using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;
using UnitySpine.Runtime.Spine.Runtime.Data.Bones;
using UnitySpine.Runtime.Spine.Runtime.Data.Constraints;
using UnitySpine.Runtime.Spine.Runtime.Data.Events;
using UnitySpine.Runtime.Spine.Runtime.Data.Skins;
using UnitySpine.Runtime.Spine.Runtime.Data.Slots;

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
    [Serializable]
    public class SpineData
    {
        [SerializeField]
        private SpineSkeletonData _skeleton;
        public SpineSkeletonData Skeleton => _skeleton;

        [SerializeField]
        private List<SpineBoneData> _bones;
        public ReadOnlyCollection<SpineBoneData> Bones => _bones.AsReadOnly();

        [SerializeField]
        private List<SpineSlotData> _slots;
        public ReadOnlyCollection<SpineSlotData> Slots => _slots.AsReadOnly();

        [SerializeField]
        private List<SpineIkConstraintsData> _ik;
        public ReadOnlyCollection<SpineIkConstraintsData> Ik => _ik.AsReadOnly();

        [SerializeField]
        private List<SpineTransformConstraintsData> _transform;
        public ReadOnlyCollection<SpineTransformConstraintsData> Transform => _transform.AsReadOnly();

        [SerializeField]
        private SpineSkinsData _skins;
        public SpineSkinsData Skins => _skins;

        [SerializeField]
        private SpineEventsData _events;
        public SpineEventsData Events => _events;

        public SpineData(SpineSkeletonData skeleton, List<SpineBoneData> bones, List<SpineSlotData> slots, List<SpineIkConstraintsData> ik, List<SpineTransformConstraintsData> transform, SpineSkinsData skins, SpineEventsData events)
        {
            _skeleton = skeleton;
            _bones = bones;
            _slots = slots;
            _ik = ik;
            _transform = transform;
            _skins = skins;
            _events = events;
        }
    }
}
