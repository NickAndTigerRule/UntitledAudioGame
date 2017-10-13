using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSparkle : MonoBehaviour {

    public int band;
    public int band1;
    public int band2;
    public int band3;
    public int band4;
    public int band5;
    public int band6;
    

    public GameObject[] stars;
    public GameObject earth;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SetStarBand();
        earth.transform.localScale = new Vector3(AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band]);
    }

    void SetStarBand()
    {
        for (int i = 0; i < stars.Length; i++)
        {
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.8f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band], AudioData.audioBandBuffer[band]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.7f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band1], AudioData.audioBandBuffer[band1], AudioData.audioBandBuffer[band1]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.6f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band2], AudioData.audioBandBuffer[band2], AudioData.audioBandBuffer[band2]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.5f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band3], AudioData.audioBandBuffer[band3], AudioData.audioBandBuffer[band3]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.4f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band4], AudioData.audioBandBuffer[band4], AudioData.audioBandBuffer[band4]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.3f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band5], AudioData.audioBandBuffer[band5], AudioData.audioBandBuffer[band5]);
            }
            if (stars[i].GetComponent<ParticleSystem>().startSize == 0.2f)
            {
                stars[i].transform.localScale = new Vector3(AudioData.audioBandBuffer[band6], AudioData.audioBandBuffer[band6], AudioData.audioBandBuffer[band6]);
            }
        }
    }
}
