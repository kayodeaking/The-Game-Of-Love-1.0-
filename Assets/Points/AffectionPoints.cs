using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AffectionPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Affection: " + (49.5 + (HandelPointsDisplay.tempAff*.33f) * (3*HandelPointsDisplay.tempIntP)) + "~" + (150 + (HandelPointsDisplay.tempAff) * (3*HandelPointsDisplay.tempIntP));
	}
}
