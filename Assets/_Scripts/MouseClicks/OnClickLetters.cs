using UnityEngine;
using System.Collections;

public class OnClickLetters : MonoBehaviour {

	public GameObject letters;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Close(){
		letters.SetActive (false);
	}
}
