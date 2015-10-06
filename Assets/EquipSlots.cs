using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class EquipSlots : MonoBehaviour, IDropHandler  {

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
	}
	
	#endregion

	public void GetSlot() {
		slot = this.gameObject;
	}

	public void EquipSlot() {
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

	public void ItemSlot() {
	}

	public void InvSlot() {
	}

	public void SkillSlot() {
	}
}
