using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

public class Item
{
    public string name { get; set; }
    public string itemtype { get; set; }
    public string actionType { get; set; }
    public float actionValue { get; set; }
}
public class Test_Items : MonoBehaviour {
   public Base_Item i1;
    public Base_Item i2;
	// Use this for initialization
	void Start () {
        i1 = new Base_Item("item");
        i2 = new Base_Item("weapon", ItemType.Weapon, ActionType.Damage, 1.0f);
        //i1.Print_Stats();
        // i2.Print_Stats();
       
       //XDocument doc = XDocument.Load("XMLFile1.xml");
        XElement doc= XElement.Load("XMLFile1.xml");

        var i = (from item in doc.Descendants("item")
                 select new Item
                 {
                     name = item.Element("name").Value,
                     itemtype = item.Element("ItemType").Value,
                     actionType = item.Element("ActionType").Value,
					

                 }).ToList();
        foreach( var item in i)
        {

            print(item.name);
            print(item.itemtype);
            print(item.actionType);
           
        }


/*
        var items = doc.Descendants("item");
       
       
        foreach (var item in items)
        {
                
              
         
        }
    */
    }
	
	// Update is called once per frame
	void Update () {
	    
       
	}
}
