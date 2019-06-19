using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandCardScript : MonoBehaviour {

    public List<GameObject> materialCards;
    public GameObject[] arrayOfCards;
    int numberOfCardsCollected;
    int randomCardsNumber;
    GameObject player;
    NumberOfCardCollect noOfCardsCollect;

	// Use this for initialization
	void Start () {
        materialCards = new List<GameObject>();
        player = GameObject.FindGameObjectWithTag("Player");
        noOfCardsCollect = player.GetComponent<NumberOfCardCollect>();

	}

    private void Awake()
    {
        numberOfCardsCollected = noOfCardsCollect.numberOfCardsCollect;

        //generate random number
        for(int i = 0; i < numberOfCardsCollected; i++)
        {
            randomCardsNumber = Random.Range(0, arrayOfCards.Length - 1);
            materialCards.Add(arrayOfCards[randomCardsNumber]);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
