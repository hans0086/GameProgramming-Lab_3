using UnityEngine;
using UnityEngine.UI;

public class SaveSlider : MonoBehaviour {

	public Slider valueSlider;
	string sliderKey = "VALUE_SLIDER_INITIAL_VALUE";

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey(sliderKey)) {
			valueSlider.value = PlayerPrefs.GetFloat(sliderKey);
		}
		else {
			PlayerPrefs.SetFloat(sliderKey, valueSlider.value);
			PlayerPrefs.Save();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}

	public void SaveSliderValue() {
		// Will create new/override existing value.
		PlayerPrefs.SetFloat(sliderKey, valueSlider.value);
		PlayerPrefs.Save();
	}
}
