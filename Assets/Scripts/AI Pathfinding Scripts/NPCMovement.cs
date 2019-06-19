using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : TacticsMove {

    List<Tile> randomPositionOfTile;
    Transform randomTileTransform;
    Tile targetTile;

    // Use this for initialization
    void Start () {
        Init();
        randomPositionOfTile = new List<Tile>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.DrawRay(transform.position, transform.forward);

        if (!turn)
        {
            return;
        }

        if (!moving)
        {
            ThrowDice();
            FindSelecteableTiles();
            ComputeRandomTile();
        }
        else
        {
            Move();
            if (startAction)
            {
                TurnManager.EndTurn();
                startAction = false;
            }
           
        }
    }

    void ThrowDice()
    {
        int randomDiceNumbers = Random.Range(3, 6);
        move = randomDiceNumbers;
    }

    void ComputeRandomTile()
    {
        foreach(Tile t in selectableTile)
        {
            randomPositionOfTile.Add(t);
        }

        int randomNumberSelected = Random.Range(0, randomPositionOfTile.Count);

        targetTile = randomPositionOfTile[randomNumberSelected];

        MoveToTile(targetTile);
        randomPositionOfTile.Clear();
        
    }

}
