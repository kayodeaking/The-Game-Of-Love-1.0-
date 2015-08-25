using UnityEngine;
using System.Collections;
using System.IO;

public class MyHearts : MonoBehaviour {

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);

	public static bool saving = false;
	public static bool loading = false;
	
	int pace;
	int exp;
	int blood;
	int love;
	int loveNotes;
	string emo;
	int time;
	string key;
	int statPoints;
	int skillPoints;
	int strPoints;
	int pumpLow;
	int pumpHigh;
	int intPoints;
	int loveLow;
	int loveHigh;
	int dexPoints;
	int cardioLow;
	int cardioHigh;
	int lukPoints;
	int shellLow;
	int shellHigh;

	int BP;
	int LP;

	int unlockLevel;
	int unlockNextEquip;
	int unlockNextInv;
	int letterFound;
	
	int slashSkill1;
	int slashSkill2;
	int slashSkill3;
	int slashSkill4;
	int slashSkill5;
	int slashSkill6;
	int slashSkill7;
	int slashSkill8;
	
	int blastSkill1;
	int blastSkill2;
	int blastSkill3;
	int blastSkill4;
	int blastSkill5;
	int blastSkill6;
	int blastSkill7;
	int blastSkill8;
	int blastSkill9;
	int blastSkill10;
	
	int buffSkill1;
	int buffSkill2;
	int buffSkill3;
	int buffSkill4;
	int buffSkill5;
	int buffSkill6;

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

		ReadInfo ();

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
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: " + pace);
			GUI.Label (new Rect ((screenMid / 2) + 290, (screenTop + 75) + 20, width + 150, height), "Exp to Next Lv: " + exp);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + loveNotes);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + emo);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: " + blood);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: " + love);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 420, (screenTop + 75) + 20, width + 150, height), "Time Played: " + time);
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + key);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")){
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart1.txt")) {
						GatherInfo();
						StoreInfo (writeFile);	
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
			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), "Heart 2");
			GUI.Box (new Rect ((screenMid / 2) + 10, (screenTop + 75) + 20, width + 150, height + 150), "Pic");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: " + pace);
			GUI.Label (new Rect ((screenMid / 2) + 290, (screenTop + 75) + 20, width + 150, height), "Exp to Next Lv: " + exp);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + loveNotes);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + emo);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: " + blood);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: " + love);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 420, (screenTop + 75) + 20, width + 150, height), "Time Played: " + time);
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + key);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart2.txt")) {
						GatherInfo();
						StoreInfo (writeFile);
					}
				}
			}
			if(loading){
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
					using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart2.txt")) {
						LoadInfo();
					}
				}
			}
			GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete");
		}

		if (toolBarInt == 2) {
			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), "Heart 1");
			GUI.Box (new Rect ((screenMid / 2) + 10, (screenTop + 75) + 20, width + 150, height + 150), "Pic");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 20, width + 150, height), "Pace: " + pace);
			GUI.Label (new Rect ((screenMid / 2) + 290, (screenTop + 75) + 20, width + 150, height), "Exp to Next Lv: " + exp);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 55, width + 150, height), "Love Notes: " + loveNotes);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 85, width + 150, height), "Emotion: " + emo);
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 120, width + 50, height), "Blood Level: " + blood);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 170, width + 50, height), "Love Level: " + love);
			GUI.Box (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 190, width + 100, height / 2), "Place holder");
			GUI.Label (new Rect ((screenMid / 2) + 420, (screenTop + 75) + 20, width + 150, height), "Time Played: " + time);
			GUI.Label (new Rect ((screenMid / 2) + 370, (screenTop + 75) + 55, width + 150, height), "Key: " + key);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + "/Database/Heart3.txt")) {
						GatherInfo();
						StoreInfo (writeFile);
					}
				}
			}
			if(loading){
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
					using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart3.txt")) {
						LoadInfo();
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

	void GatherInfo(){
		pace = HeartsInfo.pace;
		exp = HeartsInfo.exp;
		blood = HeartsInfo.blood;
		love = HeartsInfo.love;
		loveNotes = HospitalShop.currNotes;
		emo = "Loss";
		time = 56;
		key = "Weapon 1";
		statPoints = HeartsInfo.statPoints;
		skillPoints = HeartsInfo.skillPoints;
		strPoints = HeartsInfo.strPoints;
		pumpLow = HeartsInfo.pumpLow;
		pumpHigh = HeartsInfo.pumpHigh;
		intPoints = HeartsInfo.intPoints;
		loveLow = HeartsInfo.loveLow;
		loveHigh = HeartsInfo.loveHigh;
		dexPoints = HeartsInfo.dexPoints;
		cardioLow = HeartsInfo.cardioLow;
		cardioHigh = HeartsInfo.cardioHigh;
		lukPoints = HeartsInfo.lukPoints;
		shellLow = HeartsInfo.shellLow;
		shellHigh = HeartsInfo.shellHigh;
		BP = HeartCondition.BP;
		LP = HeartCondition.LP;
		unlockLevel = LevelChoice.unlockLevel;
		unlockNextEquip = HeartCondition.unlockNextEquip;
		unlockNextInv = HeartCondition.unlockNextInv;
		letterFound = HeartCondition.letterFound;
		slashSkill1 = HeartCondition.slashSkill1;
		slashSkill2 = HeartCondition.slashSkill2;
		slashSkill3 = HeartCondition.slashSkill3;
		slashSkill4 = HeartCondition.slashSkill4;
		slashSkill5 = HeartCondition.slashSkill5;
		slashSkill6 = HeartCondition.slashSkill6;
		slashSkill7 = HeartCondition.slashSkill7;
		slashSkill8 = HeartCondition.slashSkill8;
		blastSkill1 = HeartCondition.blastSkill1;
		blastSkill2 = HeartCondition.blastSkill2;
		blastSkill3 = HeartCondition.blastSkill3;
		blastSkill4 = HeartCondition.blastSkill4;
		blastSkill5 = HeartCondition.blastSkill5;
		blastSkill6 = HeartCondition.blastSkill6;
		blastSkill7 = HeartCondition.blastSkill7;
		blastSkill8 = HeartCondition.blastSkill8;
		blastSkill9 = HeartCondition.blastSkill9;
		blastSkill10 = HeartCondition.blastSkill10;
		buffSkill1 = HeartCondition.buffSkill1;
		buffSkill2 = HeartCondition.buffSkill2;
		buffSkill3 = HeartCondition.buffSkill3;
		buffSkill4 = HeartCondition.buffSkill4;
		buffSkill5 = HeartCondition.buffSkill5;
		buffSkill6 = HeartCondition.buffSkill6;
	}
	
	void ReadInfo(){

		if (toolBarInt == 0) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart1.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart1.txt");
				for (int i = 0; i < fileInfo.Length; i++) {
					pace = int.Parse (fileInfo [i]);
					exp = int.Parse (fileInfo [i + 1]);
					blood = int.Parse (fileInfo [i + 2]);
					love = int.Parse (fileInfo [i + 3]);
					loveNotes = int.Parse (fileInfo [i + 4]);
					emo = fileInfo [i + 5];
					time = int.Parse (fileInfo [i + 6]);
					key = fileInfo [i + 7];
					statPoints = int.Parse (fileInfo [i + 8]);
					skillPoints = int.Parse (fileInfo [i + 9]);
					strPoints = int.Parse (fileInfo [i + 10]);
					pumpLow = int.Parse (fileInfo [i + 11]);
					pumpHigh = int.Parse (fileInfo [i + 12]);
					intPoints = int.Parse (fileInfo [i + 13]);
					loveLow = int.Parse (fileInfo [i + 14]);
					loveHigh = int.Parse (fileInfo [i + 15]);
					dexPoints = int.Parse (fileInfo [i + 16]);
					cardioLow = int.Parse (fileInfo [i + 17]);
					cardioHigh = int.Parse (fileInfo [i + 18]);
					lukPoints = int.Parse (fileInfo [i + 19]);
					shellLow = int.Parse (fileInfo [i + 20]);
					shellHigh = int.Parse (fileInfo [i + 21]);
					BP = int.Parse (fileInfo [i + 22]);
					LP = int.Parse (fileInfo [i + 23]);
					unlockLevel = int.Parse (fileInfo [i + 24]);
					unlockNextEquip = int.Parse (fileInfo [i + 25]);
					unlockNextInv = int.Parse (fileInfo [i + 26]);
					letterFound = int.Parse (fileInfo [i + 27]);
					slashSkill1 = int.Parse (fileInfo [i + 28]);
					slashSkill2 = int.Parse (fileInfo [i + 29]);
					slashSkill3 = int.Parse (fileInfo [i + 30]);
					slashSkill4 = int.Parse (fileInfo [i + 31]);
					slashSkill5 = int.Parse (fileInfo [i + 32]);
					slashSkill6 = int.Parse (fileInfo [i + 33]);
					slashSkill7 = int.Parse (fileInfo [i + 34]);
					slashSkill8 = int.Parse (fileInfo [i + 35]);
					blastSkill1 = int.Parse (fileInfo [i + 36]);
					blastSkill2 = int.Parse (fileInfo [i + 37]);
					blastSkill3 = int.Parse (fileInfo [i + 38]);
					blastSkill4 = int.Parse (fileInfo [i + 39]);
					blastSkill5 = int.Parse (fileInfo [i + 40]);
					blastSkill6 = int.Parse (fileInfo [i + 41]);
					blastSkill7 = int.Parse (fileInfo [i + 42]);
					blastSkill8 = int.Parse (fileInfo [i + 43]);
					blastSkill9 = int.Parse (fileInfo [i + 44]);
					blastSkill10 = int.Parse (fileInfo [i + 45]);
					buffSkill1 = int.Parse (fileInfo [i + 46]);
					buffSkill2 = int.Parse (fileInfo [i + 47]);
					buffSkill3 = int.Parse (fileInfo [i + 48]);
					buffSkill4 = int.Parse (fileInfo [i + 49]);
					buffSkill5 = int.Parse (fileInfo [i + 50]);
					buffSkill6 = int.Parse (fileInfo [i + 51]);
					i = fileInfo.Length;
				}
			}
		}

		if (toolBarInt == 1) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart2.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart2.txt");
				for (int i = 0; i < fileInfo.Length; i++) {
					pace = int.Parse (fileInfo [i]);
					exp = int.Parse (fileInfo [i + 1]);
					blood = int.Parse (fileInfo [i + 2]);
					love = int.Parse (fileInfo [i + 3]);
					loveNotes = int.Parse (fileInfo [i + 4]);
					emo = fileInfo [i + 5];
					time = int.Parse (fileInfo [i + 6]);
					key = fileInfo [i + 7];
					statPoints = int.Parse (fileInfo [i + 8]);
					skillPoints = int.Parse (fileInfo [i + 9]);
					strPoints = int.Parse (fileInfo [i + 10]);
					pumpLow = int.Parse (fileInfo [i + 11]);
					pumpHigh = int.Parse (fileInfo [i + 12]);
					intPoints = int.Parse (fileInfo [i + 13]);
					loveLow = int.Parse (fileInfo [i + 14]);
					loveHigh = int.Parse (fileInfo [i + 15]);
					dexPoints = int.Parse (fileInfo [i + 16]);
					cardioLow = int.Parse (fileInfo [i + 17]);
					cardioHigh = int.Parse (fileInfo [i + 18]);
					lukPoints = int.Parse (fileInfo [i + 19]);
					shellLow = int.Parse (fileInfo [i + 20]);
					shellHigh = int.Parse (fileInfo [i + 21]);
					BP = int.Parse (fileInfo [i + 22]);
					LP = int.Parse (fileInfo [i + 23]);
					unlockLevel = int.Parse (fileInfo [i + 24]);
					unlockNextEquip = int.Parse (fileInfo [i + 25]);
					unlockNextInv = int.Parse (fileInfo [i + 26]);
					letterFound = int.Parse (fileInfo [i + 27]);
					slashSkill1 = int.Parse (fileInfo [i + 28]);
					slashSkill2 = int.Parse (fileInfo [i + 29]);
					slashSkill3 = int.Parse (fileInfo [i + 30]);
					slashSkill4 = int.Parse (fileInfo [i + 31]);
					slashSkill5 = int.Parse (fileInfo [i + 32]);
					slashSkill6 = int.Parse (fileInfo [i + 33]);
					slashSkill7 = int.Parse (fileInfo [i + 34]);
					slashSkill8 = int.Parse (fileInfo [i + 35]);
					blastSkill1 = int.Parse (fileInfo [i + 36]);
					blastSkill2 = int.Parse (fileInfo [i + 37]);
					blastSkill3 = int.Parse (fileInfo [i + 38]);
					blastSkill4 = int.Parse (fileInfo [i + 39]);
					blastSkill5 = int.Parse (fileInfo [i + 40]);
					blastSkill6 = int.Parse (fileInfo [i + 41]);
					blastSkill7 = int.Parse (fileInfo [i + 42]);
					blastSkill8 = int.Parse (fileInfo [i + 43]);
					blastSkill9 = int.Parse (fileInfo [i + 44]);
					blastSkill10 = int.Parse (fileInfo [i + 45]);
					buffSkill1 = int.Parse (fileInfo [i + 46]);
					buffSkill2 = int.Parse (fileInfo [i + 47]);
					buffSkill3 = int.Parse (fileInfo [i + 48]);
					buffSkill4 = int.Parse (fileInfo [i + 49]);
					buffSkill5 = int.Parse (fileInfo [i + 50]);
					buffSkill6 = int.Parse (fileInfo [i + 51]);
					i = fileInfo.Length;
				}
			}
		}

		if (toolBarInt == 2) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart3.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart3.txt");
				for (int i = 0; i < fileInfo.Length; i++) {
					pace = int.Parse (fileInfo [i]);
					exp = int.Parse (fileInfo [i + 1]);
					blood = int.Parse (fileInfo [i + 2]);
					love = int.Parse (fileInfo [i + 3]);
					loveNotes = int.Parse (fileInfo [i + 4]);
					emo = fileInfo [i + 5];
					time = int.Parse (fileInfo [i + 6]);
					key = fileInfo [i + 7];
					statPoints = int.Parse (fileInfo [i + 8]);
					skillPoints = int.Parse (fileInfo [i + 9]);
					strPoints = int.Parse (fileInfo [i + 10]);
					pumpLow = int.Parse (fileInfo [i + 11]);
					pumpHigh = int.Parse (fileInfo [i + 12]);
					intPoints = int.Parse (fileInfo [i + 13]);
					loveLow = int.Parse (fileInfo [i + 14]);
					loveHigh = int.Parse (fileInfo [i + 15]);
					dexPoints = int.Parse (fileInfo [i + 16]);
					cardioLow = int.Parse (fileInfo [i + 17]);
					cardioHigh = int.Parse (fileInfo [i + 18]);
					lukPoints = int.Parse (fileInfo [i + 19]);
					shellLow = int.Parse (fileInfo [i + 20]);
					shellHigh = int.Parse (fileInfo [i + 21]);
					BP = int.Parse (fileInfo [i + 22]);
					LP = int.Parse (fileInfo [i + 23]);
					unlockLevel = int.Parse (fileInfo [i + 24]);
					unlockNextEquip = int.Parse (fileInfo [i + 25]);
					unlockNextInv = int.Parse (fileInfo [i + 26]);
					letterFound = int.Parse (fileInfo [i + 27]);
					slashSkill1 = int.Parse (fileInfo [i + 28]);
					slashSkill2 = int.Parse (fileInfo [i + 29]);
					slashSkill3 = int.Parse (fileInfo [i + 30]);
					slashSkill4 = int.Parse (fileInfo [i + 31]);
					slashSkill5 = int.Parse (fileInfo [i + 32]);
					slashSkill6 = int.Parse (fileInfo [i + 33]);
					slashSkill7 = int.Parse (fileInfo [i + 34]);
					slashSkill8 = int.Parse (fileInfo [i + 35]);
					blastSkill1 = int.Parse (fileInfo [i + 36]);
					blastSkill2 = int.Parse (fileInfo [i + 37]);
					blastSkill3 = int.Parse (fileInfo [i + 38]);
					blastSkill4 = int.Parse (fileInfo [i + 39]);
					blastSkill5 = int.Parse (fileInfo [i + 40]);
					blastSkill6 = int.Parse (fileInfo [i + 41]);
					blastSkill7 = int.Parse (fileInfo [i + 42]);
					blastSkill8 = int.Parse (fileInfo [i + 43]);
					blastSkill9 = int.Parse (fileInfo [i + 44]);
					blastSkill10 = int.Parse (fileInfo [i + 45]);
					buffSkill1 = int.Parse (fileInfo [i + 46]);
					buffSkill2 = int.Parse (fileInfo [i + 47]);
					buffSkill3 = int.Parse (fileInfo [i + 48]);
					buffSkill4 = int.Parse (fileInfo [i + 49]);
					buffSkill5 = int.Parse (fileInfo [i + 50]);
					buffSkill6 = int.Parse (fileInfo [i + 51]);
					i = fileInfo.Length;
				}
			}
		}

	}

	void StoreInfo (StreamWriter file) {
		file.WriteLine (pace);
		file.WriteLine (exp);
		file.WriteLine (blood);
		file.WriteLine (love);
		file.WriteLine (loveNotes);
		file.WriteLine (emo);
		file.WriteLine (time);
		file.WriteLine (key);
		file.WriteLine (statPoints);
		file.WriteLine (skillPoints);
		file.WriteLine (strPoints);
		file.WriteLine (pumpLow);
		file.WriteLine (pumpHigh);
		file.WriteLine (intPoints);
		file.WriteLine (loveLow);
		file.WriteLine (loveHigh);
		file.WriteLine (dexPoints);
		file.WriteLine (cardioLow);
		file.WriteLine (cardioHigh);
		file.WriteLine (lukPoints);
		file.WriteLine (shellLow);
		file.WriteLine (shellHigh);
		file.WriteLine (BP);
		file.WriteLine (LP);
		file.WriteLine (unlockLevel);
		file.WriteLine (unlockNextEquip);
		file.WriteLine (unlockNextInv);
		file.WriteLine (letterFound);
		file.WriteLine (slashSkill1);
		file.WriteLine (slashSkill2);
		file.WriteLine (slashSkill3);
		file.WriteLine (slashSkill4);
		file.WriteLine (slashSkill5);
		file.WriteLine (slashSkill6);
		file.WriteLine (slashSkill7);
		file.WriteLine (slashSkill8);
		file.WriteLine (blastSkill1);
		file.WriteLine (blastSkill2);
		file.WriteLine (blastSkill3);
		file.WriteLine (blastSkill4);
		file.WriteLine (blastSkill5);
		file.WriteLine (blastSkill6);
		file.WriteLine (blastSkill7);
		file.WriteLine (blastSkill8);
		file.WriteLine (blastSkill9);
		file.WriteLine (blastSkill10);
		file.WriteLine (buffSkill1);
		file.WriteLine (buffSkill2);
		file.WriteLine (buffSkill3);
		file.WriteLine (buffSkill4);
		file.WriteLine (buffSkill5);
		file.WriteLine (buffSkill6);
		file.Close ();
	}

	void LoadInfo() {

		HeartsInfo.pace = pace;
		HeartsInfo.exp = exp;
		HeartsInfo.blood = blood;
		HeartsInfo.love = love;
		HospitalShop.currNotes = loveNotes;
		emo = "Loss";
		time = 56;
		key = "Weapon 1";
		HeartsInfo.statPoints = statPoints;
		HeartsInfo.skillPoints = skillPoints;
		HeartsInfo.strPoints = strPoints;
		HeartsInfo.pumpLow = pumpLow;
		HeartsInfo.pumpHigh = pumpHigh;
		HeartsInfo.intPoints = intPoints;
		HeartsInfo.loveLow = loveLow;
		HeartsInfo.loveHigh = loveHigh;
		HeartsInfo.dexPoints = dexPoints;
		HeartsInfo.cardioLow = cardioLow;
		HeartsInfo.cardioHigh = cardioHigh;
		HeartsInfo.lukPoints = lukPoints;
		HeartsInfo.shellLow = shellLow;
		HeartsInfo.shellHigh = shellHigh;
		HeartCondition.BP = BP;
		HeartCondition.LP = LP;
		LevelChoice.unlockLevel = unlockLevel;
		HeartCondition.unlockNextEquip = unlockNextEquip;
		HeartCondition.unlockNextInv = unlockNextInv;
		HeartCondition.letterFound = letterFound;
		HeartCondition.slashSkill1 = slashSkill1;
		HeartCondition.slashSkill2 = slashSkill2;
		HeartCondition.slashSkill3 = slashSkill3;
		HeartCondition.slashSkill4 = slashSkill4;
		HeartCondition.slashSkill5 = slashSkill5;
		HeartCondition.slashSkill6 = slashSkill6;
		HeartCondition.slashSkill7 = slashSkill7;
		HeartCondition.slashSkill8 = slashSkill8;
		HeartCondition.blastSkill1 = blastSkill1;
		HeartCondition.blastSkill2 = blastSkill2;
		HeartCondition.blastSkill3 = blastSkill3;
		HeartCondition.blastSkill4 = blastSkill4;
		HeartCondition.blastSkill5 = blastSkill5;
		HeartCondition.blastSkill6 = blastSkill6;
		HeartCondition.blastSkill7 = blastSkill7;
		HeartCondition.blastSkill8 = blastSkill8;
		HeartCondition.blastSkill9 = blastSkill9;
		HeartCondition.blastSkill10 = blastSkill10;
		HeartCondition.buffSkill1 = buffSkill1;
		HeartCondition.buffSkill2 = buffSkill2;
		HeartCondition.buffSkill3 = buffSkill3;
		HeartCondition.buffSkill4 = buffSkill4;
		HeartCondition.buffSkill5 = buffSkill5;
		HeartCondition.buffSkill6 = buffSkill6;
	}
}
