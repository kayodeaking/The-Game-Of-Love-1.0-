using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Slots : MonoBehaviour, IDropHandler   {

	public static GameObject slot;
	
	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}
	
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData) {
		if (gameObject.name == "Equip_Slot") {
			EquipSlot ();
		}
		if (gameObject.name == "Inventory_Slot") {
			ItemSlot ();
		}
	}
	
	#endregion
	
	public void GetSlot() {
		slot = this.gameObject;
	}
	
	void EquipSlot() {
		if (!item) {
			DragHandler.dragItem.transform.SetParent (transform);
			Destroy (DragHandler.initItem);
		} else {
			item.transform.SetParent (DragHandler.initItem.transform.parent.transform);
			DragHandler.dragItem.transform.SetParent (transform);
			Destroy (DragHandler.initItem);
		}
		DragHandler.dragItem.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
		DragHandler.dragItem.GetComponent<RectTransform> ().localRotation = new Quaternion (0, 0, 0, 0);
	}
	
	void ItemSlot() {
		if (!item) {
			DragHandler.dragItem.transform.SetParent (transform);
		} else {
			if (DragHandler.dragItem.name == item.name) {
				Destroy (item);
				DragHandler.dragItem.transform.SetParent (transform);
				DragHandler.dragItem.GetComponent<UpdateStack>().CombineStack();
			} else {
				Destroy (item);
				DragHandler.dragItem.transform.SetParent (transform);
			}
		}
		DragHandler.dragItem.gameObject.GetComponent<DragHandler> ().enabled = false;
	}
	
	void InvSlot() {
		if (!item) {
			DragHandler.dragItem.transform.SetParent (transform);
			Destroy (DragHandler.initItem);
		} else {
			if (DragHandler.dragItem.name == item.name) {
				Destroy (item);
				DragHandler.dragItem.transform.SetParent (transform);
				DragHandler.dragItem.GetComponent<UpdateStack>().CombineStack();
				Destroy (DragHandler.initItem);
			} else {
				item.transform.SetParent (DragHandler.initItem.transform.parent.transform);
				DragHandler.dragItem.transform.SetParent (transform);
				Destroy (DragHandler.initItem);
			}
		}
		DragHandler.dragItem.GetComponent<RectTransform> ().localScale = new Vector3 (1, 1, 1);
		DragHandler.dragItem.GetComponent<RectTransform> ().localRotation = new Quaternion (0, 0, 0, 0);
	}
	
	void SkillSlot() {
		if (!item) {
			DragHandler.dragItem.transform.SetParent (transform);
		} else {
			if (DragHandler.dragItem.name == item.name) {
				Destroy (item);
				DragHandler.dragItem.transform.SetParent (transform);
			} else {
				Destroy (item);
				DragHandler.dragItem.transform.SetParent (transform);
			}
		}
		DragHandler.dragItem.gameObject.GetComponent<DragHandler> ().enabled = false;
	}

	public void AddToSlot(GameObject newItem) {
		if (!item) {
			newItem.transform.SetParent (transform);
		}
	}
}
