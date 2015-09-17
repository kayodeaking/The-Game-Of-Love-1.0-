﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpControl : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Player_Control.moveSet == 1) {
			text.text = "Move Up: Up Arrow Key";
		}

		if (Player_Control.moveSet == 2) {
			text.text = "Move Up: W Key";
		}
	}
}