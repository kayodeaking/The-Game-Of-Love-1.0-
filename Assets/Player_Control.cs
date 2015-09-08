using UnityEngine;
using System.Collections;

public class Player_Control : MonoBehaviour {

	// Use this for initialization
	public float playerSpeed = 10.0f;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.W)) {
		
			transform.Translate(0,playerSpeed * Time.deltaTime,0);
		}
		if (Input.GetKey(KeyCode.S)) {
			transform.Translate(0,-playerSpeed * Time.deltaTime,0);
		}

		if (Input.GetKey(KeyCode.A)) {

			transform.Translate(-playerSpeed * Time.deltaTime,0 ,0);
		}
		

		if (Input.GetKey(KeyCode.D)) {
			transform.Translate(playerSpeed * Time.deltaTime,0 ,0);
		}
	}


}
