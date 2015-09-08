using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

public class Item
{
    public string name { get; set; }
	public string type {get; set;}
	public string kind {get;set;}
	public string effect_1{get;set;}
	public string amount_1{get;set;}
	public string effect_2{get;set;}
	public string amount_2{get;set;}
	public string effect_3{get;set;}
	public string amount_3{get;set;}
	public string effect_4{get;set;}
	public string amount_4{get;set;}
	public string price {get;set;}
	public string rank {get;set;}
	public string description{get;set;}
	public string stock{get;set;}
	public string duration{get;set;}

	public string Print_Values(){

		string print = "Name = " + name + " Type = " +type + "Kind = " + kind;
		return print;
	}


  //  public string itemtype { get; set; }
  //  public string actionType { get; set; }
  //  public float actionValue { get; set; }
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
public class Test_Items : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
		//ReadIN_Items();
		ReadIN_PlayerCURVE();

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
			type = item.Element("Type").Value,
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
		
		foreach( var item in i)
		{
			
			print (item.Print_Values());
			// print(item.itemtype);
			// print(item.actionType);

	}
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
}
