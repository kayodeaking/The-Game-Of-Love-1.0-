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

	public static int LP;
	public static int BP;

	public static int blood;
	public static int love;
	public static int pace;

	public static int unlockNextEquip;
	public static int unlockNextInv;
	public static int letterFound;

	public static int slashSkill1;
	public static int slashSkill2;
	public static int slashSkill3;
	public static int slashSkill4;
	public static int slashSkill5;
	public static int slashSkill6;
	public static int slashSkill7;
	public static int slashSkill8;

	public static int blastSkill1;
	public static int blastSkill2;
	public static int blastSkill3;
	public static int blastSkill4;
	public static int blastSkill5;
	public static int blastSkill6;
	public static int blastSkill7;
	public static int blastSkill8;
	public static int blastSkill9;
	public static int blastSkill10;

	public static int buffSkill1;
	public static int buffSkill2;
	public static int buffSkill3;
	public static int buffSkill4;
	public static int buffSkill5;
	public static int buffSkill6;

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
			miniWindowRec = GUI.Window (5, miniWindowRec, TinyWin, "Letters");
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

		//Player Information
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

		//Equipment
		if (toolBarInt == 1) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, windowRec.width, 380));

			Rect boxRec = new Rect (0, 0, windowRec.width, 380);

			GUI.Box (boxRec, "Place");

			float boxTop = (boxRec.height*0) + 25;
			float boxRight = (boxRec.width*0) + 30;

			if((AddToSlots.equipSpace1Empty == true) && (AddToSlots.equipSpace1Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace1Name)) {
					AddToSlots.equipSpace1Quan -= 1;
					if(AddToSlots.equipSpace1Quan <= 0) {
						AddToSlots.equipSpace1Empty = true;
						AddToSlots.equipSpace1Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace2Empty == true) && (AddToSlots.equipSpace2Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace2Name)) {
					AddToSlots.equipSpace2Quan -= 1;
					if(AddToSlots.equipSpace2Quan <= 0) {
						AddToSlots.equipSpace2Empty = true;
						AddToSlots.equipSpace2Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace3Empty == true) && (AddToSlots.equipSpace3Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace3Name)) {
					AddToSlots.equipSpace3Quan -= 1;
					if(AddToSlots.equipSpace3Quan <= 0) {
						AddToSlots.equipSpace3Empty = true;
						AddToSlots.equipSpace3Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace4Empty == true) && (AddToSlots.equipSpace4Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace4Name)) {
					AddToSlots.equipSpace4Quan -= 1;
					if(AddToSlots.equipSpace4Quan <= 0) {
						AddToSlots.equipSpace4Empty = true;
						AddToSlots.equipSpace4Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace5Empty == true) && (AddToSlots.equipSpace5Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace5Name)) {
					AddToSlots.equipSpace5Quan -= 1;
					if(AddToSlots.equipSpace5Quan <= 0) {
						AddToSlots.equipSpace5Empty = true;
						AddToSlots.equipSpace5Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace6Empty == true) && (AddToSlots.equipSpace6Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace6Name)) {
					AddToSlots.equipSpace6Quan -= 1;
					if(AddToSlots.equipSpace6Quan <= 0) {
						AddToSlots.equipSpace6Empty = true;
						AddToSlots.equipSpace6Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace7Empty == true) && (AddToSlots.equipSpace7Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace7Name)) {
					AddToSlots.equipSpace7Quan -= 1;
					if(AddToSlots.equipSpace7Quan <= 0) {
						AddToSlots.equipSpace7Empty = true;
						AddToSlots.equipSpace7Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace8Empty == true) && (AddToSlots.equipSpace8Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace8Name)) {
					AddToSlots.equipSpace8Quan -= 1;
					if(AddToSlots.equipSpace8Quan <= 0) {
						AddToSlots.equipSpace8Empty = true;
						AddToSlots.equipSpace8Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace9Empty == true) && (AddToSlots.equipSpace9Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace9Name)) {
					AddToSlots.equipSpace9Quan -= 1;
					if(AddToSlots.equipSpace9Quan <= 0) {
						AddToSlots.equipSpace9Empty = true;
						AddToSlots.equipSpace9Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace10Empty == true) && (AddToSlots.equipSpace10Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace10Name)) {
					AddToSlots.equipSpace10Quan -= 1;
					if(AddToSlots.equipSpace10Quan <= 0) {
						AddToSlots.equipSpace10Empty = true;
						AddToSlots.equipSpace10Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace11Empty == true) && (AddToSlots.equipSpace11Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace11Name)) {
					AddToSlots.equipSpace11Quan -= 1;
					if(AddToSlots.equipSpace11Quan <= 0) {
						AddToSlots.equipSpace11Empty = true;
						AddToSlots.equipSpace11Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace12Empty == true) && (AddToSlots.equipSpace12Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace12Name)) {
					AddToSlots.equipSpace12Quan -= 1;
					if(AddToSlots.equipSpace12Quan <= 0) {
						AddToSlots.equipSpace12Empty = true;
						AddToSlots.equipSpace12Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace13Empty == true) && (AddToSlots.equipSpace13Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace13Name)) {
					AddToSlots.equipSpace13Quan -= 1;
					if(AddToSlots.equipSpace13Quan <= 0) {
						AddToSlots.equipSpace13Empty = true;
						AddToSlots.equipSpace13Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace14Empty == true) && (AddToSlots.equipSpace14Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace14Name)) {
					AddToSlots.equipSpace14Quan -= 1;
					if(AddToSlots.equipSpace14Quan <= 0) {
						AddToSlots.equipSpace14Empty = true;
						AddToSlots.equipSpace14Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace15Empty == true) && (AddToSlots.equipSpace15Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace15Name)) {
					AddToSlots.equipSpace15Quan -= 1;
					if(AddToSlots.equipSpace15Quan <= 0) {
						AddToSlots.equipSpace15Empty = true;
						AddToSlots.equipSpace15Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace16Empty == true) && (AddToSlots.equipSpace16Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace16Name)) {
					AddToSlots.equipSpace16Quan -= 1;
					if(AddToSlots.equipSpace16Quan <= 0) {
						AddToSlots.equipSpace16Empty = true;
						AddToSlots.equipSpace16Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace17Empty == true) && (AddToSlots.equipSpace17Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace17Name)) {
					AddToSlots.equipSpace17Quan -= 1;
					if(AddToSlots.equipSpace17Quan <= 0) {
						AddToSlots.equipSpace17Empty = true;
						AddToSlots.equipSpace17Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace18Empty == true) && (AddToSlots.equipSpace18Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace18Name)) {
					AddToSlots.equipSpace18Quan -= 1;
					if(AddToSlots.equipSpace18Quan <= 0) {
						AddToSlots.equipSpace18Empty = true;
						AddToSlots.equipSpace18Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace19Empty == true) && (AddToSlots.equipSpace19Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace19Name)) {
					AddToSlots.equipSpace19Quan -= 1;
					if(AddToSlots.equipSpace19Quan <= 0) {
						AddToSlots.equipSpace19Empty = true;
						AddToSlots.equipSpace19Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace20Empty == true) && (AddToSlots.equipSpace20Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace20Name)) {
					AddToSlots.equipSpace20Quan -= 1;
					if(AddToSlots.equipSpace20Quan <= 0) {
						AddToSlots.equipSpace20Empty = true;
						AddToSlots.equipSpace20Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace21Empty == true) && (AddToSlots.equipSpace21Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), AddToSlots.equipSpace21Name)) {
					AddToSlots.equipSpace21Quan -= 1;
					if(AddToSlots.equipSpace21Quan <= 0) {
						AddToSlots.equipSpace21Empty = true;
						AddToSlots.equipSpace21Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace22Empty == true) && (AddToSlots.equipSpace22Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), AddToSlots.equipSpace22Name)) {
					AddToSlots.equipSpace22Quan -= 1;
					if(AddToSlots.equipSpace22Quan <= 0) {
						AddToSlots.equipSpace22Empty = true;
						AddToSlots.equipSpace22Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace23Empty == true) && (AddToSlots.equipSpace23Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), AddToSlots.equipSpace23Name)) {
					AddToSlots.equipSpace23Quan -= 1;
					if(AddToSlots.equipSpace23Quan <= 0) {
						AddToSlots.equipSpace23Empty = true;
						AddToSlots.equipSpace23Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace24Empty == true) && (AddToSlots.equipSpace24Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), AddToSlots.equipSpace24Name)) {
					AddToSlots.equipSpace24Quan -= 1;
					if(AddToSlots.equipSpace24Quan <= 0) {
						AddToSlots.equipSpace24Empty = true;
						AddToSlots.equipSpace24Full = false;
					}
				}
			}

			LockedEquips (boxTop, boxRight);

			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		//Skills	
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

		//Inventory
		if (toolBarInt == 3) {

			Rect toolBarRect = new Rect ((windowRec.width / 2) - 240, (windowRec.height - 75), 450, 50);
			
			scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 25, (windowRec.height - 490), (windowRec.width - 50), 400), scrollViewPos, new Rect (0, 0, windowRec.width, 380));
			Rect boxRec = new Rect (0, 0, windowRec.width, 380);
			
			GUI.Box (boxRec, "Place");
			
			float boxTop = (boxRec.height*0) + 25;
			float boxRight = (boxRec.width*0) + 30;


			if((AddToSlots.invSpace1Empty == true) && (AddToSlots.invSpace1Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*0)), 75, 75), AddToSlots.invSpace1Name)) {
					AddToSlots.invSpace1Quan -= 1;
					if(AddToSlots.invSpace1Quan <= 0) {
						AddToSlots.invSpace1Empty = true;
						AddToSlots.invSpace1Full = false;
					}
				}
			}

			if((AddToSlots.invSpace2Empty == true) && (AddToSlots.invSpace2Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*1)), 75, 75), AddToSlots.invSpace2Name)) {
					AddToSlots.invSpace2Quan -= 1;
					if(AddToSlots.invSpace2Quan <= 0) {
						AddToSlots.invSpace2Empty = true;
						AddToSlots.invSpace2Full = false;
					}
				}
			}

			if((AddToSlots.invSpace3Empty == true) && (AddToSlots.invSpace3Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*2)), 75, 75), AddToSlots.invSpace3Name)) {
					AddToSlots.invSpace3Quan -= 1;
					if(AddToSlots.invSpace3Quan <= 0) {
						AddToSlots.invSpace3Empty = true;
						AddToSlots.invSpace3Full = false;
					}
				}
			}

			if((AddToSlots.invSpace4Empty == true) && (AddToSlots.invSpace4Full == false)) {
				GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight, (boxTop + (85*3)), 75, 75), AddToSlots.invSpace4Name)) {
					AddToSlots.invSpace4Quan -= 1;
					if(AddToSlots.invSpace4Quan <= 0) {
						AddToSlots.invSpace4Empty = true;
						AddToSlots.invSpace4Full = false;
					}
				}
			}

			if((AddToSlots.invSpace5Empty == true) && (AddToSlots.invSpace5Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*0)), 75, 75), AddToSlots.invSpace5Name)) {
					AddToSlots.invSpace5Quan -= 1;
					if(AddToSlots.invSpace5Quan <= 0) {
						AddToSlots.invSpace5Empty = true;
						AddToSlots.invSpace5Full = false;
					}
				}
			}

			if((AddToSlots.invSpace6Empty == true) && (AddToSlots.invSpace6Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*1)), 75, 75), AddToSlots.invSpace6Name)) {
					AddToSlots.invSpace6Quan -= 1;
					if(AddToSlots.invSpace6Quan <= 0) {
						AddToSlots.invSpace6Empty = true;
						AddToSlots.invSpace6Full = false;
					}
				}
			}

			if((AddToSlots.invSpace7Empty == true) && (AddToSlots.invSpace7Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*2)), 75, 75), AddToSlots.invSpace7Name)) {
					AddToSlots.invSpace7Quan -= 1;
					if(AddToSlots.invSpace7Quan <= 0) {
						AddToSlots.invSpace7Empty = true;
						AddToSlots.invSpace7Full = false;
					}
				}
			}

			if((AddToSlots.invSpace8Empty == true) && (AddToSlots.invSpace8Full == false)) {
				GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*1), (boxTop + (85*3)), 75, 75), AddToSlots.invSpace8Name)) {
					AddToSlots.invSpace8Quan -= 1;
					if(AddToSlots.invSpace8Quan <= 0) {
						AddToSlots.invSpace8Empty = true;
						AddToSlots.invSpace8Full = false;
					}
				}
			}

			if((AddToSlots.invSpace9Empty == true) && (AddToSlots.invSpace9Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*0)), 75, 75), AddToSlots.invSpace9Name)) {
					AddToSlots.invSpace9Quan -= 1;
					if(AddToSlots.invSpace9Quan <= 0) {
						AddToSlots.invSpace9Empty = true;
						AddToSlots.invSpace9Full = false;
					}
				}
			}

			if((AddToSlots.invSpace10Empty == true) && (AddToSlots.invSpace10Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*1)), 75, 75), AddToSlots.invSpace10Name)) {
					AddToSlots.invSpace10Quan -= 1;
					if(AddToSlots.invSpace10Quan <= 0) {
						AddToSlots.invSpace10Empty = true;
						AddToSlots.invSpace10Full = false;
					}
				}
			}

			if((AddToSlots.invSpace11Empty == true) && (AddToSlots.invSpace11Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*2)), 75, 75), AddToSlots.invSpace11Name)) {
					AddToSlots.invSpace11Quan -= 1;
					if(AddToSlots.invSpace11Quan <= 0) {
						AddToSlots.invSpace11Empty = true;
						AddToSlots.invSpace11Full = false;
					}
				}
			}

			if((AddToSlots.invSpace12Empty == true) && (AddToSlots.invSpace12Full == false)) {
				GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*2), (boxTop + (85*3)), 75, 75), AddToSlots.invSpace12Name)) {
					AddToSlots.invSpace12Quan -= 1;
					if(AddToSlots.invSpace12Quan <= 0) {
						AddToSlots.invSpace12Empty = true;
						AddToSlots.invSpace12Full = false;
					}
				}
			}

			if((AddToSlots.invSpace13Empty == true) && (AddToSlots.invSpace13Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*0)), 75, 75), AddToSlots.invSpace13Name)) {
					AddToSlots.invSpace13Quan -= 1;
					if(AddToSlots.invSpace13Quan <= 0) {
						AddToSlots.invSpace13Empty = true;
						AddToSlots.invSpace13Full = false;
					}
				}
			}

			if((AddToSlots.invSpace14Empty == true) && (AddToSlots.invSpace14Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*1)), 75, 75), AddToSlots.invSpace14Name)) {
					AddToSlots.invSpace14Quan -= 1;
					if(AddToSlots.invSpace14Quan <= 0) {
						AddToSlots.invSpace14Empty = true;
						AddToSlots.invSpace14Full = false;
					}
				}
			}

			if((AddToSlots.invSpace15Empty == true) && (AddToSlots.invSpace15Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*2)), 75, 75), AddToSlots.invSpace15Name)) {
					AddToSlots.invSpace15Quan -= 1;
					if(AddToSlots.invSpace15Quan <= 0) {
						AddToSlots.invSpace15Empty = true;
						AddToSlots.invSpace15Full = false;
					}
				}
			}

			if((AddToSlots.invSpace16Empty == true) && (AddToSlots.invSpace16Full == false)) {
				GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*3), (boxTop + (85*3)), 75, 75), AddToSlots.invSpace16Name)) {
					AddToSlots.invSpace16Quan -= 1;
					if(AddToSlots.invSpace16Quan <= 0) {
						AddToSlots.invSpace16Empty = true;
						AddToSlots.invSpace16Full = false;
					}
				}
			}

			if((AddToSlots.invSpace17Empty == true) && (AddToSlots.invSpace17Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*0)), 75, 75), AddToSlots.invSpace17Name)) {
					AddToSlots.invSpace17Quan -= 1;
					if(AddToSlots.invSpace17Quan <= 0) {
						AddToSlots.invSpace17Empty = true;
						AddToSlots.invSpace17Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace18Empty == true) && (AddToSlots.invSpace18Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*1)), 75, 75), AddToSlots.invSpace18Name)) {
					AddToSlots.invSpace18Quan -= 1;
					if(AddToSlots.invSpace18Quan <= 0) {
						AddToSlots.invSpace18Empty = true;
						AddToSlots.invSpace18Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace19Empty == true) && (AddToSlots.invSpace19Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*2)), 75, 75), AddToSlots.invSpace19Name)) {
					AddToSlots.invSpace19Quan -= 1;
					if(AddToSlots.invSpace19Quan <= 0) {
						AddToSlots.invSpace19Empty = true;
						AddToSlots.invSpace19Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace20Empty == true) && (AddToSlots.invSpace20Full == false)) {
				GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*4), (boxTop + (85*3)), 75, 75), AddToSlots.invSpace20Name)) {
					AddToSlots.invSpace20Quan -= 1;
					if(AddToSlots.invSpace20Quan <= 0) {
						AddToSlots.invSpace20Empty = true;
						AddToSlots.invSpace20Full = false;
					}
				}
			}

			if((AddToSlots.invSpace21Empty == true) && (AddToSlots.invSpace21Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*0)), 75, 75), AddToSlots.invSpace21Name)) {
					AddToSlots.invSpace21Quan -= 1;
					if(AddToSlots.invSpace21Quan <= 0) {
						AddToSlots.invSpace21Empty = true;
						AddToSlots.invSpace21Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace22Empty == true) && (AddToSlots.invSpace22Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*1)), 75, 75), AddToSlots.invSpace22Name)) {
					AddToSlots.invSpace22Quan -= 1;
					if(AddToSlots.invSpace22Quan <= 0) {
						AddToSlots.invSpace22Empty = true;
						AddToSlots.invSpace22Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace23Empty == true) && (AddToSlots.invSpace23Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*2)), 75, 75), AddToSlots.invSpace23Name)) {
					AddToSlots.invSpace23Quan -= 1;
					if(AddToSlots.invSpace23Quan <= 0) {
						AddToSlots.invSpace23Empty = true;
						AddToSlots.invSpace23Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace24Empty == true) && (AddToSlots.invSpace24Full == false)) {
				GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (boxRight + (85*5), (boxTop + (85*3)), 75, 75), AddToSlots.invSpace24Name)) {
					AddToSlots.invSpace24Quan -= 1;
					if(AddToSlots.invSpace24Quan <= 0) {
						AddToSlots.invSpace24Empty = true;
						AddToSlots.invSpace24Full = false;
					}
				}
			}

			LockedInv (boxRight, boxTop);

			GUI.EndScrollView ();
			
			//Tool bar
			toolBarInt = GUI.Toolbar (toolBarRect, toolBarInt, toolBarString);
		}

		//Letters
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
			if((AddToSlots.equipSpace25Empty == true) && (AddToSlots.equipSpace25Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), AddToSlots.equipSpace25Name)) {
					AddToSlots.equipSpace25Quan -= 1;
					if(AddToSlots.equipSpace25Quan <= 0) {
						AddToSlots.equipSpace25Empty = true;
						AddToSlots.equipSpace25Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace26Empty == true) && (AddToSlots.equipSpace26Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), AddToSlots.equipSpace26Name)) {
					AddToSlots.equipSpace26Quan -= 1;
					if(AddToSlots.equipSpace26Quan <= 0) {
						AddToSlots.equipSpace26Empty = true;
						AddToSlots.equipSpace26Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace27Empty == true) && (AddToSlots.equipSpace27Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), AddToSlots.equipSpace27Name)) {
					AddToSlots.equipSpace27Quan -= 1;
					if(AddToSlots.equipSpace27Quan <= 0) {
						AddToSlots.equipSpace27Empty = true;
						AddToSlots.equipSpace27Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace28Empty == true) && (AddToSlots.equipSpace28Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), AddToSlots.equipSpace28Name)) {
					AddToSlots.equipSpace28Quan -= 1;
					if(AddToSlots.equipSpace28Quan <= 0) {
						AddToSlots.equipSpace28Empty = true;
						AddToSlots.equipSpace28Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Locked");
		}


		if (unlockNextEquip >= 2) {
			if((AddToSlots.equipSpace29Empty == true) && (AddToSlots.equipSpace29Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), AddToSlots.equipSpace29Name)) {
					AddToSlots.equipSpace29Quan -= 1;
					if(AddToSlots.equipSpace29Quan <= 0) {
						AddToSlots.equipSpace29Empty = true;
						AddToSlots.equipSpace29Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace30Empty == true) && (AddToSlots.equipSpace30Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), AddToSlots.equipSpace30Name)) {
					AddToSlots.equipSpace30Quan -= 1;
					if(AddToSlots.equipSpace30Quan <= 0) {
						AddToSlots.equipSpace30Empty = true;
						AddToSlots.equipSpace30Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace31Empty == true) && (AddToSlots.equipSpace31Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), AddToSlots.equipSpace31Name)) {
					AddToSlots.equipSpace31Quan -= 1;
					if(AddToSlots.equipSpace31Quan <= 0) {
						AddToSlots.equipSpace31Empty = true;
						AddToSlots.equipSpace31Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace32Empty == true) && (AddToSlots.equipSpace32Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), AddToSlots.equipSpace32Name)) {
					AddToSlots.equipSpace32Quan -= 1;
					if(AddToSlots.equipSpace32Quan <= 0) {
						AddToSlots.equipSpace32Empty = true;
						AddToSlots.equipSpace32Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 3) {
			if((AddToSlots.equipSpace33Empty == true) && (AddToSlots.equipSpace33Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), AddToSlots.equipSpace33Name)) {
					AddToSlots.equipSpace33Quan -= 1;
					if(AddToSlots.equipSpace33Quan <= 0) {
						AddToSlots.equipSpace33Empty = true;
						AddToSlots.equipSpace33Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace34Empty == true) && (AddToSlots.equipSpace34Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), AddToSlots.equipSpace34Name)) {
					AddToSlots.equipSpace34Quan -= 1;
					if(AddToSlots.equipSpace34Quan <= 0) {
						AddToSlots.equipSpace34Empty = true;
						AddToSlots.equipSpace34Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace35Empty == true) && (AddToSlots.equipSpace35Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), AddToSlots.equipSpace35Name)) {
					AddToSlots.equipSpace35Quan -= 1;
					if(AddToSlots.equipSpace35Quan <= 0) {
						AddToSlots.equipSpace35Empty = true;
						AddToSlots.equipSpace35Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace36Empty == true) && (AddToSlots.equipSpace36Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), AddToSlots.equipSpace36Name)) {
					AddToSlots.equipSpace36Quan -= 1;
					if(AddToSlots.equipSpace36Quan <= 0) {
						AddToSlots.equipSpace36Empty = true;
						AddToSlots.equipSpace36Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 4) {
			if((AddToSlots.equipSpace37Empty == true) && (AddToSlots.equipSpace37Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), AddToSlots.equipSpace37Name)) {
					AddToSlots.equipSpace37Quan -= 1;
					if(AddToSlots.equipSpace37Quan <= 0) {
						AddToSlots.equipSpace37Empty = true;
						AddToSlots.equipSpace37Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace38Empty == true) && (AddToSlots.equipSpace38Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), AddToSlots.equipSpace38Name)) {
					AddToSlots.equipSpace38Quan -= 1;
					if(AddToSlots.equipSpace38Quan <= 0) {
						AddToSlots.equipSpace38Empty = true;
						AddToSlots.equipSpace38Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace39Empty == true) && (AddToSlots.equipSpace39Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), AddToSlots.equipSpace39Name)) {
					AddToSlots.equipSpace39Quan -= 1;
					if(AddToSlots.equipSpace39Quan <= 0) {
						AddToSlots.equipSpace39Empty = true;
						AddToSlots.equipSpace39Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace40Empty == true) && (AddToSlots.equipSpace40Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), AddToSlots.equipSpace40Name)) {
					AddToSlots.equipSpace40Quan -= 1;
					if(AddToSlots.equipSpace40Quan <= 0) {
						AddToSlots.equipSpace40Empty = true;
						AddToSlots.equipSpace40Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 5) {
			if((AddToSlots.equipSpace41Empty == true) && (AddToSlots.equipSpace41Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), AddToSlots.equipSpace41Name)) {
					AddToSlots.equipSpace41Quan -= 1;
					if(AddToSlots.equipSpace41Quan <= 0) {
						AddToSlots.equipSpace41Empty = true;
						AddToSlots.equipSpace41Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace42Empty == true) && (AddToSlots.equipSpace42Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), AddToSlots.equipSpace42Name)) {
					AddToSlots.equipSpace42Quan -= 1;
					if(AddToSlots.equipSpace42Quan <= 0) {
						AddToSlots.equipSpace42Empty = true;
						AddToSlots.equipSpace42Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace43Empty == true) && (AddToSlots.equipSpace43Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), AddToSlots.equipSpace43Name)) {
					AddToSlots.equipSpace43Quan -= 1;
					if(AddToSlots.equipSpace43Quan <= 0) {
						AddToSlots.equipSpace43Empty = true;
						AddToSlots.equipSpace43Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace44Empty == true) && (AddToSlots.equipSpace44Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), AddToSlots.equipSpace44Name)) {
					AddToSlots.equipSpace44Quan -= 1;
					if(AddToSlots.equipSpace44Quan <= 0) {
						AddToSlots.equipSpace44Empty = true;
						AddToSlots.equipSpace44Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 6) {
			if((AddToSlots.equipSpace45Empty == true) && (AddToSlots.equipSpace45Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), AddToSlots.equipSpace45Name)) {
					AddToSlots.equipSpace45Quan -= 1;
					if(AddToSlots.equipSpace45Quan <= 0) {
						AddToSlots.equipSpace45Empty = true;
						AddToSlots.equipSpace45Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace46Empty == true) && (AddToSlots.equipSpace46Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), AddToSlots.equipSpace46Name)) {
					AddToSlots.equipSpace46Quan -= 1;
					if(AddToSlots.equipSpace46Quan <= 0) {
						AddToSlots.equipSpace46Empty = true;
						AddToSlots.equipSpace46Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace47Empty == true) && (AddToSlots.equipSpace47Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), AddToSlots.equipSpace47Name)) {
					AddToSlots.equipSpace47Quan -= 1;
					if(AddToSlots.equipSpace47Quan <= 0) {
						AddToSlots.equipSpace47Empty = true;
						AddToSlots.equipSpace47Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace48Empty == true) && (AddToSlots.equipSpace48Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), AddToSlots.equipSpace48Name)) {
					AddToSlots.equipSpace48Quan -= 1;
					if(AddToSlots.equipSpace48Quan <= 0) {
						AddToSlots.equipSpace48Empty = true;
						AddToSlots.equipSpace48Full = false;
					}
				}
			}

		} else {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Locked");
		}

		if (unlockNextEquip >= 7) {
			if((AddToSlots.equipSpace49Empty == true) && (AddToSlots.equipSpace49Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), AddToSlots.equipSpace49Name)) {
					AddToSlots.equipSpace49Quan -= 1;
					if(AddToSlots.equipSpace49Quan <= 0) {
						AddToSlots.equipSpace49Empty = true;
						AddToSlots.equipSpace49Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace50Empty == true) && (AddToSlots.equipSpace50Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), AddToSlots.equipSpace50Name)) {
					AddToSlots.equipSpace50Quan -= 1;
					if(AddToSlots.equipSpace50Quan <= 0) {
						AddToSlots.equipSpace50Empty = true;
						AddToSlots.equipSpace50Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace51Empty == true) && (AddToSlots.equipSpace51Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), AddToSlots.equipSpace51Name)) {
					AddToSlots.equipSpace51Quan -= 1;
					if(AddToSlots.equipSpace51Quan <= 0) {
						AddToSlots.equipSpace51Empty = true;
						AddToSlots.equipSpace51Full = false;
					}
				}
			}

			if((AddToSlots.equipSpace52Empty == true) && (AddToSlots.equipSpace52Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), AddToSlots.equipSpace52Name)) {
					AddToSlots.equipSpace52Quan -= 1;
					if(AddToSlots.equipSpace52Quan <= 0) {
						AddToSlots.equipSpace52Empty = true;
						AddToSlots.equipSpace52Full = false;
					}
				}
			}

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
			if((AddToSlots.invSpace25Empty == true) && (AddToSlots.invSpace25Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), AddToSlots.invSpace25Name)) {
					AddToSlots.invSpace25Quan -= 1;
					if(AddToSlots.invSpace25Quan <= 0) {
						AddToSlots.invSpace25Empty = true;
						AddToSlots.invSpace25Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace26Empty == true) && (AddToSlots.invSpace26Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), AddToSlots.invSpace26Name)) {
					AddToSlots.invSpace26Quan -= 1;
					if(AddToSlots.invSpace26Quan <= 0) {
						AddToSlots.invSpace26Empty = true;
						AddToSlots.invSpace26Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace27Empty == true) && (AddToSlots.invSpace27Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), AddToSlots.invSpace27Name)) {
					AddToSlots.invSpace27Quan -= 1;
					if(AddToSlots.invSpace27Quan <= 0) {
						AddToSlots.invSpace27Empty = true;
						AddToSlots.invSpace27Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace28Empty == true) && (AddToSlots.invSpace28Full == false)) {
				GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), AddToSlots.invSpace28Name)) {
					AddToSlots.invSpace28Quan -= 1;
					if(AddToSlots.invSpace28Quan <= 0) {
						AddToSlots.invSpace28Empty = true;
						AddToSlots.invSpace28Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*6), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*6), (top + (85*3)), 75, 75), "Locked");
		}
		
		
		if (unlockNextInv >= 2) {
			if((AddToSlots.invSpace29Empty == true) && (AddToSlots.invSpace29Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), AddToSlots.invSpace29Name)) {
					AddToSlots.invSpace29Quan -= 1;
					if(AddToSlots.invSpace29Quan <= 0) {
						AddToSlots.invSpace29Empty = true;
						AddToSlots.invSpace29Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace30Empty == true) && (AddToSlots.invSpace30Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), AddToSlots.invSpace30Name)) {
					AddToSlots.invSpace30Quan -= 1;
					if(AddToSlots.invSpace30Quan <= 0) {
						AddToSlots.invSpace30Empty = true;
						AddToSlots.invSpace30Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace31Empty == true) && (AddToSlots.invSpace31Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), AddToSlots.invSpace31Name)) {
					AddToSlots.invSpace31Quan -= 1;
					if(AddToSlots.invSpace31Quan <= 0) {
						AddToSlots.invSpace31Empty = true;
						AddToSlots.invSpace31Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace32Empty == true) && (AddToSlots.invSpace32Full == false)) {
				GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), AddToSlots.invSpace32Name)) {
					AddToSlots.invSpace32Quan -= 1;
					if(AddToSlots.invSpace32Quan <= 0) {
						AddToSlots.invSpace32Empty = true;
						AddToSlots.invSpace32Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*7), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*7), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 3) {
			if((AddToSlots.invSpace33Empty == true) && (AddToSlots.invSpace33Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), AddToSlots.invSpace33Name)) {
					AddToSlots.invSpace33Quan -= 1;
					if(AddToSlots.invSpace33Quan <= 0) {
						AddToSlots.invSpace33Empty = true;
						AddToSlots.invSpace33Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace34Empty == true) && (AddToSlots.invSpace34Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), AddToSlots.invSpace34Name)) {
					AddToSlots.invSpace34Quan -= 1;
					if(AddToSlots.invSpace34Quan <= 0) {
						AddToSlots.invSpace34Empty = true;
						AddToSlots.invSpace34Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace35Empty == true) && (AddToSlots.invSpace35Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), AddToSlots.invSpace35Name)) {
					AddToSlots.invSpace35Quan -= 1;
					if(AddToSlots.invSpace35Quan <= 0) {
						AddToSlots.invSpace35Empty = true;
						AddToSlots.invSpace35Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace36Empty == true) && (AddToSlots.invSpace36Full == false)) {
				GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), AddToSlots.invSpace36Name)) {
					AddToSlots.invSpace36Quan -= 1;
					if(AddToSlots.invSpace36Quan <= 0) {
						AddToSlots.invSpace36Empty = true;
						AddToSlots.invSpace36Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*8), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*8), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 4) {
			if((AddToSlots.invSpace37Empty == true) && (AddToSlots.invSpace37Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), AddToSlots.invSpace37Name)) {
					AddToSlots.invSpace37Quan -= 1;
					if(AddToSlots.invSpace37Quan <= 0) {
						AddToSlots.invSpace37Empty = true;
						AddToSlots.invSpace37Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace38Empty == true) && (AddToSlots.invSpace38Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), AddToSlots.invSpace38Name)) {
					AddToSlots.invSpace38Quan -= 1;
					if(AddToSlots.invSpace38Quan <= 0) {
						AddToSlots.invSpace38Empty = true;
						AddToSlots.invSpace38Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace39Empty == true) && (AddToSlots.invSpace39Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), AddToSlots.invSpace39Name)) {
					AddToSlots.invSpace39Quan -= 1;
					if(AddToSlots.invSpace39Quan <= 0) {
						AddToSlots.invSpace39Empty = true;
						AddToSlots.invSpace39Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace40Empty == true) && (AddToSlots.invSpace40Full == false)) {
				GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), AddToSlots.invSpace40Name)) {
					AddToSlots.invSpace40Quan -= 1;
					if(AddToSlots.invSpace40Quan <= 0) {
						AddToSlots.invSpace40Empty = true;
						AddToSlots.invSpace40Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*9), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*9), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 5) {
			if((AddToSlots.invSpace41Empty == true) && (AddToSlots.invSpace41Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), AddToSlots.invSpace41Name)) {
					AddToSlots.invSpace41Quan -= 1;
					if(AddToSlots.invSpace41Quan <= 0) {
						AddToSlots.invSpace41Empty = true;
						AddToSlots.invSpace41Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace42Empty == true) && (AddToSlots.invSpace42Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), AddToSlots.invSpace42Name)) {
					AddToSlots.invSpace42Quan -= 1;
					if(AddToSlots.invSpace42Quan <= 0) {
						AddToSlots.invSpace42Empty = true;
						AddToSlots.invSpace42Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace43Empty == true) && (AddToSlots.invSpace43Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), AddToSlots.invSpace43Name)) {
					AddToSlots.invSpace43Quan -= 1;
					if(AddToSlots.invSpace43Quan <= 0) {
						AddToSlots.invSpace43Empty = true;
						AddToSlots.invSpace43Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace44Empty == true) && (AddToSlots.invSpace44Full == false)) {
				GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), AddToSlots.invSpace44Name)) {
					AddToSlots.invSpace44Quan -= 1;
					if(AddToSlots.invSpace44Quan <= 0) {
						AddToSlots.invSpace44Empty = true;
						AddToSlots.invSpace44Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*10), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*10), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 6) {
			if((AddToSlots.invSpace45Empty == true) && (AddToSlots.invSpace45Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), AddToSlots.invSpace45Name)) {
					AddToSlots.invSpace45Quan -= 1;
					if(AddToSlots.invSpace45Quan <= 0) {
						AddToSlots.invSpace45Empty = true;
						AddToSlots.invSpace45Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace46Empty == true) && (AddToSlots.invSpace46Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), AddToSlots.invSpace46Name)) {
					AddToSlots.invSpace46Quan -= 1;
					if(AddToSlots.invSpace46Quan <= 0) {
						AddToSlots.invSpace46Empty = true;
						AddToSlots.invSpace46Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace47Empty == true) && (AddToSlots.invSpace47Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), AddToSlots.invSpace47Name)) {
					AddToSlots.invSpace47Quan -= 1;
					if(AddToSlots.invSpace47Quan <= 0) {
						AddToSlots.invSpace47Empty = true;
						AddToSlots.invSpace47Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace48Empty == true) && (AddToSlots.invSpace48Full == false)) {
				GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), AddToSlots.invSpace48Name)) {
					AddToSlots.invSpace48Quan -= 1;
					if(AddToSlots.invSpace48Quan <= 0) {
						AddToSlots.invSpace48Empty = true;
						AddToSlots.invSpace48Full = false;
					}
				}
			}
		} else {
			GUI.Button (new Rect (right + (85*11), (top + (85*0)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*1)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*2)), 75, 75), "Locked");
			GUI.Button (new Rect (right + (85*11), (top + (85*3)), 75, 75), "Locked");
		}
		
		if (unlockNextInv >= 7) {
			if((AddToSlots.invSpace49Empty == true) && (AddToSlots.invSpace49Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*0)), 75, 75), AddToSlots.invSpace49Name)) {
					AddToSlots.invSpace49Quan -= 1;
					if(AddToSlots.invSpace49Quan <= 0) {
						AddToSlots.invSpace49Empty = true;
						AddToSlots.invSpace49Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace50Empty == true) && (AddToSlots.invSpace50Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*1)), 75, 75), AddToSlots.invSpace50Name)) {
					AddToSlots.invSpace50Quan -= 1;
					if(AddToSlots.invSpace50Quan <= 0) {
						AddToSlots.invSpace50Empty = true;
						AddToSlots.invSpace50Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace51Empty == true) && (AddToSlots.invSpace51Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*2)), 75, 75), AddToSlots.invSpace51Name)) {
					AddToSlots.invSpace51Quan -= 1;
					if(AddToSlots.invSpace51Quan <= 0) {
						AddToSlots.invSpace51Empty = true;
						AddToSlots.invSpace51Full = false;
					}
				}
			}
			
			if((AddToSlots.invSpace52Empty == true) && (AddToSlots.invSpace52Full == false)) {
				GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), "Empty");
			} else {
				if(GUI.Button (new Rect (right + (85*12), (top + (85*3)), 75, 75), AddToSlots.invSpace52Name)) {
					AddToSlots.invSpace52Quan -= 1;
					if(AddToSlots.invSpace52Quan <= 0) {
						AddToSlots.invSpace52Empty = true;
						AddToSlots.invSpace52Full = false;
					}
				}
			}
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
