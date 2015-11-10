using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
[Serializable]
[ExecuteInEditMode]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(BoxCollider2D))]
public class Item_View : MonoBehaviour {

	private Sprite _sprite;
	private SpriteRenderer _renderer;
	private BoxCollider2D _collider;

	public ItemDataBase db;
	public Item item;
	[HideInInspector]
	public  int itemID;
	/*
	public Item_View(Item item){

	}
	*/

	
	void OnEnable(){

		Get_Data ();

	}
	void Start () {
		
		Get_Data();
	
	}
	
	// Update is called once per frame
	void Update () {
		_renderer = gameObject.GetComponent<SpriteRenderer> ();
		_renderer.sprite = item.sprite;

	}

	void Get_Data(){
		gameObject.tag = "Item";
		db = (ItemDataBase)Resources.Load<ItemDataBase> ("ItemDatBase");
		item = db.Item (itemID);
		_renderer = gameObject.GetComponent<SpriteRenderer> ();
		_renderer.sprite = item.sprite;
		_collider = gameObject.GetComponent<BoxCollider2D> ();
		_collider.isTrigger = true;

	}

	public void ChangeData(int ID){
		itemID = ID;
		item = db.Item (itemID);
	}
}
