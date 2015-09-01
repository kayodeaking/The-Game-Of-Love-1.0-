using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickLevels : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Level1() {
		Application.LoadLevel (5);
	}
}
