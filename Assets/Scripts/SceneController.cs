using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {


    public GameObject WorldObject;

    public string SoundCloudURL;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        QuitGame();
    }

    public void PlayGame()
    {

        WorldObject.SetActive(true);
    }

    public void URL()
    {
        Application.OpenURL(SoundCloudURL);
    }

    
}
