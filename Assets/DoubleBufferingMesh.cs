using System;
using System.Linq;
using UnityEngine;

namespace Assets
{
    
    public class DoubleBufferingMesh
    {
        private Mesh _buffer0;
        private Mesh _buffer1;
        private bool _swap;
        public Mesh Value { get { return _swap ? _buffer0 : _buffer1; } }
        protected Mesh OtherValue{ get { return !_swap ? _buffer0 : _buffer1; } }
        public bool HasChanges { get; private set; }

        public DoubleBufferingMesh(Sprite original)
        {
            _buffer0 = new Mesh();
            _buffer0.MarkDynamic();
            _buffer1 = new Mesh();
            _buffer1.MarkDynamic();
            _buffer0.vertices = original.vertices.Select(e=>(Vector3)e).ToArray();
            _buffer1.vertices = original.vertices.Select(e => (Vector3)e).ToArray();
            _buffer0.uv = original.uv.ToArray();
            _buffer1.uv = original.uv.ToArray();
            _buffer0.triangles = original.triangles.Select(e => (int)e).ToArray();
            _buffer1.triangles = original.triangles.Select(e => (int)e).ToArray();
        }

        public void Update(Func<Mesh,bool> updateDelegat)
        {
            if (updateDelegat != null)
            {
                HasChanges = updateDelegat(OtherValue);
            }
            _swap = !_swap;
        }
        
    }
}
