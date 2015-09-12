using UnityEngine;
using System.Collections;

public class OnClickPlayerHud : MonoBehaviour {

	public GameObject letters;
	public GameObject inventory;
	public GameObject skills;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Letters(){
		letters.SetActive (true);
	}

	public void Inventory(){
		inventory.SetActive (true);
	}

	public void Skills(){
		skills.SetActive (true);
	}
}
