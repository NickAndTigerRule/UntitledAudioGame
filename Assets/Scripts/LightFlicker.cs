using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlicker : MonoBehaviour {
    public Light myLight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var value = Mathf.Lerp(Random.Range(0.3f, 0.6f), Random.Range(0.8f, 1.1f), 1);
        myLight.GetComponent<Light>().intensity = value;
	}
}
