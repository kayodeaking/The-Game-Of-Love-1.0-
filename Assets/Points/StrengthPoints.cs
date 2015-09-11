using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StrengthPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Application.loadedLevel == 5) {
			text.text = "Strength: " + HandelPointsDisplay.tempStrP;
		}
		if (Application.loadedLevel == 3) {
			text.text = "Str: " + HandelPointsDisplay.tempStrP;
		}
	}
}
