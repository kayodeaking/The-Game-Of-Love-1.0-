using UnityEngine;
using System.Collections;

public class OnClickMonsterBook : MonoBehaviour {

	public GameObject diseasePanel;
	public GameObject emotionPanel;
	public GameObject thoughtsPanel;
	public GameObject bossPanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Diseases ()	{
		diseasePanel.SetActive (true);
		emotionPanel.SetActive (false);
		thoughtsPanel.SetActive (false);
		bossPanel.SetActive (false);
	}

	public void Emotions () {
		diseasePanel.SetActive (false);
		emotionPanel.SetActive (true);
		thoughtsPanel.SetActive (false);
		bossPanel.SetActive (false);
	}

	public void Thoughts () {
		diseasePanel.SetActive (false);
		emotionPanel.SetActive (false);
		thoughtsPanel.SetActive (true);
		bossPanel.SetActive (false);
	}

	public void Bosses () {
		diseasePanel.SetActive (false);
		emotionPanel.SetActive (false);
		thoughtsPanel.SetActive (false);
		bossPanel.SetActive (true);
	}

	public void Exit() {
		diseasePanel.SetActive (true);
		emotionPanel.SetActive (false);
		thoughtsPanel.SetActive (false);
		bossPanel.SetActive (false);
	}
}
