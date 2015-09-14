using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IntelligencePoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {

		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 5) {
			text.text = "Intelligence: " + HandelPointsDisplay.tempIntP;
		}
		if (Application.loadedLevel == 3) {
			text.text = "Int: " + HandelPointsDisplay.tempIntP;
		}
	}
}
