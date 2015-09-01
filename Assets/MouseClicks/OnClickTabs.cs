using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickTabs : MonoBehaviour {

	public GameObject statPanel;
	public GameObject equipPanel;
	public GameObject invPanel;
	public GameObject allTabs;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Status_Tab() {
		statPanel.SetActive (true);
		equipPanel.SetActive (false);
		invPanel.SetActive (false);
	}

	public void Equipment_Tab() {
		statPanel.SetActive (false);
		equipPanel.SetActive (true);
		invPanel.SetActive (false);
	}

	public void Inventory_Tab() {
		statPanel.SetActive (false);
		equipPanel.SetActive (false);
		invPanel.SetActive (true);
	}

	public void Close() {
		allTabs.SetActive (false);
	}
}
