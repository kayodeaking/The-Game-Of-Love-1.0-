using UnityEngine;
using System.Collections;


public class Weapon :MonoBehaviour,Base_Item {


	// Use this for initialization
	public Weapon(string name):base(name){
		this.Name = name;
	}
	public Weapon(string name,ActionType action_Type,float actionAmount):base(name,action_Type,actionAmount){
		this.Name = name;
		_actionType = action_Type;
		this._actionAmount = actionAmount;

	}

	

}
