using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Tooltip : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move() {//Moves the tooltip around
		print ("" + gameObject);
		print ("" + transform.position);
		transform.position = new Vector3 (Input.mousePosition.x + 75, Input.mousePosition.y - 100);
	}

	public void Info(TestItem item) {//Dispalys the name of the item in the tooltip
		print (item.itemName);
	}

}
