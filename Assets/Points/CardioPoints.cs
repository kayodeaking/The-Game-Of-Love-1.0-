using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CardioPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		text.text = "Cardio: " + (33 + (HandelPointsDisplay.tempCardio*.33f) * (2*HandelPointsDisplay.tempDexP)) + "~" + (100 + (HandelPointsDisplay.tempCardio) * (2*HandelPointsDisplay.tempDexP));
	}
}
