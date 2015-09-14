using UnityEngine;
using System.Collections;

public class OnClickPlayerHud : MonoBehaviour {

	public GameObject letters;
	public GameObject status;
	public GameObject SEI;
	public GameObject skills;
	public GameObject SBB;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Letters(){
		letters.SetActive (true);
	}

	public void Status(){
		status.SetActive (true);
		SEI.SetActive (true);
	}

	public void Skills(){
		skills.SetActive (true);
		SBB.SetActive (true);
	}
}
