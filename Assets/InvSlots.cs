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
	
	#region IDropHandler implementation
	
	public void OnDrop (PointerEventData eventData)
	{
		if (DragHandler.dragItem.tag == "Potions") {
			if (!item) {
				DragHandler.dragItem.transform.SetParent (transform);
				//Destroy (DragHandler.dragItem);
				//Destroy (item);
			} else {
				if ((item.name + "(Clone)") != DragHandler.dragItem.name) {
					Destroy (DragHandler.dragItem);
					DragHandler.dragItem.transform.SetParent (transform);
				} else {
					Destroy (DragHandler.dragItem);
					DragHandler.dragItem.transform.SetParent (transform);
					item.GetComponent<UpdateStack>().CombineStack();
					Destroy (item);
				}
			} 
		} else { 
			Destroy(DragHandler.dragItem);
		}
	}
	
	#endregion
}
