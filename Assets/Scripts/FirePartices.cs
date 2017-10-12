using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePartices : MonoBehaviour {
    public GameObject player;
    private GameObject curFire1;
    public float force;
    public GameObject fireBall;
    public GameObject plasmaBall;
    

    // Use this for initialization
    void Start () {
        curFire1 = fireBall;
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.O))
        {
            curFire1 = fireBall;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            curFire1 = plasmaBall;
        }

        if (Input.GetButtonDown("Fire1"))
        {

            var offset = new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 1, player.transform.position.z);
            var projectile = Instantiate(curFire1, offset, transform.rotation);

            projectile.GetComponent<Rigidbody>().AddForce(Vector3.right * force);
            Destroy(projectile, 2f);
        }

	}
}
