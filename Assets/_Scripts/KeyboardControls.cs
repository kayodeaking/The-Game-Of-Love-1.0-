using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {

	public GameObject pausePanel;
	public GameObject optionPanel;
	public GameObject controlPanel;
	public GameObject allPausePanel;
	public GameObject statPanel;
	public GameObject equipPanel;
	public GameObject invPanel;
	public GameObject allSEIPanel;
	public GameObject slashPanel;
	public GameObject blastPanel;
	public GameObject buffPanel;
	public GameObject allSkillPanel;
	public GameObject miniMapPanel;
	public GameObject playerHud;
	public GameObject letters;

	bool openPauseMenu = false;
	bool openSEIMenu = false;
	bool openSkillMenu = false;
	bool openPlayerHud = false;
	bool openMiniMap = false;
	bool openLetter = false;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Application.loadedLevel == 5) {
			Game_Play_Only ();
		}
	}

	void Game_Play_Only() {

		//Pauses the game
		if (Input.GetKeyDown (KeyCode.P)) {
			openPauseMenu = !openPauseMenu;
			optionPanel.SetActive (false);
			controlPanel.SetActive (false);
			pausePanel.SetActive (openPauseMenu);
			allPausePanel.SetActive (openPauseMenu);
		}

		//Opens Stat/Equip/Inv Menu
		if (Input.GetKeyDown (KeyCode.I)) {
			openSEIMenu = !openSEIMenu;
			statPanel.SetActive (openSEIMenu);
			equipPanel.SetActive (false);
			invPanel.SetActive (false);
			allSEIPanel.SetActive (openSEIMenu);
		}

		//Opens letter Menu
		if (Input.GetKeyDown (KeyCode.L)) {
			openLetter = !openLetter;
			letters.SetActive (openLetter);
		}

		//Opens Skills Menu
		if (Input.GetKeyDown (KeyCode.K)) {
			openSkillMenu = !openSkillMenu;
			slashPanel.SetActive (openSkillMenu);
			blastPanel.SetActive (false);
			buffPanel.SetActive (false);
			allSkillPanel.SetActive (openSkillMenu);
		}

		//Turns the Player Hud on/off
		if (Input.GetKeyDown (KeyCode.U)) {
			openPlayerHud = !openPlayerHud;
			playerHud.SetActive (openPlayerHud);
		}

		//Turns Mini Map on/off
		if (Input.GetKeyDown (KeyCode.M)) {
			openMiniMap = !openMiniMap;
			miniMapPanel.SetActive (openMiniMap);
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
		//Players Assigned Potion 4
		if (Input.GetKeyDown (KeyCode.Keypad4)) {
			
		}
		
		//Players Assigned Potion 5
		if (Input.GetKeyDown (KeyCode.Keypad5)) {
			
		}

	}



}
