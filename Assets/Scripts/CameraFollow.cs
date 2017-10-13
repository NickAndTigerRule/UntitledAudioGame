using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public static CameraFollow Instance;

    public GameObject player;       //Public variable to store a reference to the player game object
    public Camera cam;

	private Vector3 offset;         //Private variable to store the offset distance between the player and camera

    public bool[] LevelCheck;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
        Instance = this;
	}
	
	void LateUpdate()
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = player.transform.position + offset;
	}

	// Update is called once per frame
	void Update ()
    {
        CameraCulling();
	}

    public void CameraCulling()
    {
        if (LevelCheck[0])
        {
            cam.cullingMask = (1 << 0) | (1 << 8);
        }
        if (LevelCheck[1])
        {
            cam.cullingMask = (1 << 0) | (1 << 9);
        }
        if (LevelCheck[2])
        {
            cam.cullingMask = (1 << 0) | (1 << 10);
        }
        if (LevelCheck[3])
        {
            cam.cullingMask = (1 << 0) | (1 << 11);
        }
    }
}
