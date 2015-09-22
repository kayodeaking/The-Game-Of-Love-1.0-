using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoType : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.type != null) {
				text.text = "Type: " + MonsterInfo.type;
			}
		} else {
			text.text = "Type:";
		}
	}
}
