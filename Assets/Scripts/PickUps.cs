using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUps : MonoBehaviour {

	//Cross Script Reference
	public static PickUps Instance;

	// Use this for initialization
	void Start () {
		Instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision Collider)
	{

		if (Collider.gameObject.CompareTag("Player")) 
		{
			Player.Instance.PickUps += 1;
			Destroy(gameObject);
		}
	}
}
