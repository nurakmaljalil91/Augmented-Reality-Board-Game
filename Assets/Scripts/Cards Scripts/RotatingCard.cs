using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingCard : MonoBehaviour {
    private Transform tr;

    public float speed;

    // Use this for initialization
    void Start()
    {
        tr = GetComponent<Transform>();
        speed = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        tr.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
