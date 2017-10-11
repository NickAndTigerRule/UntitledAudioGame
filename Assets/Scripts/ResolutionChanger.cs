using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Screen.SetResolution(160, 90, true, 60);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
