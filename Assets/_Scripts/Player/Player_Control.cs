using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {
	private PlayerDirection direction;
	public float playerSpeed = 10.0f;
	private Animator anim;
	private bool canAttack = false;
	public static int moveSet = 1;
	public float fireRate = 5;
	public float damage = 10;
	public LayerMask whatToHit;
	public GameObject FireSpell;
	public GameObject zSkill;
	public GameObject xSkillPrefab;
	public GameObject cSkillPrefab;
	GameObject skillPrefab;
	float timeSpawnSkill = 0;
	public float skillSpawnRate = 10;
	float timeToFire = 0;
	GameObject enemy;
	[HideInInspector]
	public Vector2 VecDirection;
	[HideInInspector]
	public float SkillRotation;
	int directionType;
	public float rayDistince;

	// Use this for initialization
	void Start () {

	anim = GetComponent<Animator> ();
	}
	void OnTriggerStay2D(Collider2D col){
		
		if(col.gameObject.tag == "Enemy"){
			
			if(canAttack){
				//col.gameObject.GetComponent<Enemy>().Hit(1);
				enemy = col.gameObject;
			}
			
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
	// Update is called once per frame
	void Update () {
		

		if (moveSet == 1) {
			Player_Option_Set_1 ();
		}
		
		if (moveSet == 2) {
			Player_Option_Set_2 ();
		}

		if (fireRate == 0) {
			if (Input.GetKeyDown (KeyCode.Z)) {
				skillPrefab = zSkill;
				Shoot ();
			
			}
			if (Input.GetKeyDown (KeyCode.X)) {
				skillPrefab = xSkillPrefab;
				Shoot ();
			}
			if (Input.GetKeyDown (KeyCode.C)) {
				skillPrefab = cSkillPrefab;
				Shoot ();
			}
		} 
		else {
			if (Input.GetKey (KeyCode.Z) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				skillPrefab = zSkill;
				Shoot ();
			
			}
			if (Input.GetKey (KeyCode.X) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				skillPrefab = xSkillPrefab;
				Shoot ();
			}
			if (Input.GetKey (KeyCode.C) && Time.time > timeToFire) {
				timeToFire = Time.time + 1/fireRate;
				skillPrefab = cSkillPrefab;
				Shoot ();
			}
		}

		//Players Assigned Potion 1
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			//UsePotion(1);
		}
		
		//Players Assigned Potion 2
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			//UsePotion(2);
		}
		
		//Players Assigned Potion 3
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			GetComponent<SoundEffects>().PlaySound (2);
		}
		//Players Assigned Potion 4
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			GetComponent<SoundEffects>().PlaySound (1);
		}
		
		//Players Assigned Potion 5
		if (Input.GetKeyDown (KeyCode.Alpha5)) {
		}

		SetDirection();
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


		//Players Dodge ability
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
	//WASD Key Movement
	void Player_Option_Set_2() {
		
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
		}
		
		if (Input.GetKey(KeyCode.A)) {
			anim.SetFloat ("Speed", 1.0f);
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
		}
		
		
		if (Input.GetKey(KeyCode.D)) {
			anim.SetFloat ("Speed", -1.0f);
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
		}

		//Players Dodge ability
		if (Input.GetKeyDown (KeyCode.Space)) {
		}

		if (Input.GetMouseButtonDown (0)) {
			canAttack = true;
			anim.SetBool ("Attack", canAttack);
		}
		
		if (Input.GetMouseButtonUp (0)) {
			canAttack = false;
			anim.SetBool ("Attack", canAttack);
		}
	}
		
	void Shoot () {
		
		if (Time.time > timeSpawnSkill) {
			Skill ();
			timeSpawnSkill = Time.time + 1/skillSpawnRate;
		}
	
	}

	
	void Skill () {
		Instantiate(skillPrefab,this.transform.position,Quaternion.Euler(0, 0, SkillRotation));

	}

	/*
	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.tag == "Item") {
			GetComponent<SoundEffects> ().PlaySound (3);
			Destroy (col.gameObject);
		}

	}
	*/
	/*
	void UsePotion(int itemID) {

		switch(itemID){
		case 1:
			Player_Stats.currBlood += 50;
			print ("Used Health Pot");
			break;
		case 2:
			Player_Stats.currLove += 50;
			print ("Used Mana Pot");
			break;
		}
		GetComponent<SoundEffects> ().PlaySound (5);
	}
	*/
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
	void MoveX(float speed){
		
		transform.Translate (speed * Time.deltaTime, 0, 0);


	}
	void MoveY(float speed){

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

	void OnGizmos(){

	}
}
