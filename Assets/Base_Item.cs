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
    string n;
    ItemType i_Type;
    ActionType a_Type;
    Sprite image;        
   public Base_Item(string name)
    {
        n = name;
       
    }

    public Base_Item(string name,ItemType item_Type,ActionType action_Type,float actionAmount)
    {
        
        n = name;
        i_Type = item_Type;
        a_Type = action_Type;
        
    }

    public string Name
    {

        get
        {
            return n;
        }
    }

    public string ActionType_To_String
    {

        get
        {
            return a_Type.ToString();
        }
    }

    public string ItemType_To_String
    {
        get
        {
            return i_Type.ToString();
        }
    }

    public void Print_Stats()
    {
        
        Debug.Log(Name + "," + ItemType_To_String+" ," +ActionType_To_String + " ,");
    }
   
 
   

}
