using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text PickUp;

	// Use this for initialization
	public void Update() 
	{
		Debug.Log ("Show Score");
		ScoreDisplay();
	}


	void Start () {
		Debug.Log ("Show Score");
	}
	
	// Update is called once per frame

	void ScoreDisplay()
	{
		PickUp.text = Player.Instance.PickUps + "";
		Debug.Log ("Show Score");
	}
}
