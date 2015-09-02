using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {

	public GameObject pausePanel;
	public GameObject allPausePanel;
	public GameObject invPanel;
	public GameObject allSEIPanel;
	public GameObject slashPanel;
	public GameObject allSkillPanel;

	bool openPauseMenu = false;
	bool openSEIMenu = false;
	bool openSkillMenu = false;
	
	public static int moveSet = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Game_Play_Only ();
	}

	void Game_Play_Only() {

		//Pauses the game
		if (Input.GetKeyDown (KeyCode.P)) {
			pausePanel.SetActive (openPauseMenu);
			allPausePanel.SetActive (openPauseMenu);
		}

		//Opens Inventory Menu
		if (Input.GetKeyDown (KeyCode.I)) {
			invPanel.SetActive (openSEIMenu);
			allSEIPanel.SetActive (openSEIMenu);
		}

		//Opens Skills Menu
		if (Input.GetKeyDown (KeyCode.K)) {
			slashPanel.SetActive (openSkillMenu);
			allSkillPanel.SetActive (openSkillMenu);
		}

		//Players Dodge ability
		if (Input.GetKeyDown (KeyCode.F)) {
		}

		//Players Regular Attack
		if (Input.GetKeyDown (KeyCode.Space)) {

		}

		//Players Assigned Skill 1
		if (Input.GetKeyDown (KeyCode.Z)) {

		}

		//Players Assigned Skill 2
		if (Input.GetKeyDown (KeyCode.X)) {

		}

		//Players Assigned Skill 3
		if (Input.GetKeyDown (KeyCode.C)) {

		}

		//Players Assigned Potion 1
		if (Input.GetKeyDown (KeyCode.Keypad1)) {

		}

		//Players Assigned Potion 2
		if (Input.GetKeyDown (KeyCode.Keypad2)) {

		}

		//Players Assigned Potion 3
		if (Input.GetKeyDown (KeyCode.Keypad3)) {

		}

		if (moveSet == 1) {
			Player_Option_Set_1 ();
		}
		
		if (moveSet == 2) {
			Player_Option_Set_2 ();
		}
	}

	//Arrow Key Movement
	void Player_Option_Set_1() {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {

		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) {

		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {

		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) {

		}
		
	}
	
	//WASD Key Movement
	void Player_Option_Set_2() {

		if (Input.GetKeyDown (KeyCode.W)) {
			
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			
		}

		if (Input.GetKeyDown (KeyCode.D)) {
			
		}
	}

}
