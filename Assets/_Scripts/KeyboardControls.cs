﻿using UnityEngine;
using System.Collections;

public class KeyboardControls : MonoBehaviour {


	public GameObject pausePanel;
	public GameObject statPanel;
	public GameObject skillPanel;
	public GameObject miniMapPanel;
	public GameObject playerHud;
	public GameObject tooltip;
	public GameObject letters;

	bool openPauseMenu;
	bool openSEIMenu;
	bool openSkillMenu;
	bool openPlayerHud;
	bool openMiniMap;
	bool openLetter;

	public GameObject itemSlot1;
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
			openPauseMenu = pausePanel.activeSelf;
			openPauseMenu = !openPauseMenu;
			pausePanel.SetActive (openPauseMenu);
		}

		//Opens Stat/Equip/Inv Menu
		if (Input.GetKeyDown (KeyCode.I)) {
			openSEIMenu = statPanel.activeSelf;
			openSEIMenu = !openSEIMenu;
			statPanel.SetActive (openSEIMenu);
		}

		//Opens letter Menu
		if (Input.GetKeyDown (KeyCode.L)) {
			openLetter = letters.activeSelf;
			openLetter = !openLetter;
			tooltip.SetActive (false);
			letters.SetActive (openLetter);
		}

		//Opens Skills Menu
		if (Input.GetKeyDown (KeyCode.K)) {
			openSkillMenu = skillPanel.activeSelf;
			openSkillMenu = !openSkillMenu;
			skillPanel.SetActive (openSkillMenu);
		}

		//Turns the Player Hud on/off
		if (Input.GetKeyDown (KeyCode.U)) {
			openPlayerHud = playerHud.activeSelf;
			openPlayerHud = !openPlayerHud;
			playerHud.SetActive (openPlayerHud);
		}

		//Turns Mini Map on/off
		if (Input.GetKeyDown (KeyCode.M)) {
			openMiniMap = miniMapPanel.activeSelf;
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
		if (Input.GetKeyDown (KeyCode.Alpha1)) {

			Debug.Log("no issue with key");
			if(itemSlot1.transform.GetChild (0) != null) {
				itemSlot1.transform.GetChild (0).GetComponent<UpdateStack>().UsePotion();
			} else {
					Debug.Log ("Slot is empty");
			}
		}

		//Players Assigned Potion 2
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Debug.Log("no issue with key");
			
		}

		//Players Assigned Potion 3
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			Debug.Log("no issue with key");
			
		}
		//Players Assigned Potion 4
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			
		}
		
		//Players Assigned Potion 5
		if (Input.GetKeyDown (KeyCode.Alpha5)) {
			
		}

	}



}
