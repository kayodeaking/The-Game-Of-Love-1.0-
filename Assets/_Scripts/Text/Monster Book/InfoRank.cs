using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoRank : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
	
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.rank > 0) {
				text.text = "Rank: " + MonsterInfo.rank;
			}
		} else {
			text.text = "Rank:";
		}
	}
}
