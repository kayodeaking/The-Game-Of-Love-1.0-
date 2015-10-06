﻿using UnityEngine;
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
	
	#endregion
}