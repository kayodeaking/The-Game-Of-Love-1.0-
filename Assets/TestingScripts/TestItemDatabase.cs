using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TestItemDatabase : MonoBehaviour {
	
	//My database holding all my items
	public List<TestItem> items = new List<TestItem>();
	
	void Start() {
		items.Add (new TestItem("Blank", 0, "Blank", 0, 0, 0, TestItem.Type.Armor));
		items.Add (new TestItem("Necklace", 1, "Magic", 5, 0, 1, TestItem.Type.Weapon));
		items.Add (new TestItem("Key", 2, "Health", 5, 0, 3, TestItem.Type.Consumable));
		items.Add (new TestItem("Red Potion", 3, "Health", 5, 0, 2, TestItem.Type.Consumable));
		items.Add (new TestItem("Blue Potion", 4, "Health", 5, 0, 5, TestItem.Type.Consumable));
	}
}
