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
	
	// Update is called once per frame
	void Update () {
		

		if (Input.GetKey (KeyCode.W)) {
			
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
		}

		if (Input.GetKey(KeyCode.A)) {
			anim.SetFloat ("Speed", -1.0f);
			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
		}
		

		if (Input.GetKey(KeyCode.D)) {
			anim.SetFloat ("Speed", 1.0f);
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
		}

		if (Input.GetMouseButtonDown(0)) {
			canAttack = true;
			anim.SetBool ("Attack", canAttack);
		}

		if (Input.GetMouseButtonUp (0)) {
			canAttack = false;
			anim.SetBool ("Attack", canAttack);
		}

	}




}
