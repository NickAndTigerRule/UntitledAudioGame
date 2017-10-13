using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsFollow : MonoBehaviour {

    public GameObject player;
    public float xPos;
    public float yPos;
    public float zPos;

    // Use this for initialization
    void Start () {
		yPos = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        var myPos = new Vector3(player.transform.position.x, player.transform.position.y, zPos);
        this.transform.position = myPos;
	}
}
