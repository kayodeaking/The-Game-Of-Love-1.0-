using UnityEngine;
using System.Collections;

public class OnClick : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
public void Load_StartLevel(){
		
		Application.LoadLevel(1);
	}

public void Load_MyHeartsLevel(){
	
		Application.LoadLevel(4);

}
}