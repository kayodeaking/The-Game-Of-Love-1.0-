using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoBlood : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.blood > 0) {
				text.text = "Blood: " + MonsterInfo.blood;
			}
		} else {
			text.text = "Blood:";
		}
	}
}
