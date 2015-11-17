using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
public class UI_Slot : MonoBehaviour,IDropHandler {
	
	public int id;
	public GameObject Child;
	private Inventory inv;
	
	void Start(){
		if(transform.childCount==1){
		Child = transform.GetChild(0).gameObject;
		}
		inv = GameObject.Find("Inventory").GetComponent<Inventory>();
		
	}
	
    public void OnDrop(PointerEventData data)
    {
		if(transform.childCount>0){
			Transform op = data.pointerDrag.gameObject.GetComponent<UI_Item>().orginalParent;
			data.pointerDrag.gameObject.transform.SetParent(op);
			data.pointerDrag.gameObject.transform.position = op.position;
			
			return;
		}
		
		
		GameObject droppedObject = data.pointerDrag.gameObject;
		if(droppedObject!=null){
			droppedObject.GetComponent<UI_Item>().orginalParent = this.transform;
			droppedObject.transform.SetParent(this.transform);
			droppedObject.transform.position = this.transform.position;
			
			
			
		}
		
	 
    }
	
	void TestDrop(PointerEventData eventData){
		
		/*
     UI_Item droppedItem = eventData.pointerDrag.GetComponent<UI_Item>();
	 if(inv.items[id].ID==-1){
		 inv.items[droppedItem.slot] = new Item();
		 inv.items[id] = droppedItem.item;
		 droppedItem.slot = id;
		 
	 
	 }
	 
	 else if(droppedItem.slot!=id){
		 
		 Transform item = this.transform.GetChild(0);
		 item.GetComponent<UI_Item>().slot = droppedItem.slot;
		 
		 item.transform.SetParent(inv.slots[droppedItem.slot].transform);
		 item.transform.position = inv.slots[droppedItem.slot].transform.position;
		 
		 droppedItem.slot =id;
		 droppedItem.transform.SetParent(this.transform);
		 droppedItem.transform.position = this.transform.position;
		 
		 inv.items[droppedItem.slot] = item.GetComponent<UI_Item>().item;
		 inv.items[id]= droppedItem.item;
		 
	 }
	 */
	}
	void Update(){
		if(transform.childCount==1){
		Child = transform.GetChild(0).gameObject;
		}
	}


}
