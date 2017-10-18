using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAsteroid : MonoBehaviour {
    public GameObject asteroid;
    public float force;
	void Update () {
        this.gameObject.GetComponent<Rigidbody>().AddForce(-Vector3.up * force);
	}
}
