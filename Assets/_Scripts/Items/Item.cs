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
	
	[XmlElement("Name")]
	public string name;
	[XmlElement("Type")]
	public Item_Type type;
	//public string type;
	[XmlElement("Kind")]
	public string kind;
	[XmlElement("Effect1")]
	public string effect_1;
	[XmlElement("Amount1")]
	public string amount_1;
	[XmlElement("Effect2")]
	public string effect_2;
	[XmlElement("Amount2")]
	public string amount_2;
	[XmlElement("Effect3")]
	public string effect_3;
	[XmlElement("Amount3")]
	public string amount_3;
	[XmlElement("Effect4")]
	public string effect_4;
	[XmlElement("Amount4")]
	public string amount_4;
	[XmlElement("Price")]
	public string price;
	[XmlElement("Rank")]
	public string rank;
	[XmlElement("Descripition")]
	public string description;
	[XmlElement("stock")]
	public string stock;
	[XmlElement("Duration")]
	public string duration;
	//[XmlElement("Image")]
	public Sprite sprite;
	public List<Effect> Effects;

}
