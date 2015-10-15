using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Item_View : MonoBehaviour {

	private Sprite _sprite;
	private SpriteRenderer _renderer;
	private BoxCollider2D _collider;
	private Rigidbody2D _rb;
	public ItemDataBase db;
	public Base_Item item;
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
		db = (ItemDataBase)Resources.Load<ItemDataBase> ("ItemDataBase");
		item = db.Item (itemID);

		_renderer = gameObject.GetComponent<SpriteRenderer> ();
		_renderer.sprite = item.sprite;
		_collider = gameObject.GetComponent<BoxCollider2D> ();
		_rb = gameObject.GetComponent<Rigidbody2D> ();
		_collider.isTrigger = true;

	}
}
