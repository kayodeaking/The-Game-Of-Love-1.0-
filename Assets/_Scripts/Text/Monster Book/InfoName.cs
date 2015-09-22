using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoName : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.enemyName != null) {
				text.text = "Name: " + MonsterInfo.enemyName;
			}
		} else {
			text.text = "Name:";
		}
	}
}
