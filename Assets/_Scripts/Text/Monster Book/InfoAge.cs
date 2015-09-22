using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoAge : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.age > 0) {
				text.text = "Age: " + MonsterInfo.age;
			}
		} else {
			text.text = "Age:";
		}
	}
}
