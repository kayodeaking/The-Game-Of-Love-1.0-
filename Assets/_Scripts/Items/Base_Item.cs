using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public  abstract class Base_Item:ScriptableObject{

	public string name;
	public string description;
	public Sprite sprite;
	[SerializeField]
	public List<Effect> Effects;
	public int price;
	public int rank;
	public int stock;
	public int duration;
	public Item_Type Item;



	//private Weapon arm;
	//public Item item;

	public Base_Item(){

	}

	


}
