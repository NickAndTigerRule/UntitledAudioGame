using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolutionChanger : MonoBehaviour {
    public int Height;
    public int Width;

    public int RefreshRate;

	// Use this for initialization
	void Start () {
        Screen.SetResolution(Width, Height, true, 60);
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

}
