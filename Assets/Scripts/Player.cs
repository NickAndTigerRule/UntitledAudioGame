using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//Cross Script Reference
	//public static Player Instance;

	//Movement
	public float speed;
	private Vector3 movement;
	public Component rigidBody;

	// Use this for initialization
	void Start ()
	{
		//'Instance' Used in other scripts to reference this.
		//Instance = this;
	}

	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		PlayerMovement();
	}

	void PlayerMovement()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

		transform.Translate(movement * speed * Time.deltaTime, Space.World);

		print (moveHorizontal);
	}
}
