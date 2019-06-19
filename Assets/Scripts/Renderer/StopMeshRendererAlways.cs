using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopMeshRendererAlways : MonoBehaviour {

    public MeshRenderer mr;

	// Use this for initialization
	void Start () {
        mr = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
        mr.enabled = false;
	}
}
