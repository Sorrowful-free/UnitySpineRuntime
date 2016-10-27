using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data
{

    [Serializable]
    public class SerializableReadOnlyDictionary<TKey,TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, ISerializationCallbackReceiver
    {
        [HideInInspector, SerializeField]
        private List<TKey> _serializableKeys = new List<TKey>();
        
        [HideInInspector, SerializeField]
        private List<TValue> _serializableValues = new List<TValue>();

        private IDictionary<TKey, TValue> _data;
        
        public int Count => _data.Count;

        public bool ContainsKey(TKey key) => _data.ContainsKey(key);

        public bool TryGetValue(TKey key, out TValue value) => _data.TryGetValue(key, out value);

        public TValue this[TKey key] => _data[key];

        public IEnumerable<TKey> Keys => _data.Keys;
        public IEnumerable<TValue> Values => _data.Values;

        public SerializableReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
        {
            _data = dictionary;
        }
        public void OnBeforeSerialize()
        {
            _serializableKeys.Clear();
            _serializableValues.Clear();
            _serializableKeys = Keys.ToList();
            _serializableValues = Values.ToList();
        }

        public void OnAfterDeserialize()
        {
            for (int i = 0; i < _serializableKeys.Count; i++)
            {
                if (!ContainsKey(_serializableKeys[i]))
                {
                    _data.Add(_serializableKeys[i],_serializableValues[i]);
                }
            }
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _data.GetEnumerator();
    }
}