using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogoRotating : MonoBehaviour {

    RectTransform rt;
    // Use this for initialization
    void Start()
    {
        rt = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rt.Rotate(new Vector3(0, 0, -2));
    }
}
