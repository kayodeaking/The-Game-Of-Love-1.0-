using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BloodPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
			text.text = "Blood: " + HandelPointsDisplay.tempBlP + "/" + HandelPointsDisplay.tempBlP;
	}
}
