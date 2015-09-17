using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickTabs : MonoBehaviour {

	public GameObject statPanel;
	public GameObject equipPanel;
	public GameObject invPanel;

	public GameObject slashPanel;
	public GameObject blastPanel;
	public GameObject buffPanel;

	public GameObject allSEITabs;
	public GameObject allSBBTabs;

	int tabCount = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if (allSEITabs.activeSelf == true) {
			if (Input.GetKeyDown (KeyCode.Tab)) {
				if (tabCount == 3) {
					tabCount = 0;
				}
				tabCount += 1;
				if (tabCount == 1) {
					statPanel.SetActive (true);
					equipPanel.SetActive (false);
					invPanel.SetActive (false);
				}
				if (tabCount == 2) {
					statPanel.SetActive (false);
					equipPanel.SetActive (true);
					invPanel.SetActive (false);
				}
				if (tabCount == 3) {
					statPanel.SetActive (false);
					equipPanel.SetActive (false);
					invPanel.SetActive (true);
				}
			}
		} if (allSBBTabs.activeSelf == true) {
			if (Input.GetKeyDown (KeyCode.Tab)) {
				if (tabCount == 3) {
					tabCount = 0;
				}
				tabCount += 1;
				if (tabCount == 1) {
					slashPanel.SetActive (true);
					blastPanel.SetActive (false);
					buffPanel.SetActive (false);
				}
				if (tabCount == 2) {
					slashPanel.SetActive (false);
					blastPanel.SetActive (true);
					buffPanel.SetActive (false);
				}
				if (tabCount == 3) {
					slashPanel.SetActive (false);
					blastPanel.SetActive (false);
					buffPanel.SetActive (true);
				}
			}
		} else {
			tabCount = 1;
		}
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

	public void Close_SEI() {
		statPanel.SetActive (true);
		equipPanel.SetActive (false);
		invPanel.SetActive (false);
		allSEITabs.SetActive (false);
	}
	
	public void Slash_Tab() {
		slashPanel.SetActive (true);
		blastPanel.SetActive (false);
		buffPanel.SetActive (false);
	}
	
	public void Blast_Tab() {
		slashPanel.SetActive (false);
		blastPanel.SetActive (true);
		buffPanel.SetActive (false);
	}
	
	public void Buff_Tab() {
		slashPanel.SetActive (false);
		blastPanel.SetActive (false);
		buffPanel.SetActive (true);
	}
	
	public void Close_SBB() {
		slashPanel.SetActive (true);
		blastPanel.SetActive (false);
		buffPanel.SetActive (false);
		allSBBTabs.SetActive (false);
	}
}
