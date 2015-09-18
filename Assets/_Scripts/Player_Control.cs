using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	// Use this for initialization
	public float playerSpeed = 10.0f;
	public Animator anim;
	public bool canAttack = false;
	void Start () {

		anim = GetComponent<Animator> ();

	}

	public static int moveSet = 1;
	
	// Update is called once per frame
	void Update () {
		

		if (moveSet == 1) {
			Player_Option_Set_1 ();
		}
		
		if (moveSet == 2) {
			Player_Option_Set_2 ();
		}

	}

	//Arrow Key Movement
	void Player_Option_Set_1() {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			anim.SetFloat ("Down", -1.0f);
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			anim.SetFloat ("Down", 1.0f);
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetFloat ("Speed", 1.0f);
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetFloat ("Speed", -1.0f);
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
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




}
