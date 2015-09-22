using UnityEngine;
using System.Collections;
using System;
[Serializable]
[RequireComponent(typeof(SpriteRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class Item_View : MonoBehaviour {
	private Sprite _sprite;
	private SpriteRenderer _renderer;
	private BoxCollider2D _collider;
	private Rigidbody2D _rb;
	public Item item;
	/*
	public Item_View(Item item){

	}
	*/
	void OnEnable(){
		_sprite = item.sprite;
		_renderer = gameObject.GetComponent<SpriteRenderer> ();
		_renderer.sprite = _sprite;
		_collider = gameObject.GetComponent<BoxCollider2D> ();
		_rb = gameObject.GetComponent<Rigidbody2D> ();
		_collider.isTrigger = true;


	}
	void Start () {
		

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
