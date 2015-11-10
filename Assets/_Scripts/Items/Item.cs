using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public  class Item {
	public string name;
	public string description;
	public Sprite sprite;

	[SerializeField]
	public List<Effect> Effects;
	public int price;
	public int rank;
	public int stock;
	public int duration;
	public Item_Type type;
	public int ID;
	public Item (){

	}
	public Item(string name){
		this.name = name;

	}

}
