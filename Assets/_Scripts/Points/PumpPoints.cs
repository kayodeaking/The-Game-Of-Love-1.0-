using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PumpPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "Pump: " + (82.5 + (HandelPointsDisplay.tempPump*.33f) * (5*HandelPointsDisplay.tempStrP)) + "~" + (250 + (HandelPointsDisplay.tempPump) * (5*HandelPointsDisplay.tempStrP));
	}
}
