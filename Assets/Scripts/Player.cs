using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//Cross Script Reference
	//public static Player Instance;

	//Movement
	public float speed;
    public float jump;
    private Vector3 movement;
	public Rigidbody Rb;
    public bool grounded = false;

    

	// Use this for initialization
	void Start ()
	{
		//'Instance' Used in other scripts to reference this.
		//Instance = this;
	}

	// Update is called once per frame
	void Update () {
        PlayerMovement();
    }

	void FixedUpdate()
	{
		
	}

	void PlayerMovement()
	{
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        if(grounded)
        {
            Rb.velocity = (movement * speed);
        }

        if (grounded && Input.GetButtonDown("Submit")|| Input.GetButtonDown("Axis 10"))
        {
            grounded = false;
            print ("Great work!");
            Rb.AddForce(Vector3.up * jump * (Time.deltaTime *1000));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
