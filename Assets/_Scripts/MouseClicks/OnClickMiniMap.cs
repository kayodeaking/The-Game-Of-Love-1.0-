using UnityEngine;
using System.Collections;

public class OnClickMiniMap : MonoBehaviour {

	public GameObject miniMapPanel;
	public GameObject settPanel;
	public GameObject pausePanel;
	public GameObject allPausePanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Settings(){
		settPanel.SetActive (true);
		pausePanel.SetActive (false);
		allPausePanel.SetActive (true);
	}

	public void Restart() {
	}

	public void Close(){
		miniMapPanel.SetActive (false);
	}
}
