using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class UIItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public TestItem slotsItem;
	public Stack<TestItem> itemStack = new Stack<TestItem> ();
	public Sprite empty;
	
	public static GameObject dragItem;
	Vector3 startPos;
	public static Vector3 passedPos;
	Transform startParent;

	//Looks at this item and sees if its sprite is transparent if it is then the item isn't there
	public bool isEmpty {
		get {
			if (GetComponent<Image> ().sprite.name == "Transparent") {
				return true;
			}
			return false;
		}
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
	
	public void AddItem(Sprite item, TestItem stack) {
		//After being sent the item sprite and item it checks if the item is "empty"
		if (isEmpty) {
			/*This slots item gameobject then is the item passed and the item is then named
			 after its item. The image and stock number are also turned on*/
			slotsItem = stack;
			gameObject.name = slotsItem.itemName;
			this.GetComponent<Image> ().enabled = true;
			this.transform.GetChild (0).GetComponent<Text> ().enabled = true;
			/*a double check to make sure it isn't already transparent if not the
			 item gameobject sprite is now turned into the sprite that was passsed in*/
			if (item.name != "Transparent") {
				this.GetComponent<Image> ().sprite = item;
			} else {
				this.GetComponent<Image> ().sprite = empty;
			}
			/*The stack is then increased by 1*/
			itemStack.Push (stack);

			/*If the stack count is greater than one then it will display a number*/
			if (itemStack.Count > 1) {
				this.transform.GetChild (0).GetComponent<Text> ().text = itemStack.Count.ToString ();
			} else {
				this.transform.GetChild (0).GetComponent<Text> ().text = "";
			}
		} else {
		}
	}

	public void MakeBlank (GameObject item, int count) {
		//What happens when the item is no longer in the slot

		/*The item in the slot is turned back to null, the name is returned to its default name
		 all the stack is poped out, the image is returned to empty (transparent), and then the 
		 text is made unseeable*/
		slotsItem = null;
		gameObject.name = "Item";
		for (int i = 0; i < count; i++) {
			item.GetComponent<UIItem>().itemStack.Pop ();
		}
		item.GetComponent<Image> ().sprite = empty;
		this.GetComponent<Image> ().enabled = false;
		this.transform.GetChild (0).GetComponent<Text> ().enabled = false;
	}

	public void Combined(GameObject item, int count) {
		//What happens when the item is combine with itself
		/*The slot item stays the same and then the item stack is pushed the item * the amount of 
		 * stack of the other item, then the text is refreshed*/
		slotsItem = slotsItem;
		for (int i = 0; i < count; i++) {
			item.GetComponent<UIItem>().itemStack.Push (slotsItem);
		}
			this.transform.GetChild (0).GetComponent<Text>().text = itemStack.Count.ToString ();
	}

	public void UseCosumeable(GameObject item, int id) {
		//What happens when you consume an item

		/*The item in the slot is found through its id and depending on the id the case (or thing that should happen)
		 changes*/
		switch (this.slotsItem.itemId) {
		case 2:
			{
				print ("Consumed " + slotsItem.itemName);//Stat Id, Buff Amount, Buff Time;
				this.itemStack.Pop ();
				this.transform.GetChild (0).GetComponent<Text> ().text = itemStack.Count.ToString ();
			}
			break;
		case 3:
			{
				print ("Consumed " + slotsItem.itemName);//Stat Id, Buff Amount, Buff Time;
				this.itemStack.Pop ();
				this.transform.GetChild (0).GetComponent<Text> ().text = itemStack.Count.ToString ();
			}
			break;
		case 4:
			{
				print ("Consumed " + slotsItem.itemName);//Stat Id, Buff Amount, Buff Time;
				this.itemStack.Pop ();
				this.transform.GetChild (0).GetComponent<Text> ().text = itemStack.Count.ToString ();
			}
			break;
			//Something to remove the item compeletly if theres no more in the stack
			/*if (deleteItem) {
				inventory [slot] = new Item ();
			}*/
		}
	}
}
