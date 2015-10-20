﻿using UnityEngine;
using System.Collections;

public class Player_Stats : MonoBehaviour {

	public static float max_Blood = 500;
	public static float currBlood = 0f;

	public static float max_Love = 250;
	public static float currLove = 0f;

	public static float max_Exp = 50;
	public static float currExp = 0;

	public GameObject bloodBar;
	public GameObject loveBar;
	public GameObject expBar;

	// Use this for initialization
	void Start () {

		currBlood = max_Blood;
		InvokeRepeating ("DecreaseHealth", 1f, 1f);

		currLove = max_Love;
		InvokeRepeating ("DecreaseMagic", 1f, 1f);

		InvokeRepeating ("IncreaseExp", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DecreaseHealth() {
		if (currBlood <= 0) {
			currBlood = 0;
			GetComponent<SoundEffects>().PlaySound (2);
		} else {
			currBlood -= 25f;
			if(currBlood <= (max_Blood/2)) {
				GetComponent<SoundEffects>().PlaySound (1);
			}
		}
		float tempBlood = currBlood / max_Blood;
		SetBloodBar (tempBlood);
	}

	void DecreaseMagic() {
		if (currLove <= 0) {
			currLove = 0;
		} else {
			currLove -= 25f;
		}
		float tempLove = currLove / max_Love;
		SetLoveBar (tempLove);
	}

	void IncreaseExp() {
		if (currExp >= max_Exp) {
			currExp = max_Exp;
		} else {
			currExp += 10;
		}
		float tempExp = currExp / max_Exp;
		SetExpBar (tempExp);
	}

	public void SetBloodBar (float health) {

		bloodBar.transform.localScale = new Vector3 (health, bloodBar.transform.localScale.y, bloodBar.transform.localScale.z);
	}

	public void SetLoveBar (float magic) {
		
		loveBar.transform.localScale = new Vector3 (magic, loveBar.transform.localScale.y, loveBar.transform.localScale.z);
	}

	public void SetExpBar (float exp) {
		
		expBar.transform.localScale = new Vector3 (exp, expBar.transform.localScale.y, expBar.transform.localScale.z);
	}

	public void Hit(int dmg){
		print ("player hit");
		if (currBlood <= 0) {
			currBlood = 0;
		} else {
			currBlood -= (float)dmg;
		}
		float tempBlood = currBlood / max_Blood;
		SetBloodBar (tempBlood);

	}

}
