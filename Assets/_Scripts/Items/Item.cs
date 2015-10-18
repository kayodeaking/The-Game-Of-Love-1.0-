using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public  class Item {
	public string name;
	public string description;
	public Sprite sprite;
<<<<<<< Updated upstream
<<<<<<< Updated upstream

=======
	[SerializeField]
>>>>>>> Stashed changes
	public List<Effect> Effects;
	public int price;
	public int rank;
	public int stock;
	public int duration;
	public Item_Type type;
	public Item (){

	}
	public Item(string name){
		this.name = name;

	}


=======
	public List<Effect> Effects;
	//public List<Effect> Effects;

>>>>>>> Stashed changes
}
