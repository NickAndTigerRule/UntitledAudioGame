using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepDust : MonoBehaviour {
    public ParticleSystem dust;
	// Use this for initialization
	void Start () {
        dust.enableEmission = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(UnityStandardAssets.Characters.ThirdPerson.ThirdPersonCharacter.m_IsGrounded)
        {
            dust.enableEmission = true;
        }
        else
        {
            dust.enableEmission = false;
        }
	}
}
