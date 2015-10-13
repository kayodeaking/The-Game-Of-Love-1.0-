using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class UISlot : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

	/*Checks if the slot has a child (an item) in them that name is not transparent
	 (since all the slots have a child in them their names are initial transparent)
	 if it does the "item" is returned*/
	public string item {
		get {
			if (transform.GetChild (0).GetComponent<Image>().sprite.name != "Transparent") {
				return transform.GetChild (0).GetComponent<Image>().sprite.name;
			}
			return null;
		}
	}

	/*Gets the position of the Item relative to the screen*/
	public Vector3 itemPos {
		get {
			return transform.GetChild (0).position;
		}
	}
	
	#region IDropHandler implementation
	//What happens when you drop an Item being dragged
	public void OnDrop (PointerEventData eventData)
	{
		//If there is no item
		if (item == null) {
			//turns the item being draged position to this position
			UIItem.dragItem.transform.position = itemPos;
			//turns this items (blank item) to the drag items old position
			transform.GetChild (0).transform.position = UIItem.passedPos;
			//makes this items parent the dragged items parent;
			transform.GetChild (0).transform.SetParent (UIItem.dragItem.transform.parent);
			//makes the drag items parent this slot
			UIItem.dragItem.transform.SetParent (transform);
		} else if (item == UIItem.dragItem.GetComponent<Image> ().sprite.name) { 
			//If the Item is the same as the item being dragged

			if(transform.GetChild (0).GetComponent<UIItem>().itemStack.Count < transform.GetChild (0).GetComponent<UIItem>().slotsItem.itemMaxStack &&
			   UIItem.dragItem.GetComponent<UIItem>().itemStack.Count <  UIItem.dragItem.GetComponent<UIItem>().slotsItem.itemMaxStack) {
				//If the item stack isn't greater than the highest count it can have

				//Calls the Items Combine fuction
				transform.GetChild (0).GetComponent<UIItem>().Combined (transform.GetChild (0).gameObject, UIItem.dragItem.GetComponent<UIItem>().itemStack.Count);
				//Callls the Items Make Blank function
				UIItem.dragItem.GetComponent<UIItem>().MakeBlank (UIItem.dragItem, UIItem.dragItem.transform.GetComponent<UIItem>().itemStack.Count);
			} else { 
				//If the item stack is greater than the highest count it can have
			
				//turns the item being draged position to this position
				UIItem.dragItem.transform.position = itemPos;
				//turns this items to the drag items old position
				transform.GetChild (0).transform.position = UIItem.passedPos;
				//makes this items parent the dragged items parent;
				transform.GetChild (0).transform.SetParent (UIItem.dragItem.transform.parent);
				//makes the drag items parent this slot
				UIItem.dragItem.transform.SetParent (transform);
			}
		} else { 
			//if there is an item and it isn't the same as the item being dragged

			//turns the item being draged position to this position
			UIItem.dragItem.transform.position = itemPos;
			//turns this items to the drag items old position
			transform.GetChild (0).transform.position = UIItem.passedPos;
			//makes this items parent the dragged items parent;
			transform.GetChild (0).transform.SetParent (UIItem.dragItem.transform.parent);
			//makes the drag items parent this slot
			UIItem.dragItem.transform.SetParent (transform);
		}
	}

	#endregion

	#region IPointerEnterHandler implementation
	
	public void OnPointerEnter (PointerEventData eventData)
	{
	}
	
	#endregion
	
	#region IPointerExitHandler implementation
	
	public void OnPointerExit (PointerEventData eventData)
	{
	}
	
	#endregion

}
