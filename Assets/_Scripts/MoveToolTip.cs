using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MoveToolTip : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move() {
		float x = Input.mousePosition.x + 70;
		float y = Input.mousePosition.y - 80;
		Vector3 pos = new Vector3 (x, y, 0);
		this.transform.position = pos;
	}
}
