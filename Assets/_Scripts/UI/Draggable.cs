using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class Draggable : MonoBehaviour,IBeginDragHandler, IDragHandler, IEndDragHandler {
	public  GameObject dragItem;
	Vector3 startPos;
	public Vector3 passedPos;
	Transform startParent;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	#region IBeginDragHandler implementation
	
	//When you first grab the item in the slot
	public void OnBeginDrag (PointerEventData eventData)
	{
		/*Sets the item you are draging to this and saves its parent & position
		 Then stops the canvas group from raycasts*/
		dragItem = gameObject;
		startPos = transform.position;
		passedPos = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup> ().blocksRaycasts = false; 
	}
	
	#endregion
	
	#region IDragHandler implementation
	//While you are still dragging the item
	public void OnDrag (PointerEventData eventData)
	{
		//Moves the position of the item realtive to the mouse
		transform.position = Input.mousePosition;
	}
	
	#endregion
	
	#region IEndDragHandler implementation
	//Once you let go of the item
	public void OnEndDrag (PointerEventData eventData)
	{
		/*makes the item being draged null and if it wasn't added to a different item 
		 it snaps the item back to its old spot*/
		dragItem = null;
		if (transform.parent == startParent) {
			transform.position = startPos;
		}
		GetComponent<CanvasGroup> ().blocksRaycasts = true; 
		
	}
	
	#endregion

}
