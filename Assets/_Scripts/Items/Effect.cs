using UnityEngine;
using System.Collections;


public class Effect {
	Effect_Type e_type;
	float amount;
	public Effect(){

	}
	public Effect(Effect_Type e_type,float amount){
		this.amount = amount;
		this.e_type = e_type;
	}




}
