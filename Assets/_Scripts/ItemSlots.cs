using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class ItemSlots : MonoBehaviour, IDropHandler {

	public GameObject item {
		get {
			if (transform.childCount > 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		if (DragHandler.dragItem.tag == "Potions") {
			if (!item) {
				DragHandler.dragItem.transform.SetParent (transform);
			} else {
				if (item.name != DragHandler.dragItem.name) {
					Destroy (item);
					DragHandler.dragItem.transform.SetParent (transform);
				} else {
					Destroy (item);
					DragHandler.dragItem.transform.SetParent (transform);
					item.GetComponent<UpdateStack>().CombineStack();
				}
			} 
		} else { 
			Destroy(DragHandler.dragItem);
		}
	}
	
	#endregion
}