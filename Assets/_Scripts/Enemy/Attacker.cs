﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using BehaviorDesigner.Runtime;
///[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]

public class Attacker : MonoBehaviour {
	//public string Name;
	//public int ID;
	//public EnemyType type;
	public float Magnitude = 3.0f;
	public int health =100;
	public int maxHealth = 100;
	public int damage= 10;
	public GameObject effect;
	Image image;
	GameObject player;
	float sqrMagnitude;
	bool attack = false;
	private Animator anim;

	Vector3 direction;
	float distance;
	void Init(){
		anim = gameObject.GetComponent<Animator>();
		image = gameObject.transform.GetComponentInChildren<Image>();
		player = GameObject.FindGameObjectWithTag("Player");
		sqrMagnitude = Magnitude*Magnitude;
		
	}
	// Use this for initialization
	void Start () {
		Init();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		direction = player.transform.position - transform.position;
		if(Vector3.SqrMagnitude(direction) < sqrMagnitude){
			attack = true;
			
			//Attack(damage);
			//anim.SetBool("Attack",attack);
			
		}
		
		else{
			attack= false;
		}
		
		
		anim.SetBool("Attack",attack);
		
		
		
		if(health<=0){
			Destroy(this.gameObject);
		}
	}
	
	public void Shoot(){
		
		
	}
	void OnDestory(){
		print ("DIE");
	}
	
	public void Hit(int dmg){
		//print ("Hit");
		
		health-= dmg;
		GameObject go =  Instantiate(effect, transform.position, Quaternion.identity) as GameObject;
		Destroy(go, 1.0f);
		image.fillAmount =(float)health/(float)maxHealth;
		
	}
	
	
	[ContextMenu("Damage")]
	public void TestDMG(){
		//player.gameObject.GetComponent<Player_Stats>().Hit (damage);
		//Hit(damage);
		
		
	}
	void  OnCollisionEnter2D(Collision2D coll){
		
		
	}

	void OnDrawGizmos(){
		#if UNITY_EDITOR
		UnityEditor.Handles.color = Color.yellow;
		//UnityEditor.Handles.DrawWireDisc(this.transform.position,this.transform.forward,Magnitude);
		
		//Debug.DrawLine(this.transform.position,player.transform.position);
		
		#endif		
	}
	
	
	

}
