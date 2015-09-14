using UnityEngine;
using System.Collections;

public enum ItemType
{
    Weapon,Armor
}
public enum ActionType
{
   Damage,Healing,Curreny,Experiance

}
public class Base_Item { 
	public string Name{get;set;}
    public static ItemType _itemType;
  	public  static ActionType _actionType;
	public float _actionAmount{get;set;}
	public Sprite _image {get;set;}
	public Vector2 _position{get;set;}
   
	public Base_Item(string name)
    {
		this.Name = name;
    }

    public Base_Item(string name,ItemType item_Type,ActionType action_Type,float actionAmount)
    {
		this.Name = name;
		_itemType = item_Type;
		_actionType = action_Type;
		this._actionAmount = actionAmount;
    }
	public Base_Item(string name,ActionType action_Type,float actionAmount){
		this.Name = name;
		_actionType = action_Type;
		this._actionAmount = actionAmount;
	}


    public string ActionType_To_String
    {
        get
        {
            return _actionType.ToString();
        }
    }

    public string ItemType_To_String
    {
        get
        {
            return _itemType.ToString();
        }
    }

    public void Print_Stats()
    {
        
        Debug.Log(Name + "," + ItemType_To_String+" ," +ActionType_To_String + " ,");
    }
   
 
   

}
