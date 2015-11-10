using UnityEngine;
using System.Collections;
[System.Serializable]
public class Inventory_item {
	[SerializeField]
	public Item item;
	[SerializeField]
	public int stack;

	public Inventory_item(Item item){
		this.item = item;
	}


}
