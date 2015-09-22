using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoExp : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.exp > 0) {
				text.text = "Exp: " + MonsterInfo.exp;
			}
		} else {
			text.text = "Exp:";
		}
	}
}
