using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class Slots : MonoBehaviour , IDropHandler{

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
		if (DragHandler.dragItem.tag != "Equipment") {
			if (!item) {
				DragHandler.dragItem.transform.SetParent (transform);
			} else if (item.name != DragHandler.dragItem.name) {
				Destroy (transform.GetChild (0).gameObject);
				DragHandler.dragItem.transform.SetParent (transform);
			}
		}
	}

	#endregion
}
