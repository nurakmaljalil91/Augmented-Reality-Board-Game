using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSpawner : MonoBehaviour {

    public bool containCard = true;
    public GameObject prefab;
    public GameObject cardChild;

    // Use this for initialization
    void Start()
    {
        if (containCard)
        {

            cardChild = Instantiate(prefab, gameObject.transform.position, Quaternion.identity);
            cardChild.transform.parent = gameObject.transform;
            cardChild.transform.position = new Vector3(cardChild.transform.position.x, 1.2f, cardChild.transform.position.z);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
