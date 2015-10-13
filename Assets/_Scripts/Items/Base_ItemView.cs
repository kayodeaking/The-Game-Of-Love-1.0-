﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class Base_ItemView : MonoBehaviour {
		private Sprite _sprite;
		private SpriteRenderer _renderer;
		private BoxCollider2D _collider;
		private Rigidbody2D _rb;
		public PotionDataBase db;
		public Potion item;
		[HideInInspector]
		public  int itemID;

		/*
	public Item_View(Item item){

	}
	*/
		
		public static GameObject newItem;
		
		void OnEnable(){
			
			Get_Data ();
			
		}
		void Start () {

			
			
		}
		
		// Update is called once per frame
		void Update () {
			_renderer = gameObject.GetComponent<SpriteRenderer> ();
			_renderer.sprite = item.sprite;
			
		}
		
		void Get_Data(){
			db = (PotionDataBase)Resources.Load<PotionDataBase> ("PotionDataBase");
			item = db.potion(itemID);
			_renderer = gameObject.GetComponent<SpriteRenderer> ();
			_renderer.sprite = item.sprite;
			_collider = gameObject.GetComponent<BoxCollider2D> ();
			_rb = gameObject.GetComponent<Rigidbody2D> ();
			_collider.isTrigger = true;
			
		}
		
		void OnTriggerEnter2D(Collider2D col){
			if (col.gameObject.tag == "Player") {
				CreateNewObject ();
				DestroyObject (this.gameObject);
			}
			
		}
		
		void CreateNewObject() {
			print ("created new object");
			
			//newItem = Instantiate (this.gameObject);
			//Inventory.AddToInv (newItem);
			
		}
	}

