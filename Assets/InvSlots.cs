using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class InvSlots : MonoBehaviour, IDropHandler {

	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}

	public static GameObject invSlot;

	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
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
	
	#endregion

	public void GetSlot() {
		invSlot = this.gameObject;
	}
}
