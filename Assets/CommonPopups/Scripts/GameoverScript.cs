using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameoverScript : MonoBehaviour {
	
	public string  DescriptionValue; 
	public Text    DescriptionText;
	public Sprite  gameOverIcon;
	public Image   gameOverImage; 

	// Use this for initialization
	void Start () {			
		DescriptionText.text = DescriptionValue;
		gameOverImage.sprite = gameOverIcon;
	}

}//GameoverScript
