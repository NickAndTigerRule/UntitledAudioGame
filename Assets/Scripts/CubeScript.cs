using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour {


    public int band;
    public float startScale;
    public float scaleMulti;

    Material mat;

	// Use this for initialization
	void Start () {
        mat = GetComponent<MeshRenderer>().materials[0];
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale = new Vector3(transform.localScale.x, (AudioData.audioBandBuffer[band] * scaleMulti) + startScale, transform.localScale.z);
        Color colour = new Color(AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band]);
        mat.SetColor("_EmissionColor", colour);
	}
}
