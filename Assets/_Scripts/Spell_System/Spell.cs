using UnityEngine;
using System.Collections;
//[ExecuteInEditMode]
public class Spell : MonoBehaviour {

	public int Damage;
	public int Duration;
	private GameObject child;
	public GameObject Effect;
	public GameObject ImpactEffect;
	private Collider2D col;
	public float moveSpeed = .05f;
	 Vector2 direction;
	

	// Use this for initialization
	void OnEnable(){
		//Effect.transform.SetParent(this.transform);
		//Instantiate(Effect);
	}
	void Start () {

	}
	void OnAwake(){
		direction = Player_Control.VecDirection;
	//Instantiate(Effect);
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * moveSpeed);
		Destroy (this.gameObject,Duration);
	}

	void OnCollisionEnter2D(Collision2D col){
	
		if(col.gameObject.tag =="Enemy"){
			Destroy(this.gameObject);

		}
	}
	void OnTriggerEnter2D(){

	}
	void OnDestroy(){
		Instantiate(ImpactEffect,this.transform.position,Quaternion.identity);
	}

}
