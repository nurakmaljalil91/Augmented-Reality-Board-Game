using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberOfCardCollect : MonoBehaviour {

    public int numberOfCardsCollect = 0;
    public Text numbersCardText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        numbersCardText.text = numberOfCardsCollect.ToString();
	}

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Card")
        {
            Destroy(other.gameObject);
            numberOfCardsCollect++;
        }
    
    }
}
