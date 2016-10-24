using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
    [Serializable]
    public class SerializableReadOnlyCollection<T> : IReadOnlyCollection<T>
    {
        [SerializeField]
        private List<T> _serializableData;
        public SerializableReadOnlyCollection(IEnumerable<T> collection)
        {
            _serializableData = collection.ToList();// намереное копирование
        }
        public int Count => _serializableData.Count;
        public IEnumerator<T> GetEnumerator() => _serializableData.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => _serializableData.GetEnumerator();
    }
}
