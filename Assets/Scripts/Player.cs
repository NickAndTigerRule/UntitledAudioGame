using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	//Cross Script Reference
	public static Player Instance;

	//Movement
	public float maxSpeed;
	public float acceleration;
    public float jump;
    public float airSpeed;
    private Vector3 movement;
	public Rigidbody Rb;
    public bool grounded = false;
	public bool onWall = false;


	public float passiveHeight;
	public float jumpForce;
	public float yVelocity;
	public float xVelocity;
	public float gravity;
	public bool jumping;
    

	// Use this for initialization
	void Start ()
	{
		//'Instance' Used in other scripts to reference this.
		Instance = this;
	}

	// Update is called once per frame
	void Update ()
    {
        PlayerAirMovement();
		PlayerMovement();
    }

    void PlayerAirMovement()
    {

        if (!grounded)
        {
            //Rb.AddForce(movement * airSpeed);
        }
    }

    void PlayerMovement()
	{
		

		if (xVelocity < maxSpeed) {
			xVelocity += acceleration * Time.deltaTime;
		}



		//Adjusting the Y position of the character
		if (!grounded) {
			if (!onWall) {
				yVelocity -= gravity * Time.deltaTime;
				transform.position = new Vector3 (transform.position.x, transform.position.y +yVelocity, transform.position.z);
			}
		}

		Ray ray = new Ray (transform.position, Vector3.down);
		RaycastHit hit = new RaycastHit ();
		if (Physics.Raycast (ray, out hit)) {
			if (hit.distance <= passiveHeight) {
				grounded = true;
				transform.position = new Vector3 (transform.position.x, hit.point.y + passiveHeight, transform.position.z);
				yVelocity = 0;
			} else {
				grounded = false;
			}
		}

		//Raycasting to the wall
		ray = new Ray (transform.position, Vector3.right);
		hit = new RaycastHit ();
		if (Physics.Raycast (ray, out hit)) {
			if (hit.distance <= transform.localScale.x) {
				onWall = true;
				//transform.position = new Vector3 (transform.position.x, hit.point.y + passiveHeight, transform.position.z);
				yVelocity = 0;
			} else {
				onWall = false;
			}
		}


		//adding the velocity
		if (onWall) {
			xVelocity = 0;
		}



		if (Input.GetButtonDown ("Jump")) {
			if (grounded || onWall) {
				if (onWall) {
					xVelocity = -maxSpeed;
				}
				yVelocity = jumpForce;
				transform.position = new Vector3 (transform.position.x, transform.position.y +yVelocity, transform.position.z);
				grounded = false;
			}

		}


		Vector3 velocity = new Vector3(xVelocity, 0.0f, 0.0f);
		transform.position += velocity * Time.deltaTime;






        //if (grounded && Input.GetButtonDown("Submit")|| Input.GetButtonDown("Axis 10"))
        //{
        //    grounded = false;

        //    Rb.AddForce(Vector3.up * jump * (Time.deltaTime *1000));
        //}
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            //grounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            //grounded = false;
        }
    }
}
