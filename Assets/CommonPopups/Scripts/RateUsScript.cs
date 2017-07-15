using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateUsScript : MonoBehaviour {

	public string RateMessageValue;
	public Text RateMessageText;

	// Use this for initialization
	void Start () {
		RateMessageText.text = RateMessageValue;
	}

}//RateUsScript
