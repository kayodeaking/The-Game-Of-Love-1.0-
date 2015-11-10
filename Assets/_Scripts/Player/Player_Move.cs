using UnityEngine;
using System.Collections;

public class Player_Move : MonoBehaviour {
	public PlayerDirection direction;
	public float playerSpeed = 10.0f;
	public static int moveSet = 1;
	private Animator anim;
	public Vector2 VecDirection;
	public float SkillRotation;

	void Start () {
		
		anim = GetComponent<Animator> ();
	}

	
	// Update is called once per frame
	void Update () {
	
		SetDirection();
	
	}



	
	public void SetDirection(){

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

	public void MoveUP(){

		direction = PlayerDirection.UP;
		SetAnimDirection(1.0f,true);
		MoveY(playerSpeed);
	}

	public void MoveDOWN(){
		direction = PlayerDirection.DOWN;
		SetAnimDirection(-1.0f,true);
		MoveY(-playerSpeed);
	}
	public void MoveLEFT(){
		direction = PlayerDirection.LEFT;
		SetAnimSpeed(1.0f,false);
		MoveX(-playerSpeed);
		
	}
	public void MoveRIGHT(){
		direction = PlayerDirection.RIGHT;
		SetAnimSpeed(-1.0f,false);
		MoveX(playerSpeed);
	}



}
