using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Inventory : MonoBehaviour {
	public GameObject Slot;
	[SerializeField]
	private List<Item> inventory;
	public List<GameObject> inventoryUI;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Add(Item item){
		inventory.Add(item);
	}
	public void Remove(Item item){
		inventory.Remove (item);
		
	}
	public void RemoveAt(int index){
		inventory.RemoveAt (index);
	}
	
	public int COUNT{
		get { return inventory.Count; }
		
	}
	public Item Item(int index){
		return inventory.ElementAt( index );
	}
	[ContextMenu("MakeSlots")]
	public void MakeSlots(){

		for(int i =0;i<inventory.Count;i++){

			GameObject go  =  Instantiate(Slot) as GameObject;
			go.transform.SetParent(gameObject.transform);
			go.GetComponent<Inventory_slot>().itemView.item= inventory[i];
			inventoryUI.Add (go);

		}


	}
	[ContextMenu("DeleteSlots")]
	public void DeleteSlots(){

		for(int i =0;i<inventoryUI.Count;i++){

			GameObject go = inventoryUI[i] as GameObject;

		///	Destroy(inventoryUI[i]);
			DestroyImmediate(go);

		}
		inventoryUI.Clear();




	}
	void OnEnable(){
		//MakeSlots();

	}

	void OnDisable (){
		//DeleteSlots();

	}
}
