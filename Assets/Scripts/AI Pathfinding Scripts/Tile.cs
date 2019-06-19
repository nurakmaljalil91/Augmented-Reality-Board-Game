using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {


    public bool walkable = true;
    public bool current = false;
    public bool target = false;
    public bool selectable = false;

    public List<Tile> adjacencyList = new List<Tile>();

    //Needed BFS(breadth first search)
    public bool visited = false;
    public Tile parent = null;
    public int distance = 0;

    public MeshRenderer mr;

    // Use this for initialization
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (current)
        {
            GetComponent<Renderer>().material.color = new Color(1, 0, 1, 0.1f);
        }
        else if (target)
        {
            mr.enabled = true;
            GetComponent<Renderer>().material.color = new Color(1, 0, 0, 0.1f);
        }
        else if (selectable)
        {
            mr.enabled = true;
            GetComponent<Renderer>().material.color = new Color(1, 0.92f, 0.016f, 0.1f);

        }
        else
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            mr.enabled = false;
        }
    }

    public void reset()
    {
        adjacencyList.Clear();
        current = false;
        target = false;
        selectable = false;

        visited = false;
        parent = null;
        distance = 0;

    }

    public void FindNeighbours(float jumpHeight)
    {
        reset();

        checkTile(Vector3.forward, jumpHeight);
        checkTile(-Vector3.forward, jumpHeight);
        checkTile(Vector3.right, jumpHeight);
        checkTile(-Vector3.right, jumpHeight);
    }

    public void checkTile(Vector3 direction, float jumpHeight)
    {
        Vector3 halfExtents = new Vector3(0.25f, (1 + jumpHeight) / 2.0f, 0.25f);
        Collider[] colliders = Physics.OverlapBox(transform.position + direction, halfExtents);

        foreach (Collider item in colliders)
        {
            Tile tile = item.GetComponent<Tile>();
            if (tile != null && tile.walkable)
            {
                RaycastHit hit;

                if (!Physics.Raycast(tile.transform.position, Vector3.up, out hit, 1))
                {
                    adjacencyList.Add(tile);
                }
            }
        }
    }
}
