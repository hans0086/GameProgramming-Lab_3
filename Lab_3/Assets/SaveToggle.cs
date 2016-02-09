using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SaveToggle : MonoBehaviour {
	public Toggle toggle;
	string toggleKey = "INITIAL_TOGGLE_VALUE";
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey (toggleKey)) {
			//if the toggleKey exists and is set to 1
			if (PlayerPrefs.GetInt (toggleKey) == 1) {
				//check the toggle
				toggle.isOn = true;
			} 
			else {
				//uncheck the toggle
				toggle.isOn = false;
			}
		} 
		else {
			saveToggleValue ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void saveToggleValue(){
		if (toggle.isOn == true) {
			//create case for "checked" state
			PlayerPrefs.SetInt (toggleKey, 1);
		} else {
			//create case for "unchecked" state
			PlayerPrefs.SetInt (toggleKey, 0);
		}
		//save the current state
		PlayerPrefs.Save ();
	}
}
