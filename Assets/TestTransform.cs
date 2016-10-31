using System.Collections;
using System.Collections.Generic;
using Assets;
using UnityEngine;

public class TestTransform : MonoBehaviour {

	// Use this for initialization
    
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    for (int i = 0; i < Options.Count; i++)
	    {
	        transform.position = Vector3.zero;
            transform.eulerAngles = Vector3.zero;
            transform.localScale = Vector3.one;
	    }
	}
}
