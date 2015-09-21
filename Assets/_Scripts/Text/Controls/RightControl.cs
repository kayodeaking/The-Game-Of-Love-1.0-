using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RightControl : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Player_Control.moveSet == 1) {
			text.text = "Move Right: Right Arrow Key";
		}
		
		if (Player_Control.moveSet == 2) {
			text.text = "Move Right: D Key";
		}
	}
}
