using UnityEngine;
using System.Collections;
using System.IO;

public class MyHearts : MonoBehaviour {

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);

	public static bool saving = false;
	public static bool loading = false;


	int toolBarInt = 0;
	string[] toolBarString = new string[] {
		"Heart 1",
		"Heart 2",
		"Heart 3"
	};
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI ()
	{
		windowRec = GUI.Window (4, windowRec, BackWin, "My Hearts");
	}

	void BackWin(int windowID){

		//Tool bar
		Rect toolBarRect = new Rect ((windowRec.width / 2) - 192, (windowRec.height - 75), 375, 50);
		toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);

		//The base for the screen
		float screenMid = windowRec.width / 2;
		float screenTop = windowRec.height * 0;
		
		//The basic size of each button
		int width = 50;
		int height = 50;

		if (toolBarInt == 0) {
			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), "Heart 1");
			GUI.Box (new Rect ((screenMid / 2) + 10, (screenTop + 75) + 20, width + 150, height + 150), "Pic");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: ");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + "10000");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + "Happiness");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: " + HeartCondition.blood);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: " + HeartCondition.love);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 20, width + 150, height), "Time Played: " + "00:00");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + "Weapon 1");
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")){
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart1.txt")) {
						StoreInfo ();	
					}
				}
			}
			if(loading){
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
					using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart1.txt")) {
						LoadInfo();
					}
				}
			}
			GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete");
		}

		if (toolBarInt == 1) {
			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), "Heart 1");
			GUI.Box (new Rect ((screenMid / 2) + 10, (screenTop + 75) + 20, width + 150, height + 150), "Pic");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: " + "25");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + "10000");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + "Happiness");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: ");
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: ");
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 20, width + 150, height), "Time Played: " + "00:00");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + "Weapon 1");
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart2.txt")) {
					}
				}
			}
			if(loading){
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
					using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart2.txt")) {
					}
				}
			}
			GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete");
		}

		if (toolBarInt == 2) {
			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), "Heart 1");
			GUI.Box (new Rect ((screenMid / 2) + 10, (screenTop + 75) + 20, width + 150, height + 150), "Pic");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: " + "25");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + "10000");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + "Happiness");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: ");
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: ");
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 20, width + 150, height), "Time Played: " + "00:00");
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + "Weapon 1");
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart3.txt")) {
					}
				}
			}
			if(loading){
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
					using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart3.txt")) {
					}
				}
			}
			GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete");
		}

		if(saving){
			if(GUI.Button (new Rect ((windowRec.width) - 110, screenTop + 25, 100, 50), "Level")) {
				saving = false;
				Application.LoadLevel (1);
			}
		}
		if (loading) {
			if (GUI.Button (new Rect ((windowRec.width) - 110, screenTop + 25, 100, 50), "Home")) {
				loading = false;
				Application.LoadLevel (0);
			}
		}
	}

	void StoreInfo () {
	}

	void LoadInfo() {
	}
}
