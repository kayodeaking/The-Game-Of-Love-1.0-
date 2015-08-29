using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI ()
	{
		windowRec = GUI.Window (0, windowRec, BackWin, "The Game of Love (Main Menu)");
	}

	void BackWin (int windowID)
	{

		//The base for the to and bottom of the screen
		float screenMid = windowRec.width / 2;
		float screenBot = windowRec.height;

		//The basic size of each button
		int width = 100;
		int height = 50;

		//Start Button
		if (GUI.Button (new Rect (screenMid - 50, (screenBot / 4), width, height), "Start")) {
			Application.LoadLevel (1);
		}
		if (GUI.Button (new Rect (screenMid - 50, (screenBot / 2), width, height), "My Hearts")) {
			MyHearts.loading = true;
			Application.LoadLevel (4);
		}
	}


}
