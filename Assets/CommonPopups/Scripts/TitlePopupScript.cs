using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitlePopupScript : MonoBehaviour {

	public string TitleValue ;
	public string DescriptionValue ;
	public Text TitleText ;
	public Text DescriptionText ;

	// Use this for initialization
	void Start () {
		
		if(PlayerPrefs.GetInt("FIRST_TIME_OPENING",1) == 1){
			
			TitleText.text       = TitleValue;
			DescriptionText.text = DescriptionValue;
			gameObject.SetActive (true);
			PlayerPrefs.SetInt ("FIRST_TIME_OPENING", 0); 
		} else {
			gameObject.SetActive (false);
		}
	}

}//TitlePopupScript
