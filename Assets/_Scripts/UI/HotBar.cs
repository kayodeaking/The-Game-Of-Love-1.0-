﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HotBar : MonoBehaviour {
	


	
	public Transform[] slots;
	
	
	
	// Use this for initialization
	void Start () {
		slots = new Transform[this.transform.childCount];
		for(int i =0;i<slots.Length;i++){
			
			slots[i] = this.transform.GetChild(i);
			

		}
	
	
	}
	
	// Update is called once per frame
	void Update () {
		
	
		
	}
	

			

	
	
}
