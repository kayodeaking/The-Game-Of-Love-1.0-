using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoLove : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.love > 0) {
				text.text = "Love: " + MonsterInfo.love;
			}
		} else {
			text.text = "Love:";
		}
	}
}
