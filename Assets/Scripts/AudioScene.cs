using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScene : MonoBehaviour {

    public static AudioScene Instance;

    public GameObject SpaceGO;
    public GameObject DarkGO;
    public GameObject NatureGO;
    public GameObject SweetGO;

    public AudioSource Space;
    public AudioSource Dark;
    public AudioSource Nature;
    public AudioSource Sweet;

    private int current = 1;

    public AudioSource currentAud;

    // Use this for initialization
    void Start ()
    {
        Instance = this;
        currentAud = GetComponent<AudioSource>();
        currentAud = Space;
        currentAud.Play();
        AudioData.Instance.audioSource = currentAud;
        SpaceGO.SetActive(true);
        DarkGO.SetActive(false);
        NatureGO.SetActive(false);
        SweetGO.SetActive(false);
    }
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(current);
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

        ////Controller Support////

        if (Input.GetButtonDown("Fire2"))
        {
            Changer(false, current);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            Changer(true, current);
        }

    }

    void Changer(bool next, int curTrack)
    {
        if(next)
        {
            if(curTrack == 1)
            {
                current = 2;
                WorldChangeDark();
                return;
            }
            if (curTrack == 2)
            {
                current = 3;
                WorldChangeNature();
                return;
            }
            if (curTrack == 3)
            {
                current = 4;
                WorldChangeSweet();
                return;
            }
            if (curTrack == 4)
            {
                current = 1;
                WorldChangeSpace();
                return;
            }
        }
        if(!next)
        {
            if (curTrack == 1)
            {
                current = 4;
                WorldChangeSweet();
                return;
            }
            if (curTrack == 2)
            {
                current = 1;
                WorldChangeSpace();
                return;
            }
            if (curTrack == 3)
            {
                current = 2;
                WorldChangeDark();
                return;
            }
            if (curTrack == 4)
            {
                current = 3;
                WorldChangeNature();
                return;
            }
        }
    }

    public void WorldChangeSpace()
    {
        AudioData.Instance.audioSource = currentAud;
        currentAud.Pause();
        CameraFollow.Instance.LevelCheck[0] = true;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
        currentAud = Space;
        currentAud.Play();
        SpaceGO.SetActive(true);
        DarkGO.SetActive(false);
        NatureGO.SetActive(false);
        SweetGO.SetActive(false);
  
    }

    public void WorldChangeDark()
    {
        AudioData.Instance.audioSource = currentAud;
        currentAud.Pause();
        CameraFollow.Instance.LevelCheck[1] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
        currentAud = Dark;
        currentAud.Play();
        DarkGO.SetActive(true);
        SpaceGO.SetActive(false);
        NatureGO.SetActive(false);
        SweetGO.SetActive(false);
    }

    public void WorldChangeNature()
    {
        AudioData.Instance.audioSource = currentAud;
        currentAud.Pause();
        CameraFollow.Instance.LevelCheck[2] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[3] = false;
        currentAud = Nature;
        currentAud.Play();
        NatureGO.SetActive(true);
        SpaceGO.SetActive(false);
        DarkGO.SetActive(false);
        SweetGO.SetActive(false);
    }

    public void WorldChangeSweet()
    {
        AudioData.Instance.audioSource = currentAud;
        currentAud.Pause();
        CameraFollow.Instance.LevelCheck[3] = true;
        CameraFollow.Instance.LevelCheck[0] = false;
        CameraFollow.Instance.LevelCheck[1] = false;
        CameraFollow.Instance.LevelCheck[2] = false;
        currentAud = Sweet;
        currentAud.Play();
        SweetGO.SetActive(true);
        SpaceGO.SetActive(false);
        DarkGO.SetActive(false);
        NatureGO.SetActive(false);
    }
}
