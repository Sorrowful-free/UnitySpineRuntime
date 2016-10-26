using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnitySpine.Runtime.Spine.Runtime.Data
{
    public class SerializableDictionary<TKey, TValue> : IDictionary<TKey, TValue> ,ISerializationCallbackReceiver
    {
        private Dictionary<TKey, TValue> _data;
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() => _data.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _data.GetEnumerator();

        public void Add(KeyValuePair<TKey, TValue> item) => _data.Add(item.Key, item.Value);

        public void Clear() => _data.Clear();


        public bool Contains(KeyValuePair<TKey, TValue> item)
            => _data.ContainsKey(item.Key) && _data.ContainsValue(item.Value);


        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            var dataList = _data.ToList();
            dataList.CopyTo(array, arrayIndex);
            _data = dataList.ToDictionary(e => e.Key, e => e.Value);
        } 

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            if(Contains(item))
                return Remove(item.Key);
            return false;
        }

        public int Count => _data.Count;
        public bool IsReadOnly => false;
        public bool ContainsKey(TKey key) => _data.ContainsKey(key);

        public void Add(TKey key, TValue value) => _data.Add(key, value);

        public bool Remove(TKey key) => _data.Remove(key);


        public bool TryGetValue(TKey key, out TValue value) => _data.TryGetValue(key, out value);

        public TValue this[TKey key]
        {
            get { return _data[key]; }
            set { _data[key] = value; }
        }


        public ICollection<TKey> Keys => _data.Keys;
        public ICollection<TValue> Values => _data.Values;

        [SerializeField]
        private List<TKey> _serializableKeys;
        [SerializeField]
        private List<TValue> _serializableValues;
        public void OnBeforeSerialize()
        {
            _serializableKeys = _data.Keys.ToList();
            _serializableValues = _data.Values.ToList();
        }

        public void OnAfterDeserialize()
        {
            _data = new Dictionary<TKey, TValue>();
            for (int i = 0; i < _serializableKeys.Count; i++)
            {
                _data.Add(_serializableKeys[i],_serializableValues[i]);
            }
        }
    }
}
