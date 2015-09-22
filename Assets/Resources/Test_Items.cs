using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;
using System.IO;



public class ItemContainer{
	
	public static List<Item> Load_Items(string filepath){
		TextAsset _xml = Resources.Load<TextAsset>(filepath);
		XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
		StringReader reader  = new StringReader(_xml.text);
		List<Item> itemList = serializer.Deserialize(reader) as List<Item>;

		reader.Close();
		return itemList;
	}
	public static void Save_Items(string filepath,List<Item> items){

		var serializer = new XmlSerializer (typeof(List<Item>));
		var stream = new FileStream (filepath, FileMode.Create);
		serializer.Serialize (stream, items);
		stream.Close ();
	
	}

}

public class Level{
	public string lvl {get;set;}
	public string blood {get;set;}
	public string love {get;set;}
	public string exp {get;set;}
	public string pumpScale {get;set;}
	public string loveScale {get;set;}
	public string cardioScale{get;set;}
	public string shellScale{get;set;}

}
[System.Serializable]
public class Test_Items : MonoBehaviour {
	
	[SerializeField]
	public List<Item> itemList;
	public string[] name_arr;
	// Use this for initialization
	void Start () {
		//ReadIN_Items();
		//ReadIN_PlayerCURVE();
		print ("Start");
		itemList = ItemContainer.Load_Items("Item_Data");

		foreach(Item i in itemList){
			print (i.name);
		}
		print ("end");
    }
	
	// Update is called once per frame
	void Update () {
	    
       
	}

	void ReadIN_Items(){
		XElement doc= XElement.Load("Data_Items.xml");
		var i = (from item in doc.Descendants("item")
		         select new Item
		         {
			name = item.Element("name").Value,
			//type = item.Element("Type").Value,
			kind = item.Element("Kind").Value,
			effect_1 = item.Element("Effect1").Value,
			amount_1 = item.Element("Amount1").Value,
			effect_2 = item.Element("Effect2").Value,
			amount_2 = item.Element("Amount2").Value,
			effect_3 = item.Element("Effect3").Value,
			amount_3 = item.Element("Amount3").Value,
			effect_4 = item.Element("Effect4").Value,
			amount_4 = item.Element("Amount4").Value,
			price    = item.Element("Price").Value,
			rank 	 = item.Element("Rank").Value,
			description = item.Element("Descripition").Value,
			stock = item.Element("Stock").Value,
			duration = item.Element("Duration").Value,
			
			
			
			//itemtype = item.Element("ItemType").Value,
			//  actionType = item.Element("ActionType").Value,
			
		}).ToList();
		

	}
	void ReadIN_PlayerCURVE(){
		XElement doc= XElement.Load("Data_PlayerCurve.xml");
		var l = (from level in doc.Descendants("Level")
		         select new Level { 
			lvl = level.Element("lvl").Value,
			blood = level.Element("Blood").Value,
			love = level.Element("Love").Value,
			exp = level.Element("Exp").Value,
			pumpScale = level.Element("PumpScale").Value,
			loveScale = level.Element("LoveScale").Value,
			cardioScale = level.Element("CardioScale").Value,
			shellScale = level.Element("ShellScale").Value,

				

				}).ToList();
		foreach(var lvl in l){
			print (lvl.lvl);
		}

		}
	[ContextMenu("Load_Item")]
	public void Load_Items(){

		itemList = ItemContainer.Load_Items("Item_Data");
		

	
	}
	public Item Find_Item(string name){
		Item item = new Item ();
	
		item=  itemList.Find (x => x.name.Equals (name));
		return item;

	}
	[ContextMenu("Load NAME")]
	public void Name_arr(){
		name_arr = new string[itemList.Count];
		for (int i = 0; i < itemList.Count; i++) {
			name_arr[i] = itemList [i].name;
		}


	}
	public List<Item> Item_List{ get{ return itemList; }}

	[ContextMenu("Print ItemData")]
	void Print_ItemData(){
		List<Item> items = ItemData.Load_Items ("Item_Data");
		foreach (Item i in items) {
			print (i.name);
		}
	}
}
