using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DexterityPoints : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Application.loadedLevel == 5) {
			text.text = "Dexterity: " + HandelPointsDisplay.tempDexP;
		}
		if (Application.loadedLevel == 3) {
			text.text = "Dex: " + HandelPointsDisplay.tempDexP;
		}
	}
}
