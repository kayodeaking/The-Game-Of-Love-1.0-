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
	GameObject player;
	public int amount;

	void Start(){ 
        orginalParent = this.transform.parent;
		player = 	GameObject.FindGameObjectWithTag("Player");
		
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
		print("Used "+ item.name);
		for(int i =0;i<item.Effects.Count;i++){
			if(item.Effects[i]!=null)
				useEffects(item.Effects[i]);
		}
        if(amount>1){
          
            amount--;
           this.transform.GetChild(0).GetComponent<Text>().text = amount.ToString();


            
        }


        else {
            amount=0;
			inv.Remove(item);
            print("Destroyed "+item.name);
			DestroyObject(this.gameObject);


        }
        
        
    }

	void useEffects(Effect effect){

		switch(effect.e_type){

		case Effect_Type.Blood:
			//player.GetComponent<UI_Player>().Current_Blood+=(int) effect.amount;
			player.GetComponent<UI_Player>().AddHealth((int)effect.amount);

			print ("use :"+"Blood "+effect.amount);

			break;
		case  Effect_Type.Age:
			print ("use : "+"Age "+effect.amount);
			break;
		case Effect_Type.Dexterity:
			print ("use :"+"Dexterity "+effect.amount);
			break;
		case Effect_Type.Intelligence:
			print ("use :"+"Intelligence "+effect.amount);
				break;
		case Effect_Type.Love:
			print ("use :"+"Love "+effect.amount);
			break;

		case Effect_Type.Strength:
			print ("use :"+"Strength "+effect.amount);
			break;
		




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

