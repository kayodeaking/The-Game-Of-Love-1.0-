using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoSkill1 : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.skill1cost > 0) {
				text.text = "Skill 1: " + MonsterInfo.skill1 + " " + MonsterInfo.skill1cost + "Love";
			}
		} else {
			text.text = "Skill 1:";
		}
	}
}
