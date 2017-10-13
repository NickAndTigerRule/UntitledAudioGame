﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScene : MonoBehaviour {

    public AudioSource Space;
    public AudioSource Dark;
    public AudioSource Nature;
    public AudioSource Sweet;

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("cool");
            WorldChangeSpace();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WorldChangeDark();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WorldChangeNature();
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            WorldChangeSweet();
        }

    }

    public void WorldChangeSpace()
    {
        CameraFollow.Instance.LevelCheck[0] = true;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
    }

    public void WorldChangeDark()
    {
        CameraFollow.Instance.LevelCheck[1] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
    }

    public void WorldChangeNature()
    {
        CameraFollow.Instance.LevelCheck[2] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
    }

    public void WorldChangeSweet()
    {
        CameraFollow.Instance.LevelCheck[3] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
    }
}
