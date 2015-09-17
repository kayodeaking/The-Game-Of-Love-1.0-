using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHudLove : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		text.text = HandelPointsDisplay.tempLoveP + "/" + HandelPointsDisplay.tempLoveP;
	}
}
