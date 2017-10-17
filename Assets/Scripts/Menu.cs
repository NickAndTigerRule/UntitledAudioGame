using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour {

    public bool[] Levels;
    public GameObject[] MovePoints;
    public GameObject Player;

    public float speed;

    private Vector3 NewMovepoint;
    
    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        SetLevel();
    }
    private void FixedUpdate()
    {
        Moving();
    }

    void Moving()
    {
         float step = speed * Time.deltaTime;
        Player.transform.position = Vector3.MoveTowards(Player.transform.position, NewMovepoint, step);
    }

    void SetLevel()
    {
        if(Levels[0] == true)
        {
            NewMovepoint = MovePoints[0].transform.position;
        }
        if (Levels[1] == true)
        {
            NewMovepoint = MovePoints[1].transform.position;
        }
        if (Levels[2] == true)
        {
            NewMovepoint = MovePoints[2].transform.position;
        }
        if (Levels[3] == true)
        {
            NewMovepoint = MovePoints[3].transform.position;
        }
    }
}
