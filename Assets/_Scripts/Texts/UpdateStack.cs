using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UpdateStack : MonoBehaviour {

	public GameObject stockText {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	//public static string itemName;
	public static int stack = 5;

	// Use this for initialization
	void Start () {
	
		//itemName = this.gameObject.name;
	}
	
	// Update is called once per frame
	void Update () {

		stockText.GetComponent<Text> ().text = "" + stack;

		if (stockText.GetComponent<Text> ().text == "0") {
			Destroy(gameObject);
		}

		if (stack >= 99) {
			stack = 99;
		}
	}

	public void UsePotion () {
		stack -= 1;
		Player_Stats.currBlood += 50;
		Player_Stats.currLove += 50;
	}

	public void IncPotion () {

	}

	public void CombineStack() {
		stack += stack;
	}
}
