using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickSESIL : MonoBehaviour {

	public GameObject statPanel;
	public GameObject equipPanel;
	public GameObject skillPanel;
	public GameObject invPanel;
	public GameObject letPanel;

	// Use this for initialization
	void Start () {

		statPanel.SetActive (true);
		equipPanel.SetActive (false);
		skillPanel.SetActive (false);
		invPanel.SetActive (false);
		letPanel.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Status () {

		statPanel.SetActive (true);
		equipPanel.SetActive (false);
		skillPanel.SetActive (false);
		invPanel.SetActive (false);
		letPanel.SetActive (false);

	}

	public void Equipment() {

		statPanel.SetActive (false);
		equipPanel.SetActive (true);
		skillPanel.SetActive (false);
		invPanel.SetActive (false);
		letPanel.SetActive (false);

	}

	public void Skill() {

		statPanel.SetActive (false);
		equipPanel.SetActive (false);
		skillPanel.SetActive (true);
		invPanel.SetActive (false);
		letPanel.SetActive (false);

	}

	public void Inventory() {

		statPanel.SetActive (false);
		equipPanel.SetActive (false);
		skillPanel.SetActive (false);
		invPanel.SetActive (true);
		letPanel.SetActive (false);

	}

	public void Letter() {

		statPanel.SetActive (false);
		equipPanel.SetActive (false);
		skillPanel.SetActive (false);
		invPanel.SetActive (false);
		letPanel.SetActive (true);

	}

}
