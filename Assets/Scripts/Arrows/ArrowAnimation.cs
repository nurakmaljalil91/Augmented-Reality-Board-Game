using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowAnimation : MonoBehaviour {

    private Transform tr;
    public float speed;
    
	// Use this for initialization
	void Start () {
        tr = GetComponent<Transform>();
        speed = 90.0f;
	}
	
	// Update is called once per frame
	void Update () {
        tr.Rotate(Vector3.forward * Time.deltaTime * speed);
	}
}
