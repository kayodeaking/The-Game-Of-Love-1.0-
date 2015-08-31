using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChapterTitle : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

		if (OnClickChapters.currChapter == 1) {
			text.text = "Break Up";
		} else if (OnClickChapters.currChapter == 2) {
			text.text = "New Begining";
		} else if (OnClickChapters.currChapter == 3) {
			text.text = "New Hope";
		} else if (OnClickChapters.currChapter == 4) {
			text.text = "Jealousy";
		} else {
			text.text = "Finally";
		}
	
	}
}
