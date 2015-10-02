using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	public float playerSpeed = 10.0f;
	public Animator anim;
	public bool canAttack = false;
	public bool isUp = false;
	public static int moveSet = 1;
	
	public float fireRate = 5;
	public float damage = 10;
	public LayerMask whatToHit;

	public Transform zSkill;
	public Transform xSkillPrefab;
	public Transform cSkillPrefab;
	Transform skillPrefab;
	float timeSpawnSkill = 0;
	public float skillSpawnRate = 10;
	
	float timeToFire = 0;
	public GameObject firePoint;
	public GameObject upDirectionPoint;
	public GameObject downDirectionPoint;
	public GameObject rightDirectionPoint;
	public GameObject leftDirectionPoint;
	public GameObject uprightDirectionPoint;
	public GameObject upleftDirectionPoint;
	public GameObject downrightDirectionPoint;
	public GameObject downleftDirectionPoint;
	GameObject mainDirectionPoint;
	
	public static Vector3 VecDirection;
	int directionType;

	// Use this for initialization
	void Start () {

		anim = GetComponent<Animator> ();
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
		} else {
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

		FlipDirections ();
	}

	//Arrow Key Movement
	void Player_Option_Set_1() {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			anim.SetFloat ("DIrection", 1.0f);
			isUp = true;
			anim.SetBool ("isUp", isUp);
			transform.Translate (0, playerSpeed * Time.deltaTime, 0);
			directionType = 1;
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			anim.SetFloat ("DIrection", -1.0f);
			isUp = true;
			anim.SetBool ("isUp", isUp);
			transform.Translate (0, -playerSpeed * Time.deltaTime, 0);
			directionType = 2;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			isUp = false;
			anim.SetBool ("isUp", isUp);
			anim.SetFloat ("Speed", 1.0f);
			transform.Translate (-playerSpeed * Time.deltaTime, 0, 0);
			directionType = 3;
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetFloat ("Speed", -1.0f);
			isUp = false;
			anim.SetBool ("isUp", isUp);
			transform.Translate (playerSpeed * Time.deltaTime, 0, 0);
			directionType = 4;
		}

		//Players Dodge ability
		if (Input.GetKeyDown (KeyCode.F)) {
		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			canAttack = true;
			anim.SetBool ("Attack", canAttack);
		}
		
		if (Input.GetKeyUp (KeyCode.Space)) {
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
		Vector2 directionPos = new Vector2 (mainDirectionPoint.transform.position.x, mainDirectionPoint.transform.position.y);
		Vector2 firePointPos = new Vector2 (firePoint.transform.position.x, firePoint.transform.position.y);
		RaycastHit2D hit = Physics2D.Raycast (firePointPos, directionPos - firePointPos, 500, whatToHit);
		if (Time.time > timeSpawnSkill) {
			Skill ();
			timeSpawnSkill = Time.time + 1/skillSpawnRate;
		}
		Debug.DrawLine (firePointPos,	directionPos);
		if (hit.collider != null) {
			Debug.DrawLine (firePointPos, hit.point, Color.red);
		}
	}
	
	void Skill () {
		Instantiate (skillPrefab, firePoint.transform.position, firePoint.transform.rotation);
	}

	void FlipDirections () {

		if (directionType == 1) {
			VecDirection = Vector3.up;
			mainDirectionPoint = upDirectionPoint;
		}

		if (directionType == 2) {
			VecDirection = Vector3.down;
			mainDirectionPoint = downDirectionPoint;
		}

		if (directionType == 3) {
			VecDirection = Vector3.left;
			mainDirectionPoint = leftDirectionPoint;
		}

		if (directionType == 4) {
			VecDirection = Vector3.right;
			mainDirectionPoint = rightDirectionPoint;
		}

	}
}
