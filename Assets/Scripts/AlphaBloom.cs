using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaBloom : MonoBehaviour {

    public int band;
    public float startScale;
    public float scaleMulti;

    public GameObject thisObject;
    ParticleSystem thisSystem;
    Color myColour;

	// Use this for initialization
	void Start () {
        thisObject = this.gameObject;
        thisSystem = thisObject.GetComponent<ParticleSystem>();
        myColour = thisSystem.startColor;
	}
	
	// Update is called once per frame
	void Update () {
		thisSystem.startColor = new Color(myColour.r, myColour.g, myColour.b, AudioData.audioBand[band]);
    }
}
