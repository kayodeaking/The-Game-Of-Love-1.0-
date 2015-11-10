using UnityEngine;
using System.Collections;

public class PlayerInventory : MonoBehaviour {
	public GameObject inventory;
	Inventory inven;
	// Use this for initialization
	void Start () {
		inven = inventory.GetComponent<Inventory>();

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Item") {
			GetComponent<SoundEffects> ().PlaySound (3);
			inven.Add (new Inventory_item(col.gameObject.GetComponent<Item_View>().item));
			print ("Added "+ col.gameObject.GetComponent<Item_View>().item.name+ "  to inventory");
			Destroy (col.gameObject);
		}
		
	}


}
