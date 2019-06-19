using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowDiceState : MonoBehaviour {

    public GameObject player;
    public GameObject throwDicePanel;
    public int randomNumber;
    PlayerMove pm;
    bool isPanelExist;
	// Use this for initialization
	void Start () {
       
        pm = player.GetComponent<PlayerMove>();

        isPanelExist = false;
	}
	
	// Update is called once per frame
	void Update () {
        /*
        if (pm.turn)
        {
            if (!isPanelExist)
            {
                throwDicePanel.SetActive(true);
                isPanelExist = true;
            }
        }
        else
        {
            isPanelExist = false;
        }
        */
	}

    public void GenerateRandomNumber()
    {
        randomNumber = Random.Range(1, 6);

    }

    
}
