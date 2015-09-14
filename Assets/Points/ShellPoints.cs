using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShellPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "Shell: " + (165 + (HandelPointsDisplay.tempShell*.33f) * (10*HandelPointsDisplay.tempLukP)) + "~" + (500 + (HandelPointsDisplay.tempShell) * (10*HandelPointsDisplay.tempLukP));
	}
}
