using UnityEngine;
using System.Collections;

public enum Effect_Type{
	Blood,
	Love,
	Strength,
	Intelligence,
	Dexterity,
	Luck,
	Pump,
	Cardio,
	Shell,
	Age,
	none,

}
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
