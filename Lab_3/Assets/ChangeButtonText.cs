using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour {

	// Button we are going to change the text of.
	public Button button;
	string buttonKey = "INITIAL_BUTTON_TEXT_VALUE";
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey (buttonKey)) {
			Text buttonText = button.GetComponentInChildren<Text>();
			buttonText.text = PlayerPrefs.GetString (buttonKey);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeText() {
		if(button) {
			// Gets the Text child object of the button so that we can set its text.
			Text buttonText = button.GetComponentInChildren<Text>();
			switch(buttonText.text){
			case "OFF":
				buttonText.text = "ON";
				PlayerPrefs.SetString (buttonKey, buttonText.text);
				PlayerPrefs.Save ();
				break;
			case "ON":
				buttonText.text = "OFF";
				PlayerPrefs.SetString (buttonKey, buttonText.text);
				PlayerPrefs.Save ();
				break;
			default:
				break;
			}

		}
	}
}
