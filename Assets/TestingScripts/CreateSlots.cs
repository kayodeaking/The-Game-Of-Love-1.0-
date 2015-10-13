using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using System.Collections;

public class CreateSlots : MonoBehaviour {

	public int columns, rows;
	public List<TestItem> inventory = new List<TestItem>();
	private TestItemDatabase database;
	public GameObject slotPrefab;
	public List<GameObject>allSlots = new List<GameObject> ();

	public GameObject tooltip;

	// Use this for initialization
	void Start () {
		//I put the database as in item in the sceen so it searches for it
		database = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<TestItemDatabase> ();

		/*loops throught the rows and columns and creates a Slot for each position in a rown 
		and column then adds it to a list of gameobjects*/
		for (int y = 0; y < rows; y++) {
			for (int x = 0; x < columns; x++) {
				inventory.Add (new TestItem());
				GameObject newSlot = Instantiate (slotPrefab);

				newSlot.transform.SetParent (transform);

				newSlot.transform.localPosition = new Vector3 (-125 + (75 * x), 170 - (75 * y));

				newSlot.name = "Slots";
				allSlots.Add (newSlot);
			}
		}
	}
	
	public void AddItem(int itemID) {


		for (int i = 0; i < allSlots.Count; i++) {
			/*Takes the itemid that you wanted to add and searches for an empty slot
			  then adds the item by calling the AddItem function*/	
			if (allSlots[i].transform.GetChild (0).GetComponent<UIItem> ().isEmpty == true) {
				allSlots[i].transform.GetChild (0).GetComponent<UIItem> ().AddItem (database.items [itemID].itemIcon, database.items [itemID]);
				break;
			} else if (allSlots[i].transform.GetChild (0).GetComponent<UIItem> ().slotsItem.itemId == itemID) {
				/*If this item was already in the slot it checks if it has room to add 
				 to the stack. If it does then it increases the stack by 1*/
				if(allSlots[i].transform.GetChild (0).GetComponent<UIItem>().itemStack.Count < allSlots[i].transform.GetChild (0).GetComponent<UIItem>().slotsItem.itemMaxStack) {
					allSlots[i].transform.GetChild (0).GetComponent<UIItem>().Combined (allSlots[i].transform.GetChild (0).gameObject , 1);
					break;
				}
			} else {

			}
		}
	}

	public void UseItem(int itemID) {
		/*Takes the item id you want to use and goes through the slots and looks for 
		 a slot with an item that matches it and then call the item UseCousumeable function */
		for (int i = 0; i < allSlots.Count; i++) {
			if(allSlots[i].transform.GetChild (0).GetComponent<UIItem>().slotsItem.itemId == itemID) {
				allSlots[i].transform.GetChild (0).GetComponent<UIItem> ().UseCosumeable(allSlots[i].transform.GetChild (0).gameObject, itemID);
				print("" + allSlots[i] + i);
				break;
			}
		}
	}
	public void ShowToolTip() {
	}

	// Update is called once per frame
	void Update () {
		//Just adds to the inventory
		if (Input.GetKeyDown (KeyCode.A)) {
			AddItem (1);
			AddItem (1);
			AddItem (4);
			AddItem (4);
			AddItem (4);
			AddItem (4);
			AddItem (4);
			AddItem (4);
			AddItem (3);
		}

		//just uses the item
		if (Input.GetMouseButtonDown (0) == true) {
			UseItem(4);
		}
	}
}
