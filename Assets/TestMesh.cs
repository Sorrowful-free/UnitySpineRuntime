using System.Linq;
using Assets;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer), typeof(MeshFilter))]
public class TestMesh : MonoBehaviour
{

    [SerializeField]
    private Sprite _sprite;
	// Use this for initialization
    private DoubleBufferingMesh _buffer;
    private Vector3[] _vert;
    private MeshFilter _mf;
	void Start () {

        _vert = _sprite.vertices.Select(e=>(Vector3)e).ToArray();
        _buffer = new DoubleBufferingMesh(_sprite);
	    _mf = GetComponent<MeshFilter>();
	    var size = sizeof (float)*4*_vert.Length;
        Debug.Log(size);
	}

    private bool UpdateMesh(Mesh mesh)
    {
        mesh.vertices = _vert;
        return true;
    }
	
	// Update is called once per frame
	void Update () {
	    for (int i = 0; i < Options.Count; i++)
	    {
	        _buffer.Update(UpdateMesh);
	        _mf.mesh = _buffer.Value;
	    }
	}
}
