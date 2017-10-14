using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public GameObject MainMenu;
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
        MainMenu.SetActive(false);
        WorldObject.SetActive(true);
    }

    public void URL()
    {
        Application.OpenURL(SoundCloudURL);
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
            print("Quit");
        }
    }
}
