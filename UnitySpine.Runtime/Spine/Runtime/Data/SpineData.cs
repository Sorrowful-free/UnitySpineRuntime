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
        private SpineSkeletonData skeleton;
        public SpineSkeletonData Skeleton => skeleton;

        [SerializeField]
        private List<SpineBoneData> bones;
        public ReadOnlyCollection<SpineBoneData> Bones => bones.AsReadOnly();

        [SerializeField]
        private List<SpineSlotData> slots;
        public ReadOnlyCollection<SpineSlotData> Slots => slots.AsReadOnly();

        [SerializeField]
        private List<SpineIkConstraintsData> ik;
        public ReadOnlyCollection<SpineIkConstraintsData> Ik => ik.AsReadOnly();

        [SerializeField]
        private List<SpineTransformConstraintsData> transform;
        public ReadOnlyCollection<SpineTransformConstraintsData> Transform => transform.AsReadOnly();

        [SerializeField]
        private SpineSkinsData skins;
        public SpineSkinsData Skins => skins;

        [SerializeField]
        private SpineEventsData _events;

        public SpineEventsData Events => _events;
    }
}
