using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text ScoreText;

    public string SoundCloudURL;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        ScoreText.text = Player.Instance.PickUps + "";
        QuitGame();
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape) == true)
        {
            Application.Quit();
            print("Quit");
        }
    }

    public void URL()
    {
        Application.OpenURL(SoundCloudURL);
    }


}
