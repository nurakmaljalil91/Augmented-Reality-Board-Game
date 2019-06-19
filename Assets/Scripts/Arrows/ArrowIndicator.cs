using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowIndicator : MonoBehaviour {

    PlayerMove pm;
    public GameObject arrow;


	// Use this for initialization
	void Start () {
        pm = GetComponent<PlayerMove>();
        arrow.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //Check if is player turn
        CheckIfPlayerTurn();
     
        

	}

    void CheckIfPlayerTurn()
    {
        if (pm.turn)
        {
            arrow.SetActive(true);
        }
        else
        {
            arrow.SetActive(false);
        }
    }

 
}
