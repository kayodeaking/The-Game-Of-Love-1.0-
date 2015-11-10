using UnityEngine;
using System.Collections;

public class Player_Input : MonoBehaviour {

	public static int moveSet = 1;
	Player_Move player_Move;
	
	// Use this for initialization
	void Start () {
		player_Move = gameObject.GetComponent<Player_Move>();

		

	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (moveSet == 1) {
			Player_Option_Set_1 ();
		}
		
		if (moveSet == 2) {
			Player_Option_Set_2 ();
		}

		/*
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
			UsePotion(1);
		}
		
		//Players Assigned Potion 2
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			UsePotion(2);
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
		*/
		//SetDirection();
	}
	
	//Arrow Key Movement
	void Player_Option_Set_1() {
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			player_Move.MoveUP();
		}
		
		if (Input.GetKey (KeyCode.DownArrow)) {
			player_Move.MoveDOWN();
		}
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			player_Move.MoveLEFT();
		}
		
		if (Input.GetKey (KeyCode.RightArrow)) {
			player_Move.MoveRIGHT();
		}
		
		
		//Players Dodge ability
		if (Input.GetKeyDown (KeyCode.F)) {
		}
		
		if (Input.GetKeyDown (KeyCode.Space)) {
		///	GetComponent<SoundEffects>().PlaySound (0);
		//	canAttack = true;
		//	anim.SetBool ("Attack", canAttack);
		}
		
		if (Input.GetKeyUp (KeyCode.Space)) {
			//GetComponent<SoundEffects>().PlaySound (0);
			//canAttack = false;
			//anim.SetBool ("Attack", canAttack);
		}
	}
	//WASD Key Movement
	void Player_Option_Set_2() {
		
		if (Input.GetKey (KeyCode.W)) {
			player_Move.MoveUP();
		}
		if (Input.GetKey(KeyCode.S)) {
			player_Move.MoveDOWN();
		}
		
		if (Input.GetKey(KeyCode.A)) {
			player_Move.MoveLEFT();
		}
		
		
		if (Input.GetKey(KeyCode.D)) {
			player_Move.MoveRIGHT();

		}
		
		//Players Dodge ability
		if (Input.GetKeyDown (KeyCode.Space)) {
		}
		
		if (Input.GetMouseButtonDown (0)) {
		
		}
		
		if (Input.GetMouseButtonUp (0)) {

		}
	}
	

}
