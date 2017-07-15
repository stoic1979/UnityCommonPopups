using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	public static GameController gameController;
	public static GameController instance;
	public GameObject titlePanel;
	public GameObject gameoverPanel;
	public GameObject RateUsPanel;

	void Awake(){
		instance = this;
	}

	public static GameController Instance() {

		if (!gameController) {
			gameController = FindObjectOfType (typeof(GameController)) as GameController;
			if (!gameController) {
				Debug.Log ("There should be atleast one active gameObject of type GameController !!!");
			}
		}
		return gameController;
	}

	public void CancelBtn(){
		titlePanel.SetActive (false);
	}

	public void OkBtn(){
		titlePanel.SetActive (false);
		Debug.Log ("***** Provide Game's video link *****");
		Application.OpenURL ("Fill game video link");
	}

	public void RetryBtn(){
		gameoverPanel.SetActive (false);
		Application.LoadLevel ("GameOverScene");
	}

	public void HomeBtn() {
		Application.LoadLevel ("TitlePopupScene");
	}

	public void Play() {
		Application.LoadLevel ("GameOverScene");
	}

	public void RateBtn(){
		Debug.Log ("***** Provide Game link for Rating *****");
		Application.OpenURL ("Fill the Game /App Link");
	}

	public void RemindMeLaterbtn(){
		Application.LoadLevel ("GameOverScene");
	}

	public void NoThanksBtn(){
		RateUsPanel.SetActive (false);
	}

	public void gameOverbtn(){
		gameoverPanel.SetActive (true);
	}

	public void RateUs(){
		Application.LoadLevel ("RateUsScene");
	}

}//GameController
