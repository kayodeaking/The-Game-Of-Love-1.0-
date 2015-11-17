using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	public GameObject s_Hotbar;
	public GameObject ItemHotbar;
	private PlayerDirection direction;
	public float playerSpeed = 10.0f;
	private Animator anim;
	private bool canAttack = false;
	public float fireRate = 5;
	public float damage = 10;
	public LayerMask whatToHit;
	float timeSpawnSkill = 0;
	public float skillSpawnRate = 10;
	float timeToFire = 0;
	GameObject enemy;
	Spell_Hotbar spellHotbar;
	HotBar itemhotbar;
	[HideInInspector]
	public Vector2 VecDirection;
	[HideInInspector]
	public float SkillRotation;
	int directionType;
	public float rayDistince;

	// Use this for initialization
	void Start () {
		spellHotbar = s_Hotbar.GetComponent<Spell_Hotbar>();
		itemhotbar = ItemHotbar.GetComponent<HotBar>();
		anim = GetComponent<Animator> ();
	}


	void Update () {

			Player_Option_Set_1 ();

			HotbarInput();

			SetDirection();
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Item") {
			GetComponent<SoundEffects> ().PlaySound (3);
			Destroy (col.gameObject);
		}
		
	}
	
	void SendDamage(){
		RaycastHit2D hit = Physics2D.Raycast(transform.position, VecDirection, rayDistince,whatToHit);
		if(hit){
			
			if(hit.collider){
				if(hit.collider.gameObject.tag=="Enemy"){
					//	Debug.Log("Hit");
					//Debug.DrawLine(transform.position,VecDirection*rayDistince, Color.green,1.0f);
					hit.collider.gameObject.GetComponent<Enemy>().Hit(10);
					//	print ("Send dmg");
					
				}
				
			}
		}
	}

	

	//Arrow Key Movement
	void Player_Option_Set_1() {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			direction = PlayerDirection.UP;
			SetAnimDirection(1.0f,true);
			MoveY(playerSpeed);
		}

		 if (Input.GetKey (KeyCode.DownArrow)) {
			
			direction = PlayerDirection.DOWN;
			SetAnimDirection(-1.0f,true);
			MoveY(-playerSpeed);
		}

		 if (Input.GetKey (KeyCode.LeftArrow)) {
			direction = PlayerDirection.LEFT;
			SetAnimSpeed(1.0f,false);
			MoveX(-playerSpeed);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			direction = PlayerDirection.RIGHT;
			SetAnimSpeed(-1.0f,false);
			MoveX(playerSpeed);
		}


		if (Input.GetKeyDown (KeyCode.F)) {
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			GetComponent<SoundEffects>().PlaySound (0);
			canAttack = true;
			anim.SetBool ("Attack", canAttack);
		}
		
		if (Input.GetKeyUp (KeyCode.Space)) {
			GetComponent<SoundEffects>().PlaySound (0);
			canAttack = false;
			anim.SetBool ("Attack", canAttack);
		}
	}

	void HotbarInput(){

		
		if (fireRate == 0) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				
				Shoot (spellHotbar.slots[0].GetChild(0));
				
			}
			if (Input.GetKeyDown (KeyCode.X)) {
				
				Shoot (spellHotbar.slots[1].GetChild(0));
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				
				Shoot (spellHotbar.slots[2].GetChild(0));
			}
		} 
		else {
			if (Input.GetKey (KeyCode.Z) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				
				
				Shoot (spellHotbar.slots[0].GetChild(0));
				
			}
			if (Input.GetKey (KeyCode.X) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				
				Shoot (spellHotbar.slots[1].GetChild(0));
			}
			if (Input.GetKey (KeyCode.C) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				
				Shoot (spellHotbar.slots[2].GetChild(0));
			}
		}
		

		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			itemhotbar.slots[0].GetChild(0).GetComponent<UI_Item>().ConsumeItem();

		}

		
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			itemhotbar.slots[1].GetChild(0).GetComponent<UI_Item>().ConsumeItem();

		}
		
		
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			itemhotbar.slots[2].GetChild(0).GetComponent<UI_Item>().ConsumeItem();

		
		}

		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			itemhotbar.slots[3].GetChild(0).GetComponent<UI_Item>().ConsumeItem();


		}
		

		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			itemhotbar.slots[4].GetChild(0).GetComponent<UI_Item>().ConsumeItem();


		}


	}
		
	void Shoot (Transform Spell) {
		
		if (Time.time > timeSpawnSkill) {
			
			
			Instantiate(Spell.GetComponent<UI_Spell>().spell,this.transform.position,Quaternion.Euler(0,0,SkillRotation));
			
			timeSpawnSkill = Time.time + 1/skillSpawnRate;
		}
		
	}

	




	void SetDirection(){
		
	switch(direction){
		case PlayerDirection.UP:
			VecDirection = Vector2.up;
			SkillRotation = 0.0f;

			break;
		case PlayerDirection.DOWN:
			VecDirection = Vector2.down;
			SkillRotation = 180.0f;

		
			break;
		case PlayerDirection.RIGHT:
			VecDirection = Vector2.right;
			SkillRotation = -90.0f;


			break;
		case PlayerDirection.LEFT:
			VecDirection = Vector2.left;
			SkillRotation = 90.0f;
			break;
		}

	}
	public void MoveX(float speed){
		
		transform.Translate (speed * Time.deltaTime, 0, 0);


	}
	public	void MoveY(float speed){

		transform.Translate (0,speed * Time.deltaTime, 0);


	}
	void SetAnimDirection(float direction,bool UP){
		anim.SetFloat ("DIrection", direction);
		anim.SetBool ("isUp",UP);

	}
	void SetAnimSpeed(float speed,bool UP){
		anim.SetFloat ("Speed",speed);
		anim.SetBool ("isUp",UP);

	}


}
