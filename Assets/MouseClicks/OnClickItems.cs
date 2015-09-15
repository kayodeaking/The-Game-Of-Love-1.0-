using UnityEngine;
using System.Collections;

public class OnClickItems : MonoBehaviour {

	public GameObject comparePanel;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Info(){
		comparePanel.SetActive (true);
	}
}
