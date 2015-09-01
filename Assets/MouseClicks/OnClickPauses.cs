using UnityEngine;
using System.Collections;

public class OnClickPauses : MonoBehaviour {

	public GameObject pausePanel;
	public GameObject optionPanel;
	public GameObject allPausePanel;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Pause_Resume() {
		allPausePanel.SetActive (false);
	}
	
	public void Pause_Restart() {
		allPausePanel.SetActive (false);
	}
	
	public void Pause_Opitions() {
		optionPanel.SetActive (true);
		pausePanel.SetActive (false);
	}
	
	public void Pause_Exit() {
		Application.LoadLevel (1);
		allPausePanel.SetActive (false);
	}
	
	public void Return_Options() {
		optionPanel.SetActive (false);
		pausePanel.SetActive (true);
	}
	
	public void Pause_Close() {
		allPausePanel.SetActive (false);
	}

	public void Opitions_Volume () {
	}

	public void Opitions_SE () {
	}
}
