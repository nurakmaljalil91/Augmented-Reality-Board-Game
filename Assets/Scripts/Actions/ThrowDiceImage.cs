using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThrowDiceImage : MonoBehaviour {

    public Sprite[] diceImage;
    public GameObject player;
    Image currentDiceImage;

	// Use this for initialization
	void Start () {
        currentDiceImage = gameObject.GetComponent<Image>();
        currentDiceImage.sprite = diceImage[0];
	}
	
	// Update is called once per frame
	void Update () {
        ChangeImage();
	}

    void ChangeImage()
    {
        currentDiceImage.sprite = diceImage[player.GetComponent<TacticsMove>().move];
    }
}
