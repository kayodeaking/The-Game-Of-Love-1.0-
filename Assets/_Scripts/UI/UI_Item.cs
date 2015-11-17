using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_Item : MonoBehaviour,IBeginDragHandler , IDragHandler,IEndDragHandler,IPointerDownHandler,IPointerEnterHandler,IPointerExitHandler {


	public Item item;
    public int slot;
    private Vector2 offset;
 	   Inventory inv;
	 Tooltip tooltip;
    public Transform orginalParent;
	public int amount;

	void Start(){ 
        orginalParent = this.transform.parent;
		
		//inv = GameObject.Find("Inventory").GetComponent<Inventory>();
		inv = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();

        tooltip = inv.GetComponent<Tooltip>();
	}
	 public void OnBeginDrag(PointerEventData eventData)
    {
        if(item!=null){
        orginalParent = this.transform.parent;
       // var canvas = FindInParents<Canvas>(gameObject);
			var canvas = transform.parent.parent;
		if (canvas == null)
			return;
           this.transform.SetParent(canvas.transform);
           GetComponent<CanvasGroup>().blocksRaycasts = false;
        }
    }
   

    public void OnDrag(PointerEventData eventData)
    {
     if(item!=null){
       
			 this.transform.position = eventData.position-offset;
		
		}
        
       
    }

    public void OnEndDrag(PointerEventData eventData)
    {
      // this.transform.SetParent(inv.slots[slot].transform);
      // this.transform.position = inv.slots[slot].transform.position;
         GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
       
       if(item!=null){
              offset = eventData.position - new Vector2(this.transform.position.x,this.transform.position.y);
       }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {    if(item!=null){
       tooltip.Activate(item);
    }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
     tooltip.Deactivate();
    }
    
    public void ConsumeItem(){
        
      
        if(amount>1){
              print("Used "+ item.name);
            amount--;
           this.transform.GetChild(0).GetComponent<Text>().text = amount.ToString();
            
        }
        else {
            amount=0;
            print("Destroyed "+item.name);
        }
        
        
    }
static public T FindInParents<T>(GameObject go) where T : Component
	{
		if (go == null) return null;
		var comp = go.GetComponent<T>();

		if (comp != null)
			return comp;
		
		var t = go.transform.parent;
		while (t != null && comp == null)
		{
			comp = t.gameObject.GetComponent<T>();
			t = t.parent;
		}
		return comp;
	}
}

