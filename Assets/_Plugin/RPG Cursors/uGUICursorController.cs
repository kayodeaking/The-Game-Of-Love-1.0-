using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class uGUICursorController : MonoBehaviour {

	public Sprite[] cursors;

	public Image cursorImage; 

	private int selectedCursor;

	public void Start() {
		Cursor.visible = false;
	}

	void ChangeCursor() {
		cursorImage.sprite = cursors[selectedCursor];
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.DownArrow)) {
			if(selectedCursor < cursors.Length - 1) {
				selectedCursor++;
				ChangeCursor();
			}
		}
		else if(Input.GetKeyDown(KeyCode.UpArrow)) {
			if(selectedCursor > 0) {
				selectedCursor--;
				ChangeCursor();
			}
		}

		cursorImage.rectTransform.position = Input.mousePosition;
	}
}
