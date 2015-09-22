using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoSkill2 : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.skill2cost > 0) {
				text.text = "Skill 2: " + MonsterInfo.skill2 + " " + MonsterInfo.skill2cost + "Love";
			}
		} else {
			text.text = "Skill 2:";
		}
	}
}
