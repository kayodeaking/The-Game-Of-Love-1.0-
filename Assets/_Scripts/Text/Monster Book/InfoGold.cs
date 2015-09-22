using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoGold : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.gold > 0) {
				text.text = "Gold: " + MonsterInfo.gold;
			}
		} else {
			text.text = "Gold:";
		}
	}
}
