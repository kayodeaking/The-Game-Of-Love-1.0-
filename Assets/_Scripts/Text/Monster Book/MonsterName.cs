using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MonsterName : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			text.text = "001. " + MonsterInfo.enemyButName;
		} else {
			text.text = "001. ------------------------------------";
		}
	}
}
