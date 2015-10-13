using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class TestItem {
	
	//This Script was just so I had an Item clas
	
	public string itemName;
	public int itemId;
	public string itemDesc;
	public Sprite itemIcon;
	public int itemPower;
	public int itemSpeed;
	public Type itemType;
	public int itemMaxStack;
	
	public enum Type {
		Weapon,
		Armor,
		Consumable,
		Quest
	}
	
	public TestItem(string name, int id, string desc, int power, int speed, int maxStack, Type type) {
		
		itemName = name;
		itemId = id;
		itemDesc = desc;
		/*Make a folder under Resources called "Item Icon" (I put a two because i made one with textures)
		and make them all Sprites name them after their item names*/
		itemIcon = Resources.Load<Sprite> ("Item Icons 2/" + name);
		itemPower = power;
		itemSpeed = speed;
		itemType = type;
		itemMaxStack = maxStack;
		
	}
	
	public TestItem() {
	}
}
