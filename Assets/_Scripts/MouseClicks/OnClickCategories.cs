using UnityEngine;
using System.Collections;

public class OnClickCategories : MonoBehaviour {

	public GameObject weapons;
	public GameObject armor;
	public GameObject items;
	public GameObject special;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Weapons() {
		weapons.SetActive (true);
		armor.SetActive (false);
		items.SetActive (false);
		special.SetActive (false);
	}

	public void Armor() {
		weapons.SetActive (false);
		armor.SetActive (true);
		items.SetActive (false);
		special.SetActive (false);
	}

	public void Items() {
		weapons.SetActive (false);
		armor.SetActive (false);
		items.SetActive (true);
		special.SetActive (false);
	}

	public void Special() {
		weapons.SetActive (false);
		armor.SetActive (false);
		items.SetActive (false);
		special.SetActive (true);
	}

	public void Exit() {
		weapons.SetActive (false);
		armor.SetActive (false);
		items.SetActive (false);
		special.SetActive (false);
	}
}
