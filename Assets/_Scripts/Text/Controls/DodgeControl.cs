using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DodgeControl : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Player_Control.moveSet == 1) {
			text.text = "Dodge: F Key";
		}
		
		if (Player_Control.moveSet == 2) {
			text.text = "Dodge: Spacebar";
		}
	}
}
