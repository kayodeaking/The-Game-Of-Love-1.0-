using UnityEngine;
using System.Collections;
using System.IO;

public class HeartCondition : MonoBehaviour
{

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);
	private Rect miniWindowRec = new Rect ((Screen.width / 2) - 150, (Screen.height / 2) - 150, 300, 300);

	Vector2 scrollViewPos = Vector2.zero;

	int toolBarInt = 0;

	string[] toolBarString = new string[] {
		"Status",
		"Equipment",
		"Skills",
		"Inventory",
		"Letters"
	};

	public static int BP;
	public static int LP;

	public static int blood;
	public static int love;
	public static int pace;

	int unlockNextEquip = 0;
	int unlockNextInv = 0;
	int letterFound = 0;

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

	bool openGui;

	int letter = 0;
	// Use this for initialization
	void Start () {
		CheckFullStats ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI ()
	{
		windowRec = GUI.Window (2, windowRec, BackWin, "Heart Condition");

		if (openGui == true) {
			miniWindowRec = GUI.Window (5, miniWindowRec, TinyWin, "Heart Condition");
		}
	}

	void CheckFullStats() {

		pace = HeartsInfo.pace;
		blood = HeartsInfo.blood;
		love = HeartsInfo.love;
	}

	void BackWin (int windowID){

		//The base for the screen
		float screenMid = windowRec.width / 2;
		float screenTop = windowRec.height * 0;
		float screenBot = windowRec.height;
		
		//The basic size of each button
		int width = 50;
		int height = 50;

		//The other rectangles
		Rect retLevelRect = new Rect ((windowRec.width - 105), (windowRec.height * 0) + 18, width + 50, height);
		
		if (GUI.Button (retLevelRect, "Levels")) {
			Application.LoadLevel (1);
		}
		
		if (toolBarInt == 0) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 125, (windowRec.height - 75), 450, 50);
			
			Rect playerPicRect = new Rect ((screenMid / 16), screenTop + 30, (screenMid / 2) + 50, windowRec.height - height);
			
			Rect hpGaugeLblRect = new Rect (screenMid / 1.5f, screenTop + 100, width + 50, height);
			Rect hpIncRect = new Rect (screenMid + 130, screenTop + 130, width, height);
			Rect hpGaugeRect = new Rect (screenMid / 1.5f, screenTop + 130, 300, 50);
			
			Rect mpGaugeLblRect = new Rect (screenMid / 1.5f, screenTop + 250, width + 50, height);
			Rect mpIncRect = new Rect (screenMid + 130, screenTop + 280, width, height);
			Rect mpGaugeRect = new Rect (screenMid / 1.5f, screenTop + 280, 300, 50);
			
			Rect pumpRangeRect = new Rect (screenMid + 230, screenTop + 150, width + 200, height);
			Rect pumpIncRect = new Rect ((screenMid / 1.5f) + 50, screenTop + 365, width, height);
			Rect pumpAffectRect = new Rect (screenMid / 1.5f, screenTop + 380, width + 200, height);
			
			Rect loveRangeRect = new Rect (screenMid + 230, screenTop + 200, width + 200, height);
			Rect loveIncRect = new Rect ((screenMid / 1.5f) + 50, screenTop + 435, width, height);
			Rect loveAffectRect = new Rect (screenMid / 1.5f, screenTop + 450, width + 200, height);
			
			Rect cardRangeRect = new Rect (screenMid + 400, screenTop + 150, width + 200, height);
			Rect cardIncRect = new Rect ((screenMid / 1.5f) + 200, screenTop + 365, width, height);
			Rect cardAffectRect = new Rect ((screenMid / 1.5f) + 150, screenTop + 380, width + 200, height);
			
			Rect shellRangeRect = new Rect (screenMid + 400, screenTop + 200, width + 200, height);
			Rect shellIncRect = new Rect ((screenMid / 1.5f) + 200, screenTop + 435, width, height);
			Rect shellAffectRect = new Rect ((screenMid / 1.5f) + 150, screenTop + 450, width + 200, height);
			
			Rect statPointRect = new Rect ((screenMid / 1.5f) + 300, screenTop + 380, width + 100, height);

			Rect paceGaugeLblRect = new Rect (screenMid / 6,  screenBot - 100, width + 50, height);

			Rect expGaugeLblRect = new Rect (screenMid / 4, screenBot - 100, width + 150, height);
			Rect expGaugeRect = new Rect (screenMid / 10, screenBot - 80, 300, 50);

			//The Picture of the player
			GUI.Box (playerPicRect, "pic"); 

			GUI.Label (hpGaugeLblRect, "Blood Gauge: " + HeartsInfo.blood + "/" + blood);
			if(GUI.Button (hpIncRect, "^")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					BP += 1;
				}
			}
			GUI.Box (hpGaugeRect, "Place Holder");

			GUI.Label (mpGaugeLblRect, "Love Gauge: " + HeartsInfo.love + "/" + love);
			if(GUI.Button (mpIncRect, "^")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					LP += 1;
				}
			}
			GUI.Box (mpGaugeRect, "Place Holder");

			//att
			GUI.Label (pumpAffectRect, "Str: " + HeartsInfo.strPoints);
			if(GUI.Button (pumpIncRect, "+")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					HeartsInfo.strPoints += 1;
				}
			}
			GUI.Label (pumpRangeRect, "Pumper: " + HeartsInfo.pumpLow + " ~ " + HeartsInfo.pumpHigh);

			//magic
			GUI.Label (loveAffectRect, "Int: " + HeartsInfo.intPoints);
			if(GUI.Button (loveIncRect, "+")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					HeartsInfo.intPoints += 1;
				}
			}
			GUI.Label (loveRangeRect, "Love Range: " + HeartsInfo.loveLow + " ~ " + HeartsInfo.loveHigh);

			//speed
			GUI.Label (cardAffectRect, "Dex: " + HeartsInfo.dexPoints);
			if(GUI.Button (cardIncRect, "+")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					HeartsInfo.dexPoints += 1;
				}
			}
			GUI.Label (cardRangeRect, "Cardio: " + HeartsInfo.cardioLow + " ~ " + HeartsInfo.cardioHigh);

			//defense
			GUI.Label (shellAffectRect, "Luk: " + HeartsInfo.lukPoints);
			if(GUI.Button (shellIncRect, "+")) {
				if(HeartsInfo.statPoints > 0) {
					HeartsInfo.statPoints -=1;
					HeartsInfo.lukPoints += 1;
				}
			}
			GUI.Label (shellRangeRect, "Shell: " + HeartsInfo.shellLow + " ~ " + HeartsInfo.shellHigh);
		
			//status points
			GUI.Label (statPointRect, "Status Points: " + HeartsInfo.statPoints);

			//Level
			GUI.Label (paceGaugeLblRect, "Pace:" + HeartsInfo.pace);

			//exp
			GUI.Label (expGaugeLblRect, "Exp Until Next Pace: " + HeartsInfo.exp);
			GUI.Box (expGaugeRect, "Place Holder");
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		if (toolBarInt == 1) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, windowRec.width, 380));

			Rect boxRec = new Rect (0, 0, windowRec.width, 380);

			GUI.Box (boxRec, "Place");

			float boxTop = (boxRec.height*0) + 25;
			float boxRight = (boxRec.width*0) + 30;

			GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), "It. 1");
			GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), "It. 2");
			GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), "It. 3");
			GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), "It. 4");

			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), "It. 5");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), "It. 6");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), "It. 7");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), "It. 8");
			
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), "It. 9");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), "It. 10");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), "It. 11");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), "It. 12");
			
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), "It. 13");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), "It. 14");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), "It. 15");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), "It. 16");
			
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), "It. 17");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), "It. 18");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), "It. 19");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), "It. 20");
			
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), "It. 21");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), "It. 22");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), "It. 23");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), "It. 24");
			
			LockedEquips (boxTop, boxRight);

			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		if (toolBarInt == 2) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, (windowRec.width - 70), 500));

			Rect bacRec = new Rect (0, 0, (windowRec.width - 70), 500);

			GUI.Box (bacRec, "Place");

			if(pace >= 5) {
				if(GUI.Button (new Rect (150, 25, 75, 75), "Skill 1")) {
					if(HeartsInfo.skillPoints > 0) {
						slashSkill1 += 1;
						HeartsInfo.skillPoints -= 1;
					}
				}
			}else{
				GUI.Button (new Rect (150, 25, 75, 75), "Skill Locked");
			}
			SlashBranch();

			if(pace >= 10) {
				if(GUI.Button (new Rect ((bacRec.width / 2) - 40, 25, 75, 75), "Skill 2")) {
					if(HeartsInfo.skillPoints > 0) {
						blastSkill1 += 1;
						HeartsInfo.skillPoints -= 1;
					}
				}
			}else {
				GUI.Button (new Rect ((bacRec.width / 2) - 40, 25, 75, 75), "Skill Locked");
			}
			BlastBranch(bacRec);

			if(pace >= 15) {
				if(GUI.Button (new Rect (835, 25, 75, 75), "Skill 3")) {
					if(HeartsInfo.skillPoints > 0) {
						buffSkill1 += 1;
						HeartsInfo.skillPoints -= 1;
					}
				}
			}
			BuffBranch();

			GUI.Label (new Rect((bacRec.width / 2) - 40, bacRec.height -50, 150, 150), "Skill Points: " + HeartsInfo.skillPoints);
			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		if (toolBarInt == 3) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, windowRec.width, 380));
			Rect boxRec = new Rect (0, 0, windowRec.width, 380);
			
			GUI.Box (boxRec, "Place");
			
			float boxTop = (boxRec.height*0) + 25;
			float boxRight = (boxRec.width*0) + 30;
			
			GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), "It. 1");
			GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), "It. 2");
			GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), "It. 3");
			GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), "It. 4");
			
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), "It. 5");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), "It. 6");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), "It. 7");
			GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), "It. 8");
			
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), "It. 9");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), "It. 10");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), "It. 11");
			GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), "It. 12");
			
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), "It. 13");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), "It. 14");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), "It. 15");
			GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), "It. 16");
			
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), "It. 17");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), "It. 18");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), "It. 19");
			GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), "It. 20");
			
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), "It. 21");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), "It. 22");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), "It. 23");
			GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), "It. 24");
			
			LockedInv (boxRight, boxTop);

			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		if (toolBarInt == 4) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, (windowRec.width - 70), 500));

			Rect boxRec = new Rect (0, 0, (windowRec.width - 70), 500);

			float boxTop = (boxRec.height*0) + 45;
			float boxRight = (boxRec.width*0) + 40;

			GUI.Box (boxRec, "Place");

			Letters (boxTop, boxRight);

			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

	}
	
	void LockedEquips(float top, float right) {

		if (unlockNextEquip >= 1) {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "It. 25");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "It. 26");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "It. 27");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "It. 28");
		} else {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Locked");
		}


		if (unlockNextEquip >= 2) {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "It. 29");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "It. 30");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "It. 31");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "It. 32");
		} else {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 3) {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "It. 33");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "It. 34");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "It. 35");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "It. 36");
		} else {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 4) {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "It. 37");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "It. 38");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "It. 39");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "It. 40");
		} else {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 5) {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "It. 41");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "It. 42");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "It. 43");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "It. 44");
		} else {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 6) {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "It. 45");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "It. 46");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "It. 47");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "It. 48");
		} else {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 7) {
			GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "It. 49");
			GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "It. 50");
			GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "It. 51");
			GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "It. 52");
		} else {
			GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "Locked");
		}
	}

	void SlashBranch(){


		if ((HeartsInfo.pace >= 20) && (slashSkill1 >= 5)) {
			if(GUI.Button (new Rect (65, 130, 75, 75), "Skill 1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill2 += 1;
					HeartsInfo.skillPoints -=1;
				}
			}
			if(GUI.Button (new Rect (150, 130, 75, 75), "Skill 1.2")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill3 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect (235, 130, 75, 75), "Skill 1.3")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill4 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (65, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect (150, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect (235, 130, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 25) && (slashSkill2 >= 5)) {
			if (GUI.Button (new Rect (65, 235, 75, 75), "Skill 1.1.1")) {
				if (HeartsInfo.skillPoints > 0) {
					slashSkill5 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (65, 235, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 30) && (slashSkill3 >= 5)) {
			if(GUI.Button (new Rect (150, 235, 75, 75), "Skill 1.2.1")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill6 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect (105, 340, 75, 75), "Skill 1.2.2")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill7 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect (200, 340, 75, 75), "Skill 1.2.3")) {
				if(HeartsInfo.skillPoints > 0) {
					slashSkill8 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (150, 235, 75, 75), "Skill Locked");
			GUI.Button (new Rect (105, 340, 75, 75), "Skill Locked");
			GUI.Button (new Rect (200, 340, 75, 75), "Skill Locked");
		}

	}

	void BlastBranch(Rect bac){

		if ((HeartsInfo.pace >= 25) && (blastSkill1 >= 5)) {
			if(GUI.Button (new Rect ((bac.width / 2) - 125, 130, 75, 75), "Skill 2.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill2 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect ((bac.width / 2) - 40, 130, 75, 75), "Skill 2.2")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill3 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect ((bac.width / 2) + 45, 130, 75, 75), "Skill 2.3")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill4 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) - 125, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect ((bac.width / 2) - 40, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect ((bac.width / 2) + 45, 130, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 30) && (blastSkill2 >= 5)) {
			if(GUI.Button (new Rect ((bac.width / 2) - 125, 235, 75, 75), "Skill 2.1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill5 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) - 125, 235, 75, 75), "Skill Locked");
		}

		if((HeartsInfo.pace >= 45) && (blastSkill5 >= 5)){
			if(GUI.Button (new Rect ((bac.width / 2) - 125, 340, 75, 75), "Skill 2.1.1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill8 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) - 125, 340, 75, 75), "Skill Locked");
		}

		if((HeartsInfo.pace >= 35) && (blastSkill3 >= 5)) {
			if(GUI.Button (new Rect ((bac.width / 2) - 40, 235, 75, 75), "Skill 2.2.1")){
				if(HeartsInfo.skillPoints > 0) {
					blastSkill6 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) - 40, 235, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 50) && (blastSkill6 >= 5)) { 
			if(GUI.Button (new Rect ((bac.width / 2) - 40, 340, 75, 75), "Skill 2.2.1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill9 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) - 40, 340, 75, 75), "Skill Locked");
		}

		if((HeartsInfo.pace >= 40) && (blastSkill4 >= 5)) {
			if(GUI.Button (new Rect ((bac.width / 2) + 45, 235, 75, 75), "Skill 2.3.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill7 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) + 45, 235, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 55) && (blastSkill7 >= 5)) {
			if(GUI.Button (new Rect ((bac.width / 2) + 45, 340, 75, 75), "Skill 2.3.1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					blastSkill10 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect ((bac.width / 2) + 45, 340, 75, 75), "Skill Locked");
		}
	}

	void BuffBranch(){

		if ((HeartsInfo.pace >= 30) && (buffSkill1 >= 5)) {
			if(GUI.Button (new Rect (785, 130, 75, 75), "Skill 3.1")) {
				if(HeartsInfo.skillPoints > 0) {
					buffSkill2 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect (890, 130, 75, 75), "Skill 3.2")) {
				if(HeartsInfo.skillPoints > 0) {
					buffSkill3 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
			if(GUI.Button (new Rect (835, 340, 75, 75), "Skill 3.3")) {
				if(HeartsInfo.skillPoints > 0) {
					buffSkill4 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (785, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect (890, 130, 75, 75), "Skill Locked");
			GUI.Button (new Rect (835, 340, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 35) && (buffSkill3 >= 5)) {
			if(GUI.Button (new Rect (785, 235, 75, 75), "Skill 3.1.1")) {
				if(HeartsInfo.skillPoints > 0) {
					buffSkill5 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (785, 235, 75, 75), "Skill Locked");
		}

		if ((HeartsInfo.pace >= 40) && (buffSkill4 >= 5)) {
			if(GUI.Button (new Rect (890, 235, 75, 75), "Skill 3.2.1")) {
				if(HeartsInfo.skillPoints > 0){
					buffSkill6 += 1;
					HeartsInfo.skillPoints -= 1;
				}
			}
		} else {
			GUI.Button (new Rect (890, 235, 75, 75), "Skill Locked");
		}

	}

	void LockedInv(float right, float top) {
		
		if (unlockNextInv >= 1) {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "It. 25");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "It. 26");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "It. 27");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "It. 28");
		} else {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Locked");
		}
		
		
		if (unlockNextInv >= 2) {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "It. 29");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "It. 30");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "It. 31");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "It. 32");
		} else {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 3) {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "It. 33");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "It. 34");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "It. 35");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "It. 36");
		} else {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 4) {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "It. 37");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "It. 38");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "It. 39");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "It. 40");
		} else {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 5) {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "It. 41");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "It. 42");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "It. 43");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "It. 44");
		} else {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 6) {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "It. 45");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "It. 46");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "It. 47");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "It. 48");
		} else {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 7) {
			GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "It. 49");
			GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "It. 50");
			GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "It. 51");
			GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "It. 52");
		} else {
			GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "Locked");
		}
	}

	void Letters(float top, float right) {

		if (letterFound >= 1) {
			if(GUI.Button (new Rect (right + (85 * 0), top + (85 * 0), 75, 75), "Let. 1")) {
				openGui = true;
				letter = 1;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 0), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 2) {
			if(GUI.Button (new Rect (right + (85 * 0), top + (85 * 1), 75, 75), "Let. 2")){
				openGui = true;
				letter = 2;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 0), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 3) {
			if(GUI.Button (new Rect (right + (85 * 0), top + (85 * 2), 75, 75), "Let. 3")) {
				openGui = true;
				letter = 3;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 0), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 4) {
			if(GUI.Button (new Rect (right + (85 * 0), top + (85 * 3), 75, 75), "Let. 4")){
				openGui = true;
				letter = 4;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 0), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 5) {
			if(GUI.Button (new Rect (right + (85 * 0), top + (85 * 4), 75, 75), "Let. 5")) {
				openGui = true;
				letter = 5;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 0), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 6) {
			if(GUI.Button (new Rect (right + (85 * 1), top + (85 * 0), 75, 75), "Let. 6")) {
				openGui = true;
				letter = 6;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 1), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 7) {
			if(GUI.Button (new Rect (right + (85 * 1), top + (85 * 1), 75, 75), "Let. 7")) {
				openGui = true;
				letter = 7;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 1), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 8) {
			if(GUI.Button (new Rect (right + (85 * 1), top + (85 * 2), 75, 75), "Let. 8")) {
				openGui = true;
				letter = 8;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 1), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 9) {
			if(GUI.Button (new Rect (right + (85 * 1), top + (85 * 3), 75, 75), "Let. 9")) {
				openGui = true;
				letter = 9;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 1), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 10) {
			if(GUI.Button (new Rect (right + (85 * 1), top + (85 * 4), 75, 75), "Let. 10")) {
				openGui = true;
				letter = 10;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 1), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 11) {
			if (GUI.Button (new Rect (right + (85 * 2), top + (85 * 0), 75, 75), "Let. 11")) {
				openGui = true;
				letter = 11;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 2), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 12) {
			if (GUI.Button (new Rect (right + (85 * 2), top + (85 * 1), 75, 75), "Let. 12")) {
				openGui = true;
				letter = 12;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 2), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 13) {
			if (GUI.Button (new Rect (right + (85 * 2), top + (85 * 2), 75, 75), "Let. 13")) {
				openGui = true;
				letter = 13;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 2), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 14) {
			if (GUI.Button (new Rect (right + (85 * 2), top + (85 * 3), 75, 75), "Let. 14")) {
				openGui = true;
				letter = 14;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 2), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 15) {
			if (GUI.Button (new Rect (right + (85 * 2), top + (85 * 4), 75, 75), "Let. 15")) {
				openGui = true;
				letter = 15;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 2), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 16) {
			if (GUI.Button (new Rect (right + (85 * 3), top + (85 * 0), 75, 75), "Let. 16")) {
				openGui = true;
				letter = 16;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 3), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 17) {
			if (GUI.Button (new Rect (right + (85 * 3), top + (85 * 1), 75, 75), "Let. 17")) {
				openGui = true;
				letter = 17;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 3), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 18) {
			if (GUI.Button (new Rect (right + (85 * 3), top + (85 * 2), 75, 75), "Let. 18")) {
				openGui = true;
				letter = 18;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 3), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 19) {
			if (GUI.Button (new Rect (right + (85 * 3), top + (85 * 3), 75, 75), "Let. 19")) {
				openGui = true;
				letter = 19;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 3), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 20) {
			if (GUI.Button (new Rect (right + (85 * 3), top + (85 * 4), 75, 75), "Let. 20")) {
				openGui = true;
				letter = 20;
			}
		} else { 
			GUI.Button (new Rect (right + (85 * 3), top + (85 * 4), 75, 75), "Locked");
		}
		
		if (letterFound >= 21) {
			if (GUI.Button (new Rect (right + (85 * 4), top + (85 * 0), 75, 75), "Let. 21")) {
				openGui = true;
				letter = 21;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 4), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 22) {
			if (GUI.Button (new Rect (right + (85 * 4), top + (85 * 1), 75, 75), "Let. 22")) {
				openGui = true;
				letter = 22;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 4), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 23) {
			if (GUI.Button (new Rect (right + (85 * 4), top + (85 * 2), 75, 75), "Let. 23")) {
				openGui = true;
				letter = 23;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 4), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 24) {
			if (GUI.Button (new Rect (right + (85 * 4), top + (85 * 3), 75, 75), "Let. 24")) {
				openGui = true;
				letter = 24;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 4), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 25) {
			if (GUI.Button (new Rect (right + (85 * 4), top + (85 * 4), 75, 75), "Let. 25")) {
				openGui = true;
				letter = 25;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 4), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 26) {
			if (GUI.Button (new Rect (right + (85 * 5), top + (85 * 0), 75, 75), "Let. 26")) {
				openGui = true;
				letter = 26;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 5), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 27) {
			if (GUI.Button (new Rect (right + (85 * 5), top + (85 * 1), 75, 75), "Let. 27")) {
				openGui = true;
				letter = 27;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 5), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 28) {
			if (GUI.Button (new Rect (right + (85 * 5), top + (85 * 2), 75, 75), "Let. 28")) {
				openGui = true;
				letter = 28;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 5), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 29) {
			if (GUI.Button (new Rect (right + (85 * 5), top + (85 * 3), 75, 75), "Let. 29")) {
				openGui = true;
				letter = 29;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 5), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 30) {
			if (GUI.Button (new Rect (right + (85 * 5), top + (85 * 4), 75, 75), "Let. 30")) {
				openGui = true;
				letter = 30;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 5), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 31) {
			if (GUI.Button (new Rect (right + (85 * 6), top + (85 * 0), 75, 75), "Let. 31")) {
				openGui = true;
				letter = 31;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 6), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 32) {
			if (GUI.Button (new Rect (right + (85 * 6), top + (85 * 1), 75, 75), "Let. 32")) {
				openGui = true;
				letter = 32;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 6), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 33) {
			if (GUI.Button (new Rect (right + (85 * 6), top + (85 * 2), 75, 75), "Let. 33")) {
				openGui = true;
				letter = 33;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 6), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 34) {
			if (GUI.Button (new Rect (right + (85 * 6), top + (85 * 3), 75, 75), "Let. 34")) {
				openGui = true;
				letter = 34;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 6), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 35) {
			if (GUI.Button (new Rect (right + (85 * 6), top + (85 * 4), 75, 75), "Let. 35")) {
				openGui = true;
				letter = 35;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 6), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 36) {
			if (GUI.Button (new Rect (right + (85 * 7), top + (85 * 0), 75, 75), "Let. 36")) {
				openGui = true;
				letter = 36;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 7), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 37) {
			if (GUI.Button (new Rect (right + (85 * 7), top + (85 * 1), 75, 75), "Let. 37")) {
				openGui = true;
				letter = 37;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 7), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 38) {
			if (GUI.Button (new Rect (right + (85 * 7), top + (85 * 2), 75, 75), "Let. 38")) {
				openGui = true;
				letter = 38;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 7), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 39) {
			if (GUI.Button (new Rect (right + (85 * 7), top + (85 * 3), 75, 75), "Let. 39")) {
				openGui = true;
				letter = 39;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 7), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 40) {
			if (GUI.Button (new Rect (right + (85 * 7), top + (85 * 4), 75, 75), "Let. 40")) {
				openGui = true;
				letter = 40;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 7), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 41) {
			if (GUI.Button (new Rect (right + (85 * 8), top + (85 * 0), 75, 75), "Let. 41")) {
				openGui = true;
				letter = 41;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 8), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 42) {
			if (GUI.Button (new Rect (right + (85 * 8), top + (85 * 1), 75, 75), "Let. 42")) {
				openGui = true;
				letter = 42;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 8), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 43) {
			if (GUI.Button (new Rect (right + (85 * 8), top + (85 * 2), 75, 75), "Let. 43")) {
				openGui = true;
				letter = 43;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 8), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 44) {
			if (GUI.Button (new Rect (right + (85 * 8), top + (85 * 3), 75, 75), "Let. 44")) {
				openGui = true;
				letter = 44;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 8), top + (85 * 3), 75, 75), "Locked");
		}
	
		if (letterFound >= 45) {
			if (GUI.Button (new Rect (right + (85 * 8), top + (85 * 4), 75, 75), "Let. 45")) {
				openGui = true;
				letter = 45;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 8), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 46) {
			if (GUI.Button (new Rect (right + (85 * 9), top + (85 * 0), 75, 75), "Let. 46")) {
				openGui = true;
				letter = 46;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 9), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 47) {
			if (GUI.Button (new Rect (right + (85 * 9), top + (85 * 1), 75, 75), "Let. 47")) {
				openGui = true;
				letter = 47;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 9), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 48) {
			if (GUI.Button (new Rect (right + (85 * 9), top + (85 * 2), 75, 75), "Let. 48")) {
				openGui = true;
				letter = 48;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 9), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 49) {
			if (GUI.Button (new Rect (right + (85 * 9), top + (85 * 3), 75, 75), "Let. 49")) {
				openGui = true;
				letter = 49;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 9), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 50) {
			if (GUI.Button (new Rect (right + (85 * 9), top + (85 * 4), 75, 75), "Let. 50")) {
				openGui = true;
				letter = 50;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 9), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 51) {
			if (GUI.Button (new Rect (right + (85 * 10), top + (85 * 0), 75, 75), "Let. 51")) {
				openGui = true;
				letter = 51;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 10), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 52) {
			if (GUI.Button (new Rect (right + (85 * 10), top + (85 * 1), 75, 75), "Let. 52")) {
				openGui = true;
				letter = 52;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 10), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 53) {
			if (GUI.Button (new Rect (right + (85 * 10), top + (85 * 2), 75, 75), "Let. 53")) {
				openGui = true;
				letter = 53;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 10), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 54) {
			if (GUI.Button (new Rect (right + (85 * 10), top + (85 * 3), 75, 75), "Let. 54")) {
				openGui = true;
				letter = 54;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 10), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 55) {
			if (GUI.Button (new Rect (right + (85 * 10), top + (85 * 4), 75, 75), "Let. 55")) {
				openGui = true;
				letter = 55;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 10), top + (85 * 4), 75, 75), "Locked");
		}

		if (letterFound >= 56) {
			if (GUI.Button (new Rect (right + (85 * 11), top + (85 * 0), 75, 75), "Let. 56")) {
				openGui = true;
				letter = 56;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 11), top + (85 * 0), 75, 75), "Locked");
		}

		if (letterFound >= 57) {
			if (GUI.Button (new Rect (right + (85 * 11), top + (85 * 1), 75, 75), "Let. 57")) {
				openGui = true;
				letter = 57;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 11), top + (85 * 1), 75, 75), "Locked");
		}

		if (letterFound >= 58) {
			if (GUI.Button (new Rect (right + (85 * 11), top + (85 * 2), 75, 75), "Let. 58")) {
				openGui = true;
				letter = 58;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 11), top + (85 * 2), 75, 75), "Locked");
		}

		if (letterFound >= 59) {
			if (GUI.Button (new Rect (right + (85 * 11), top + (85 * 3), 75, 75), "Let. 59")) {
				openGui = true;
				letter = 59;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 11), top + (85 * 3), 75, 75), "Locked");
		}

		if (letterFound >= 60) {
			if (GUI.Button (new Rect (right + (85 * 11), top + (85 * 4), 75, 75), "Let. 60")) {
				openGui = true;
				letter = 60;
			}
		} else {
			GUI.Button (new Rect (right + (85 * 11), top + (85 * 4), 75, 75), "Let. 60");
		}

	}

	void TinyWin(int windowID) {
		GetLetter ();
	}

	void GetLetter() {

		using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Letters.txt")) {
			
			string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Letters.txt");
			string[] info = new string[5];

			for(int i = 0; i < fileInfo.Length; i++){
				if(letter == (int.Parse (fileInfo[i]))) {
					info[0] = fileInfo[i];
					info[1] = fileInfo[i + 1];
					info[2] = fileInfo[i + 2];
					info[3] = fileInfo[i + 3];
					info[4] = fileInfo[i + 4];

					BuildLetter (info);

					i = fileInfo.Length;
				}else {
					i += 5;
				}
			}
		}
	}

	void BuildLetter (string[] info) {

		GUI.Label (new Rect ((miniWindowRec.width * 0) + 5, (miniWindowRec.height * 0) + 25, 100, 50), "Letter # " + info [0]);
		GUI.Label (new Rect ((miniWindowRec.width * 0) + 5, (miniWindowRec.height * 0) + 55, (miniWindowRec.width) - 5, (miniWindowRec.height) - 50), info [1]);
		GUI.Label (new Rect ((miniWindowRec.width * 0) + 5, (miniWindowRec.height * 0) + 70, (miniWindowRec.width) - 5, (miniWindowRec.height) - 50), info [2] + " "+ info[3] + " " + info [4]);
		if (GUI.Button (new Rect ((miniWindowRec.width / 2) - 50, miniWindowRec.height - 50, 100, 25), "Finished")) {
			openGui = false;
		}
	}
}
