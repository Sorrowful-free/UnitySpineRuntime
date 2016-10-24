using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Constraints
{
    [Serializable]
    public class SpineIkConstraintsData
    {
        [SerializeField]
        private string _name;
        public string Name => _name;

        [SerializeField]
        private int _order;
        public int Order => _order;

        [SerializeField]
        private List<string> _bones;
        public ReadOnlyCollection<string> Bones => _bones.AsReadOnly();

        [SerializeField]
        private string _target;
        public string Target => _target;

        [SerializeField]
        [Range(0,1)]
        private float _mix ;
        public float Mix => _mix;

        [SerializeField]
        private bool _bendPositive;
        public bool BendPositive => _bendPositive;
        public SpineIkConstraintsData(string name, int order, List<string> bones, string target, float mix, bool bendPositive)
        {
            _name = name;
            _order = order;
            _bones = bones;
            _target = target;
            _mix = mix;
            _bendPositive = bendPositive;
        }

        
    }
}