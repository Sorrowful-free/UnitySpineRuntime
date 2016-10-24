using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Events
{
    [Serializable]
    public class SpineEventData
    {
        [SerializeField]
        private int _int;
        public int Int => _int;

        [SerializeField]
        private float _float;
        public float Float => _float;

        [SerializeField]
        private string _string;
        public string String => _string;

        public SpineEventData(int @int, float @float, string @string)
        {
            _int = @int;
            _float = @float;
            _string = @string;
        }
    }
}
