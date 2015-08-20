using UnityEngine;
using System.Collections;

public class LevelChoice : MonoBehaviour
{

	Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);
	string title;
	int toolBarInt = 0;
	string[] toolBarString = new string[] {
		"Chapter 1",
		"Chapter 2",
		"Chapter 3",
		"Chapter 4",
		"Chapter 5"
	};

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
		windowRec = GUI.Window (1, windowRec, BackWin, "Level Select");
		
	}

	void BackWin (int windowID)
	{


		//Tool bar
		Rect toolBarRect = new Rect ((windowRec.width / 2) - 192, (windowRec.height - 75), 375, 50);
		toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);


		//The base for the screen
		float screenMid = windowRec.width / 2;
		float screenTop = windowRec.height * 0;

		//The basic size of each button
		int width = 50;
		int height = 50;

		Rect titleRect = new Rect ((screenMid - 30), (screenTop + 50), width + 50, height);

		//Level Buttons
		if (toolBarInt == 0) {

			title = "Break Up";

			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 100), width + 25, height + 25), "1");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 185), width + 25, height + 25), "5");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 270), width + 25, height + 25), "9");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 355), width + 25, height + 25), "13");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 440), width + 25, height + 25), "17");
			
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 100), width + 25, height + 25), "2");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 185), width + 25, height + 25), "6");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 270), width + 25, height + 25), "10");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 355), width + 25, height + 25), "14");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 440), width + 25, height + 25), "18");
			
			GUI.Button (new Rect ((screenMid), (screenTop + 100), width + 25, height + 25), "3");
			GUI.Button (new Rect ((screenMid), (screenTop + 185), width + 25, height + 25), "7");
			GUI.Button (new Rect ((screenMid), (screenTop + 270), width + 25, height + 25), "11");
			GUI.Button (new Rect ((screenMid), (screenTop + 355), width + 25, height + 25), "15");
			GUI.Button (new Rect ((screenMid), (screenTop + 440), width + 25, height + 25), "19");
			
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 100), width + 25, height + 25), "4");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 185), width + 25, height + 25), "8");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 270), width + 25, height + 25), "12");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 355), width + 25, height + 25), "16");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 440), width + 25, height + 25), "20");

		}

		if (toolBarInt == 1) {

			title = "Healing";

			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 100), width + 25, height + 25), "1");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 185), width + 25, height + 25), "5");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 270), width + 25, height + 25), "9");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 355), width + 25, height + 25), "13");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 440), width + 25, height + 25), "17");
			
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 100), width + 25, height + 25), "2");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 185), width + 25, height + 25), "6");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 270), width + 25, height + 25), "10");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 355), width + 25, height + 25), "14");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 440), width + 25, height + 25), "18");
			
			GUI.Button (new Rect ((screenMid), (screenTop + 100), width + 25, height + 25), "3");
			GUI.Button (new Rect ((screenMid), (screenTop + 185), width + 25, height + 25), "7");
			GUI.Button (new Rect ((screenMid), (screenTop + 270), width + 25, height + 25), "11");
			GUI.Button (new Rect ((screenMid), (screenTop + 355), width + 25, height + 25), "15");
			GUI.Button (new Rect ((screenMid), (screenTop + 440), width + 25, height + 25), "19");
			
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 100), width + 25, height + 25), "4");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 185), width + 25, height + 25), "8");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 270), width + 25, height + 25), "12");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 355), width + 25, height + 25), "16");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 440), width + 25, height + 25), "20");

		}

		if (toolBarInt == 2) {

			title = "New Hope";

			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 100), width + 25, height + 25), "1");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 185), width + 25, height + 25), "5");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 270), width + 25, height + 25), "9");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 355), width + 25, height + 25), "13");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 440), width + 25, height + 25), "17");
			
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 100), width + 25, height + 25), "2");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 185), width + 25, height + 25), "6");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 270), width + 25, height + 25), "10");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 355), width + 25, height + 25), "14");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 440), width + 25, height + 25), "18");
			
			GUI.Button (new Rect ((screenMid), (screenTop + 100), width + 25, height + 25), "3");
			GUI.Button (new Rect ((screenMid), (screenTop + 185), width + 25, height + 25), "7");
			GUI.Button (new Rect ((screenMid), (screenTop + 270), width + 25, height + 25), "11");
			GUI.Button (new Rect ((screenMid), (screenTop + 355), width + 25, height + 25), "15");
			GUI.Button (new Rect ((screenMid), (screenTop + 440), width + 25, height + 25), "19");
			
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 100), width + 25, height + 25), "4");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 185), width + 25, height + 25), "8");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 270), width + 25, height + 25), "12");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 355), width + 25, height + 25), "16");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 440), width + 25, height + 25), "20");

		}

		if (toolBarInt == 3) {

			title = "Jealous";

			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 100), width + 25, height + 25), "1");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 185), width + 25, height + 25), "5");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 270), width + 25, height + 25), "9");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 355), width + 25, height + 25), "13");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 440), width + 25, height + 25), "17");
			
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 100), width + 25, height + 25), "2");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 185), width + 25, height + 25), "6");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 270), width + 25, height + 25), "10");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 355), width + 25, height + 25), "14");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 440), width + 25, height + 25), "18");
			
			GUI.Button (new Rect ((screenMid), (screenTop + 100), width + 25, height + 25), "3");
			GUI.Button (new Rect ((screenMid), (screenTop + 185), width + 25, height + 25), "7");
			GUI.Button (new Rect ((screenMid), (screenTop + 270), width + 25, height + 25), "11");
			GUI.Button (new Rect ((screenMid), (screenTop + 355), width + 25, height + 25), "15");
			GUI.Button (new Rect ((screenMid), (screenTop + 440), width + 25, height + 25), "19");
			
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 100), width + 25, height + 25), "4");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 185), width + 25, height + 25), "8");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 270), width + 25, height + 25), "12");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 355), width + 25, height + 25), "16");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 440), width + 25, height + 25), "20");

		}

		if (toolBarInt == 4) {

			title = "Finally";

			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 100), width + 25, height + 25), "1");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 185), width + 25, height + 25), "5");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 270), width + 25, height + 25), "9");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 355), width + 25, height + 25), "13");
			GUI.Button (new Rect ((screenMid / 1.5f), (screenTop + 440), width + 25, height + 25), "17");
			
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 100), width + 25, height + 25), "2");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 185), width + 25, height + 25), "6");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 270), width + 25, height + 25), "10");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 355), width + 25, height + 25), "14");
			GUI.Button (new Rect ((screenMid / 1.2f), (screenTop + 440), width + 25, height + 25), "18");
			
			GUI.Button (new Rect ((screenMid), (screenTop + 100), width + 25, height + 25), "3");
			GUI.Button (new Rect ((screenMid), (screenTop + 185), width + 25, height + 25), "7");
			GUI.Button (new Rect ((screenMid), (screenTop + 270), width + 25, height + 25), "11");
			GUI.Button (new Rect ((screenMid), (screenTop + 355), width + 25, height + 25), "15");
			GUI.Button (new Rect ((screenMid), (screenTop + 440), width + 25, height + 25), "19");
			
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 100), width + 25, height + 25), "4");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 185), width + 25, height + 25), "8");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 270), width + 25, height + 25), "12");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 355), width + 25, height + 25), "16");
			GUI.Button (new Rect ((screenMid * 1.17f), (screenTop + 440), width + 25, height + 25), "20");

		}

		//The label for the chapter title
		GUI.Label (titleRect, title);

		//Other Buttons
		if (GUI.Button (new Rect ((screenMid / 10), (screenTop + 115), width + 55, height + 25), "Home")) {
			Application.LoadLevel (0);
		}
		if (GUI.Button (new Rect ((screenMid / 10), (screenTop + 290), width + 55, height + 25), "Heart Condition")) {
			Application.LoadLevel (3);	
		}
		if(GUI.Button (new Rect ((screenMid / 10), (screenTop + 385), width + 55, height + 25), "Hospital Shop")) {
			Application.LoadLevel (2);
		}
		if (GUI.Button (new Rect ((screenMid / 10), (screenTop + 480), width + 55, height + 25), "My Hearts")) {
			MyHearts.saving = true;
			Application.LoadLevel (4);
		}
	}
}
