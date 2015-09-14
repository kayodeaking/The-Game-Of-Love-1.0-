using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
[System.Serializable]
[XmlRoot("Item")]
public class Item  {
	
	[XmlElement("name")]
	public string name;
	//[XmlElement("name")]
	//public string name { get; set; }
	[XmlElement("Type")]
	public string type {get; set;}
	[XmlElement("Kind")]
	public string kind {get;set;}
	[XmlElement("Effect1")]
	public string effect_1{get;set;}
	[XmlElement("Amount1")]
	public string amount_1{get;set;}
	[XmlElement("Effect2")]
	public string effect_2{get;set;}
	[XmlElement("Amount2")]
	public string amount_2{get;set;}
	[XmlElement("Effect3")]
	public string effect_3{get;set;}
	[XmlElement("Amount3")]
	public string amount_3{get;set;}
	[XmlElement("Effect4")]
	public string effect_4{get;set;}
	[XmlElement("Amount4")]
	public string amount_4{get;set;}
	[XmlElement("Price")]
	public string price {get;set;}
	[XmlElement("Rank")]
	public string rank {get;set;}
	[XmlElement("Descripition")]
	public string description{get;set;}
	[XmlElement("stock")]
	public string stock{get;set;}
	[XmlElement("Duration")]
	public string duration{get;set;}

	

	public string Print_Values(){
		
		string print = "Name = " + name + " Type = " +type + "Kind = " + kind;
		return print;
	}
}
