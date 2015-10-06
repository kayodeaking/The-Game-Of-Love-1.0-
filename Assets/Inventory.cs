using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<GameObject> itemSlotsList;
	public static List<GameObject> items;

	// Use this for initialization
	void Start () {
	
		items = new List<GameObject> ();
		itemSlotsList = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable () {
		CheckSlot ();
	}

	public static void AddToInv(GameObject item) {

		if (item != null) {
			items.Add (item);
		}
		print ("added to Inv");
	}

	public void CheckSlot() {

		GameObject itemInSlot;
		for (int x = 0; x < itemSlotsList.Count; x++) {

			if (itemSlotsList[x].transform.childCount > 0) {
				itemInSlot = itemSlotsList[x].transform.GetChild (0).gameObject;
			} else {
				itemInSlot = null;
			}

			if(!itemInSlot) {
				print ("Item Added");
				x = itemSlotsList.Count;
			} else {
				print ("Item Not Added");
			}
		}
	}
}
