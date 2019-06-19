using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : TacticsMove {

    public Camera camera;
    public GameObject throwDicePanel;
    public GameObject actionPanel;

    [System.NonSerialized] private bool canMouseIsPressed;

    int diceNumber;
   
    // Use this for initialization
    void Start()
    {
        Init();
        //currentState = ActionState.IDLE;
        diceNumber = 0;

        canMouseIsPressed = false;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward);

        if (!turn)
        {
            //currentState = ActionState.IDLE;
            return;
        }

   
        if (!moving)
        {
            move = gameObject.GetComponent<ThrowDiceState>().randomNumber;
            FindSelecteableTiles();

            if (canMouseIsPressed)
            {
                CheckMouse();
            }
            
        }
        else
        {
            Move();
            if (startAction)
            {
                Invoke("Action", 2);
                //Action();
            }
            move = 0;
           
            
        }
       

    }


    void ThrowDice()
    {
        throwDicePanel.SetActive(true);
    }

    public void CloseThrowDicePanel()
    {
        throwDicePanel.SetActive(false);
    }

    void CheckMouse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.tag == "Tile")
                {
                    Tile t = hit.collider.GetComponent<Tile>();
                    Debug.Log("Tile pressed at: " + t.transform.position);
                    if (t.selectable)
                    {
                        MoveToTile(t);
                        canMouseIsPressed = false;
                    }
                }
            }
        }
        //canMouseIsPressed = false;
    }

    void Action()
    {
        actionPanel.SetActive(true);
    }

    public void EndThePlayerTurn()
    {
        TurnManager.EndTurn();
        startAction = false;
    }

    public void LetThePlayerClicke()
    {
        canMouseIsPressed = setTheMouseIsPressed();
        throwDicePanel.SetActive(false);
    }

    private bool setTheMouseIsPressed()
    {
        return true;
    }
}
