using System;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data.Animations.KeyFrames
{
    [Serializable]
    public class SpineEventKeyframeData : SpineBaseKeyFrameData
    {
        [SerializeField]
        private readonly string _name;
        public string Name => _name;

        [SerializeField]
        private int _int;
        public int Int => _int;

        [SerializeField]
        private float _float;
        public float Float => _float;

        [SerializeField]
        private string _string;
        public string String => _string;

        public SpineEventKeyframeData(float time, string name, int i, float f, string s) : base(time)
        {
            _name = name;
            _int = i;
            _float = f;
            _string = s;
        }
    }
}
