using UnityEngine;
using System.Collections;
using System.IO;

public class MyHearts : MonoBehaviour {

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);

	public static bool saving = false;
	public static bool loading = false;

	int toolBarInt = 0;
	
	string filePath;
	string filename;

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

	int aBPQuan;
	int phereQuan;
	int bBPQuan;
	int loveMolQuan;
	int abBPQuan;
	int loveDustQuan;
	int ONegQuan;
	int lovePotQuan;
	int hPumpQuan;
	int aKissQuan;
	int adrenQuan;
	int nutPillQuan;
	int rageQuan;
	int fKissQuan;
	int epinPillQuan;
	int hArmorQuan;
	int pKissQuan;
	int lArmorQuan;
	int lossSetQuan;
	int lossInvQuan;
	int remSetQuan;
	int remInvQuan;
	int sadSetQuan;
	int sadInvQuan;
	int bitSetQuan;
	int bitInvQuan;
	int sorSetQuan;
	int sorInvQuan;
	int loneSetQuan;
	int loneInvQuan;
	int misSetQuan;
	int misInvQuan;
	int longSetQuan;
	int longInvQuan;
	int needSetQuan;
	int needInvQuan;
	int disSetQuan;
	int disInvQuan;
	int gladSetQuan;
	int gladInvQuan;
	int happSetQuan;
	int happInvQuan;
	int hopeSetQuan;
	int hopeInvQuan;
	int attSetQuan;
	int attInvQuan;
	int hostSetQuan;
	int hostInvQuan;
	int rageWepSetQuan;
	int rageWepInvQuan;
	int passSetQuan;
	int passInvQuan;
	int triSetQuan;
	int triInvQuan;
	int sandSetQuan;
	int sandInvQuan;
	int leaGlovesSetQuan;
	int leaGlovesInvQuan;
	int leaStrapSetQuan;
	int leaStrapInvQuan;
	int bronShoesSetQuan;
	int bronShoesInvQuan;
	int bronGlovesSetQuan;
	int bronGlovesInvQuan;
	int bronStrapSetQuan;
	int bronStrapInvQuan;
	int ironShoesSetQuan;
	int ironShoesInvQuan;
	int ironGlovesSetQuan;
	int ironGlovesInvQuan;
	int ironStrapSetQuan;
	int ironStrapInvQuan;
	int steelShoesSetQuan;
	int steelShoesInvQuan;
	int steelGlovesSetQuan;
	int steelGlovesInvQuan;
	int steelStrapSetQuan;
	int steelStrapInvQuan;
	int bloodShoesSetQuan;
	int bloodShoesInvQuan;
	int bloodGlovesSetQuan;
	int bloodGlovesInvQuan;
	int bloodStrapSetQuan;
	int bloodStrapInvQuan;
	int loveShoesSetQuan;
	int loveShoesInvQuan;
	int loveGlovesSetQuan;
	int loveGlovesInvQuan;
	int loveStrapSetQuan;
	int loveStrapInvQuan;
	int uesSetQuan;
	int uesInvQuan;
	int uisSetQuan;
	int uisInvQuan;
	int incLv1SetQuan;
	int incLv1InvQuan;
	int incLv2SetQuan;
	int incLv2InvQuan;
	int incLv3SetQuan;
	int incLv3InvQuan;
	int incLv4SetQuan;
	int incLv4InvQuan;
	int incB1SetQuan;
	int incB1InvQuan;
	int incB2SetQuan;
	int incB2InvQuan;
	int incL1SetQuan;
	int incL1InvQuan;
	int incL2SetQuan;
	int incL2InvQuan;
	int incStr1SetQuan;
	int incStr1InvQuan;
	int incStr2SetQuan;
	int incStr2InvQuan;
	int incInt1SetQuan;
	int incInt1InvQuan;
	int incInt2SetQuan;
	int incInt2InvQuan;
	int incDex1SetQuan;
	int incDex1InvQuan;
	int incDex2SetQuan;
	int incDex2InvQuan;
	int incLuk1SetQuan;
	int incLuk1InvQuan;
	int incLuk2SetQuan;
	int incLuk2InvQuan;

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

			filename = "Heart 1";
			filePath = "/Database/Heart1.txt";
			CheckFile(screenMid, screenTop, width, height, filePath, filename);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")){
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
						GatherInfo();
						StoreInfo (writeFile);	
					}
				}
			}
			if(GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete")){
				using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
					writeFile.WriteLine("Empty");
					writeFile.Close ();
				}
			}
		}

		if (toolBarInt == 1) {

			filename = "Heart 2";
			filePath = "/Database/Heart2.txt";
			CheckFile(screenMid, screenTop, width, height, filePath, filename);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
						GatherInfo();
						StoreInfo (writeFile);
					}
				}
			}
			if(GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete")){
				using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
					writeFile.WriteLine("Empty");
					writeFile.Close ();
				}
			}
		}

		if (toolBarInt == 2) {

			filename = "Heart 3";
			filePath = "/Database/Heart3.txt";
			CheckFile(screenMid, screenTop, width, height, filePath, filename);
			if(saving) {
				if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Save")) {
					using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
						GatherInfo();
						StoreInfo (writeFile);
					}
				}
			}
			if(GUI.Button (new Rect ((screenMid / 2) + 300, (screenTop + 200) + 190, width + 100, height / 2), "Delete")){
				using (StreamWriter writeFile = new StreamWriter (Application.dataPath + filePath)) {
					writeFile.WriteLine("Empty");
					writeFile.Close ();
				}
			}
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

	void CheckFile(float screenMid, float screenTop, int width, int height, string thePath, string name) {
		using (StreamReader readFile = new StreamReader (Application.dataPath + thePath)) {
			string[] fileInfo = File.ReadAllLines (Application.dataPath + thePath);

			GUI.Box (new Rect (screenMid / 2, screenTop + 75, screenMid - 15, windowRec.height - 155), name);
			if (fileInfo.Length > 1) {
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
				if(loading){
					if(GUI.Button (new Rect ((screenMid / 2) + 80, (screenTop + 200) + 190, width + 100, height / 2), "Continue")) {
						LoadInfo();
						Application.LoadLevel (1);
					}
				}
			} else {
				GUI.Label (new Rect ((screenMid / 2) + 220, (screenTop + 75) + 140, width + 100, height / 2), "This is an Empty Slot");
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

		aBPQuan = GameItemStorage.aBPQuan;
		phereQuan = GameItemStorage.phereQuan;
		bBPQuan = GameItemStorage.bBPQuan;
		loveMolQuan = GameItemStorage.loveMolQuan;
		abBPQuan = GameItemStorage.abBPQuan;
		loveDustQuan = GameItemStorage.loveDustQuan;
		ONegQuan = GameItemStorage.ONegQuan;
		lovePotQuan = GameItemStorage.lovePotQuan;
		hPumpQuan = GameItemStorage.hPumpQuan;
		aKissQuan = GameItemStorage.aKissQuan;
		adrenQuan = GameItemStorage.adrenQuan;
		nutPillQuan = GameItemStorage.nutPillQuan;
		rageQuan = GameItemStorage.rageQuan;
		fKissQuan = GameItemStorage.fKissQuan;
		epinPillQuan = GameItemStorage.epinPillQuan;
		hArmorQuan = GameItemStorage.hArmorQuan;
		pKissQuan = GameItemStorage.pKissQuan;
		lArmorQuan = GameItemStorage.lArmorQuan;

		lossSetQuan = GameItemStorage.lossSetQuan;
		lossInvQuan = GameItemStorage.lossInvQuan;

		remSetQuan = GameItemStorage.remSetQuan;
		remInvQuan = GameItemStorage.remInvQuan;

		sadSetQuan = GameItemStorage.sadSetQuan;
		sadInvQuan = GameItemStorage.sadInvQuan;

		bitSetQuan = GameItemStorage.bitSetQuan;
		bitInvQuan = GameItemStorage.bitInvQuan;

		sorSetQuan = GameItemStorage.sorSetQuan;
		sorInvQuan = GameItemStorage.sorInvQuan;

		loneSetQuan = GameItemStorage.loneSetQuan;
		loneInvQuan = GameItemStorage.loneInvQuan;

		misSetQuan = GameItemStorage.misSetQuan;
		misInvQuan = GameItemStorage.misInvQuan;

		longSetQuan = GameItemStorage.longSetQuan;
		longInvQuan = GameItemStorage.longInvQuan;

		needSetQuan = GameItemStorage.needSetQuan;
		needInvQuan = GameItemStorage.needInvQuan;

		disSetQuan = GameItemStorage.disSetQuan;
		disInvQuan = GameItemStorage.disInvQuan;

		gladSetQuan = GameItemStorage.gladSetQuan;
		gladInvQuan = GameItemStorage.gladInvQuan;

		happSetQuan = GameItemStorage.happSetQuan;
		happInvQuan = GameItemStorage.happInvQuan;

		hopeSetQuan = GameItemStorage.hopeSetQuan;
		hopeInvQuan = GameItemStorage.hopeInvQuan;

		attSetQuan = GameItemStorage.attSetQuan;
		attInvQuan = GameItemStorage.attInvQuan;

		hostSetQuan = GameItemStorage.hostSetQuan;
		hostInvQuan = GameItemStorage.hostInvQuan;

		rageWepSetQuan = GameItemStorage.rageWepSetQuan;
		rageWepInvQuan = GameItemStorage.rageWepInvQuan;

		passSetQuan = GameItemStorage.passSetQuan;
		passInvQuan = GameItemStorage.passInvQuan;

		triSetQuan = GameItemStorage.triSetQuan;
		triInvQuan = GameItemStorage.triInvQuan;

		sandSetQuan = GameItemStorage.sandSetQuan;
		sandInvQuan = GameItemStorage.sandInvQuan;

		leaGlovesSetQuan = GameItemStorage.leaGlovesSetQuan;
		leaGlovesInvQuan = GameItemStorage.leaGlovesInvQuan;

		leaStrapSetQuan = GameItemStorage.leaStrapSetQuan;
		leaStrapInvQuan = GameItemStorage.leaStrapInvQuan;

		bronShoesSetQuan = GameItemStorage.bronShoesSetQuan;
		bronShoesInvQuan = GameItemStorage.bronShoesInvQuan;

		bronGlovesSetQuan = GameItemStorage.bronGlovesSetQuan;
		bronGlovesInvQuan = GameItemStorage.bronGlovesInvQuan;

		bronStrapSetQuan = GameItemStorage.bronStrapSetQuan;
		bronStrapInvQuan = GameItemStorage.bronStrapInvQuan;

		ironShoesSetQuan = GameItemStorage.ironShoesSetQuan;
		ironShoesInvQuan = GameItemStorage.ironShoesInvQuan;

		ironGlovesSetQuan = GameItemStorage.ironGlovesSetQuan;
		ironGlovesInvQuan = GameItemStorage.ironGlovesInvQuan;

		ironStrapSetQuan = GameItemStorage.ironStrapSetQuan;
		ironStrapInvQuan = GameItemStorage.ironStrapInvQuan;

		steelShoesSetQuan = GameItemStorage.steelShoesSetQuan;
		steelShoesInvQuan = GameItemStorage.steelShoesInvQuan;

		steelGlovesSetQuan = GameItemStorage.steelGlovesSetQuan;
		steelGlovesInvQuan = GameItemStorage.steelGlovesInvQuan;

		steelStrapSetQuan = GameItemStorage.steelStrapSetQuan;
		steelStrapInvQuan = GameItemStorage.steelStrapInvQuan;

		bloodShoesSetQuan = GameItemStorage.bloodShoesSetQuan;
		bloodShoesInvQuan = GameItemStorage.bloodShoesInvQuan;

		bloodGlovesSetQuan = GameItemStorage.bloodGlovesSetQuan;
		bloodGlovesInvQuan = GameItemStorage.bloodGlovesInvQuan;

		bloodStrapSetQuan = GameItemStorage.bloodStrapSetQuan;
		bloodStrapInvQuan = GameItemStorage.bloodStrapInvQuan;

		loveShoesSetQuan = GameItemStorage.loveShoesSetQuan;
		loveShoesInvQuan = GameItemStorage.loveShoesInvQuan;

		loveGlovesSetQuan = GameItemStorage.loveGlovesSetQuan;
		loveGlovesInvQuan = GameItemStorage.loveGlovesInvQuan;

		loveStrapSetQuan = GameItemStorage.loveStrapSetQuan;
		loveStrapInvQuan = GameItemStorage.loveStrapInvQuan;

		uesSetQuan = GameItemStorage.uesSetQuan;
		uesInvQuan = GameItemStorage.uesInvQuan;

		uisSetQuan = GameItemStorage.uisSetQuan;
		uisInvQuan = GameItemStorage.uisInvQuan;

		incLv1SetQuan = GameItemStorage.incLv1SetQuan;
		incLv1InvQuan = GameItemStorage.incLv1InvQuan;

		incLv2SetQuan = GameItemStorage.incLv2SetQuan;
		incLv2InvQuan = GameItemStorage.incLv2InvQuan;

		incLv3SetQuan = GameItemStorage.incLv3SetQuan;
		incLv3InvQuan = GameItemStorage.incLv3InvQuan;

		incLv4SetQuan = GameItemStorage.incLv4SetQuan;
		incLv4InvQuan = GameItemStorage.incLv4InvQuan;

		incB1SetQuan = GameItemStorage.incB1SetQuan;
		incB1InvQuan = GameItemStorage.incB1InvQuan;

		incB2SetQuan = GameItemStorage.incB2SetQuan;
		incB2InvQuan = GameItemStorage.incB2InvQuan;

		incL1SetQuan = GameItemStorage.incL1SetQuan;
		incL1InvQuan = GameItemStorage.incL1InvQuan;

		incL2SetQuan = GameItemStorage.incL2SetQuan;
		incL2InvQuan = GameItemStorage.incL2InvQuan;

		incStr1SetQuan = GameItemStorage.incStr1SetQuan;
		incStr1InvQuan = GameItemStorage.incStr1InvQuan;

		incStr2SetQuan = GameItemStorage.incStr2SetQuan;
		incStr2InvQuan = GameItemStorage.incStr2InvQuan;

		incInt1SetQuan = GameItemStorage.incInt1SetQuan;
		incInt1InvQuan = GameItemStorage.incInt1InvQuan;

		incInt2SetQuan = GameItemStorage.incInt2SetQuan;
		incInt2InvQuan = GameItemStorage.incInt2InvQuan;

		incDex1SetQuan = GameItemStorage.incDex2SetQuan;
		incDex1InvQuan = GameItemStorage.incDex1InvQuan;

		incDex2SetQuan = GameItemStorage.incDex2SetQuan;
		incDex2InvQuan = GameItemStorage.incDex2InvQuan;

		incLuk1SetQuan = GameItemStorage.incLuk1SetQuan;
		incLuk1InvQuan = GameItemStorage.incLuk1InvQuan;

		incLuk2SetQuan = GameItemStorage.incLuk2SetQuan;
		incLuk2InvQuan = GameItemStorage.incLuk2InvQuan;
	}
	
	void ReadInfo(){

		if (toolBarInt == 0) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart1.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart1.txt");
				if(fileInfo.Length > 1) {
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
						aBPQuan = int.Parse (fileInfo [i + 52]);
						phereQuan = int.Parse (fileInfo [i + 53]);
						bBPQuan = int.Parse (fileInfo [i + 54]);
						loveMolQuan = int.Parse (fileInfo [i + 55]);
						abBPQuan = int.Parse (fileInfo [i + 56]);
						loveDustQuan = int.Parse (fileInfo [i + 57]);
						ONegQuan = int.Parse (fileInfo [i + 58]);
						lovePotQuan = int.Parse (fileInfo [i + 59]);
						hPumpQuan = int.Parse (fileInfo [i + 60]);
						aKissQuan = int.Parse (fileInfo [i + 61]);
						adrenQuan = int.Parse (fileInfo [i + 62]);
						nutPillQuan = int.Parse (fileInfo [i + 63]);
						rageQuan = int.Parse (fileInfo [i + 64]);
						fKissQuan = int.Parse (fileInfo [i + 65]);
						epinPillQuan = int.Parse (fileInfo [i + 66]);
						hArmorQuan = int.Parse (fileInfo [i + 67]);
						pKissQuan = int.Parse (fileInfo [i + 68]);
						lArmorQuan = int.Parse (fileInfo [i + 69]);
						lossSetQuan = int.Parse (fileInfo [i + 70]);
						lossInvQuan = int.Parse (fileInfo [i + 71]);
						remSetQuan = int.Parse (fileInfo [i + 72]);
						remInvQuan = int.Parse (fileInfo [i + 73]);
						sadSetQuan = int.Parse (fileInfo [i + 74]);
						sadInvQuan = int.Parse (fileInfo [i + 75]);
						bitSetQuan = int.Parse (fileInfo [i + 76]);
						bitInvQuan = int.Parse (fileInfo [i + 77]);
						sorSetQuan = int.Parse (fileInfo [i + 78]);
						sorInvQuan = int.Parse (fileInfo [i + 79]);
						loneSetQuan = int.Parse (fileInfo [i + 80]);
						loneInvQuan = int.Parse (fileInfo [i + 81]);
						misSetQuan = int.Parse (fileInfo [i + 82]);
						misInvQuan = int.Parse (fileInfo [i + 83]);
						longSetQuan = int.Parse (fileInfo [i + 84]);
						longInvQuan = int.Parse (fileInfo [i + 85]);
						needSetQuan = int.Parse (fileInfo [i + 86]);
						needInvQuan = int.Parse (fileInfo [i + 87]);
						disSetQuan = int.Parse (fileInfo [i + 88]);
						disInvQuan = int.Parse (fileInfo [i + 89]);
						gladSetQuan = int.Parse (fileInfo [i + 90]);
						gladInvQuan = int.Parse (fileInfo [i + 91]);
						happSetQuan = int.Parse (fileInfo [i + 92]);
						happInvQuan = int.Parse (fileInfo [i + 93]);
						hopeSetQuan = int.Parse (fileInfo [i + 94]);
						hopeInvQuan = int.Parse (fileInfo [i + 95]);
						attSetQuan = int.Parse (fileInfo [i + 96]);
						attInvQuan = int.Parse (fileInfo [i + 97]);
						hostSetQuan = int.Parse (fileInfo [i + 98]);
						hostInvQuan = int.Parse (fileInfo [i + 99]);
						rageWepSetQuan = int.Parse (fileInfo [i + 100]);
						rageWepInvQuan = int.Parse (fileInfo [i + 101]);
						passSetQuan = int.Parse (fileInfo [i + 102]);
						passInvQuan = int.Parse (fileInfo [i + 103]);
						triSetQuan = int.Parse (fileInfo [i + 104]);
						triInvQuan = int.Parse (fileInfo [i + 105]);
						sandSetQuan = int.Parse (fileInfo [i + 106]);
						sandInvQuan = int.Parse (fileInfo [i + 107]);
						leaGlovesSetQuan = int.Parse (fileInfo [i + 108]);
						leaGlovesInvQuan = int.Parse (fileInfo [i + 109]);
						leaStrapSetQuan = int.Parse (fileInfo [i + 110]);
						leaStrapInvQuan = int.Parse (fileInfo [i + 111]);
						bronShoesSetQuan = int.Parse (fileInfo [i + 112]);
						bronShoesInvQuan = int.Parse (fileInfo [i + 113]);
						bronGlovesSetQuan = int.Parse (fileInfo [i + 114]);
						bronGlovesInvQuan = int.Parse (fileInfo [i + 115]);
						bronStrapSetQuan = int.Parse (fileInfo [i + 116]);
						bronStrapInvQuan = int.Parse (fileInfo [i + 117]);
						ironShoesSetQuan = int.Parse (fileInfo [i + 118]);
						ironShoesInvQuan = int.Parse (fileInfo [i + 119]);
						ironGlovesSetQuan = int.Parse (fileInfo [i + 120]);
						ironGlovesInvQuan = int.Parse (fileInfo [i + 121]);
						ironStrapSetQuan = int.Parse (fileInfo [i + 122]);
						ironStrapInvQuan = int.Parse (fileInfo [i + 123]);
						steelShoesSetQuan = int.Parse (fileInfo [i + 124]);
						steelShoesInvQuan = int.Parse (fileInfo [i + 125]);
						steelGlovesSetQuan = int.Parse (fileInfo [i + 126]);
						steelGlovesInvQuan = int.Parse (fileInfo [i + 127]);
						steelStrapSetQuan = int.Parse (fileInfo [i + 128]);
						steelStrapInvQuan = int.Parse (fileInfo [i + 129]);
						bloodShoesSetQuan = int.Parse (fileInfo [i + 130]);
						bloodShoesInvQuan = int.Parse (fileInfo [i + 131]);
						bloodGlovesSetQuan = int.Parse (fileInfo [i + 132]);
						bloodGlovesInvQuan = int.Parse (fileInfo [i + 133]);
						bloodStrapSetQuan = int.Parse (fileInfo [i + 134]);
						bloodStrapInvQuan = int.Parse (fileInfo [i + 135]);
						loveShoesSetQuan = int.Parse (fileInfo [i + 136]);
						loveShoesInvQuan = int.Parse (fileInfo [i + 137]);
						loveGlovesSetQuan = int.Parse (fileInfo [i + 138]);
						loveGlovesInvQuan = int.Parse (fileInfo [i + 139]);
						loveStrapSetQuan = int.Parse (fileInfo [i + 140]);
						loveStrapInvQuan = int.Parse (fileInfo [i + 141]);
						uesSetQuan = int.Parse (fileInfo [i + 142]);
						uesInvQuan = int.Parse (fileInfo [i + 143]);
						uisSetQuan = int.Parse (fileInfo [i + 144]);
						uisInvQuan = int.Parse (fileInfo [i + 145]);
						incLv1SetQuan = int.Parse (fileInfo [i + 146]);
						incLv1InvQuan = int.Parse (fileInfo [i + 147]);
						incLv2SetQuan = int.Parse (fileInfo [i + 148]);
						incLv2InvQuan = int.Parse (fileInfo [i + 149]);
						incLv3SetQuan = int.Parse (fileInfo [i + 150]);
						incLv3InvQuan = int.Parse (fileInfo [i + 151]);
						incLv4SetQuan = int.Parse (fileInfo [i + 152]);
						incLv4InvQuan = int.Parse (fileInfo [i + 153]);
						incB1SetQuan = int.Parse (fileInfo [i + 154]);
						incB1InvQuan = int.Parse (fileInfo [i + 155]);
						incB2SetQuan = int.Parse (fileInfo [i + 156]);
						incB2InvQuan = int.Parse (fileInfo [i + 157]);
						incL1SetQuan = int.Parse (fileInfo [i + 158]);
						incL1InvQuan = int.Parse (fileInfo [i + 159]);
						incL2SetQuan = int.Parse (fileInfo [i + 160]);
						incL2InvQuan = int.Parse (fileInfo [i + 161]);
						incStr1SetQuan = int.Parse (fileInfo [i + 162]);
						incStr1InvQuan = int.Parse (fileInfo [i + 163]);
						incStr2SetQuan = int.Parse (fileInfo [i + 164]);
						incStr2InvQuan = int.Parse (fileInfo [i + 165]);
						incInt1SetQuan = int.Parse (fileInfo [i + 166]);
						incInt1InvQuan = int.Parse (fileInfo [i + 167]);
						incInt2SetQuan = int.Parse (fileInfo [i + 168]);
						incInt2InvQuan = int.Parse (fileInfo [i + 169]);
						incDex1SetQuan = int.Parse (fileInfo [i + 170]);
						incDex1InvQuan = int.Parse (fileInfo [i + 171]);
						incDex2SetQuan = int.Parse (fileInfo [i + 172]);
						incDex2InvQuan = int.Parse (fileInfo [i + 173]);
						incLuk1SetQuan = int.Parse (fileInfo [i + 174]);
						incLuk1InvQuan = int.Parse (fileInfo [i + 175]);
						incLuk2SetQuan = int.Parse (fileInfo [i + 176]);
						incLuk2InvQuan = int.Parse (fileInfo [i + 177]);
						i = fileInfo.Length;
					}
				}
			}
		}

		if (toolBarInt == 1) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart2.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart2.txt");
				if(fileInfo.Length > 1) {
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
						aBPQuan = int.Parse (fileInfo [i + 52]);
						phereQuan = int.Parse (fileInfo [i + 53]);
						bBPQuan = int.Parse (fileInfo [i + 54]);
						loveMolQuan = int.Parse (fileInfo [i + 55]);
						abBPQuan = int.Parse (fileInfo [i + 56]);
						loveDustQuan = int.Parse (fileInfo [i + 57]);
						ONegQuan = int.Parse (fileInfo [i + 58]);
						lovePotQuan = int.Parse (fileInfo [i + 59]);
						hPumpQuan = int.Parse (fileInfo [i + 60]);
						aKissQuan = int.Parse (fileInfo [i + 61]);
						adrenQuan = int.Parse (fileInfo [i + 62]);
						nutPillQuan = int.Parse (fileInfo [i + 63]);
						rageQuan = int.Parse (fileInfo [i + 64]);
						fKissQuan = int.Parse (fileInfo [i + 65]);
						epinPillQuan = int.Parse (fileInfo [i + 66]);
						hArmorQuan = int.Parse (fileInfo [i + 67]);
						pKissQuan = int.Parse (fileInfo [i + 68]);
						lArmorQuan = int.Parse (fileInfo [i + 69]);
						lossSetQuan = int.Parse (fileInfo [i + 70]);
						lossInvQuan = int.Parse (fileInfo [i + 71]);
						remSetQuan = int.Parse (fileInfo [i + 72]);
						remInvQuan = int.Parse (fileInfo [i + 73]);
						sadSetQuan = int.Parse (fileInfo [i + 74]);
						sadInvQuan = int.Parse (fileInfo [i + 75]);
						bitSetQuan = int.Parse (fileInfo [i + 76]);
						bitInvQuan = int.Parse (fileInfo [i + 77]);
						sorSetQuan = int.Parse (fileInfo [i + 78]);
						sorInvQuan = int.Parse (fileInfo [i + 79]);
						loneSetQuan = int.Parse (fileInfo [i + 80]);
						loneInvQuan = int.Parse (fileInfo [i + 81]);
						misSetQuan = int.Parse (fileInfo [i + 82]);
						misInvQuan = int.Parse (fileInfo [i + 83]);
						longSetQuan = int.Parse (fileInfo [i + 84]);
						longInvQuan = int.Parse (fileInfo [i + 85]);
						needSetQuan = int.Parse (fileInfo [i + 86]);
						needInvQuan = int.Parse (fileInfo [i + 87]);
						disSetQuan = int.Parse (fileInfo [i + 88]);
						disInvQuan = int.Parse (fileInfo [i + 89]);
						gladSetQuan = int.Parse (fileInfo [i + 90]);
						gladInvQuan = int.Parse (fileInfo [i + 91]);
						happSetQuan = int.Parse (fileInfo [i + 92]);
						happInvQuan = int.Parse (fileInfo [i + 93]);
						hopeSetQuan = int.Parse (fileInfo [i + 94]);
						hopeInvQuan = int.Parse (fileInfo [i + 95]);
						attSetQuan = int.Parse (fileInfo [i + 96]);
						attInvQuan = int.Parse (fileInfo [i + 97]);
						hostSetQuan = int.Parse (fileInfo [i + 98]);
						hostInvQuan = int.Parse (fileInfo [i + 99]);
						rageWepSetQuan = int.Parse (fileInfo [i + 100]);
						rageWepInvQuan = int.Parse (fileInfo [i + 101]);
						passSetQuan = int.Parse (fileInfo [i + 102]);
						passInvQuan = int.Parse (fileInfo [i + 103]);
						triSetQuan = int.Parse (fileInfo [i + 104]);
						triInvQuan = int.Parse (fileInfo [i + 105]);
						sandSetQuan = int.Parse (fileInfo [i + 106]);
						sandInvQuan = int.Parse (fileInfo [i + 107]);
						leaGlovesSetQuan = int.Parse (fileInfo [i + 108]);
						leaGlovesInvQuan = int.Parse (fileInfo [i + 109]);
						leaStrapSetQuan = int.Parse (fileInfo [i + 110]);
						leaStrapInvQuan = int.Parse (fileInfo [i + 111]);
						bronShoesSetQuan = int.Parse (fileInfo [i + 112]);
						bronShoesInvQuan = int.Parse (fileInfo [i + 113]);
						bronGlovesSetQuan = int.Parse (fileInfo [i + 114]);
						bronGlovesInvQuan = int.Parse (fileInfo [i + 115]);
						bronStrapSetQuan = int.Parse (fileInfo [i + 116]);
						bronStrapInvQuan = int.Parse (fileInfo [i + 117]);
						ironShoesSetQuan = int.Parse (fileInfo [i + 118]);
						ironShoesInvQuan = int.Parse (fileInfo [i + 119]);
						ironGlovesSetQuan = int.Parse (fileInfo [i + 120]);
						ironGlovesInvQuan = int.Parse (fileInfo [i + 121]);
						ironStrapSetQuan = int.Parse (fileInfo [i + 122]);
						ironStrapInvQuan = int.Parse (fileInfo [i + 123]);
						steelShoesSetQuan = int.Parse (fileInfo [i + 124]);
						steelShoesInvQuan = int.Parse (fileInfo [i + 125]);
						steelGlovesSetQuan = int.Parse (fileInfo [i + 126]);
						steelGlovesInvQuan = int.Parse (fileInfo [i + 127]);
						steelStrapSetQuan = int.Parse (fileInfo [i + 128]);
						steelStrapInvQuan = int.Parse (fileInfo [i + 129]);
						bloodShoesSetQuan = int.Parse (fileInfo [i + 130]);
						bloodShoesInvQuan = int.Parse (fileInfo [i + 131]);
						bloodGlovesSetQuan = int.Parse (fileInfo [i + 132]);
						bloodGlovesInvQuan = int.Parse (fileInfo [i + 133]);
						bloodStrapSetQuan = int.Parse (fileInfo [i + 134]);
						bloodStrapInvQuan = int.Parse (fileInfo [i + 135]);
						loveShoesSetQuan = int.Parse (fileInfo [i + 136]);
						loveShoesInvQuan = int.Parse (fileInfo [i + 137]);
						loveGlovesSetQuan = int.Parse (fileInfo [i + 138]);
						loveGlovesInvQuan = int.Parse (fileInfo [i + 139]);
						loveStrapSetQuan = int.Parse (fileInfo [i + 140]);
						loveStrapInvQuan = int.Parse (fileInfo [i + 141]);
						uesSetQuan = int.Parse (fileInfo [i + 142]);
						uesInvQuan = int.Parse (fileInfo [i + 143]);
						uisSetQuan = int.Parse (fileInfo [i + 144]);
						uisInvQuan = int.Parse (fileInfo [i + 145]);
						incLv1SetQuan = int.Parse (fileInfo [i + 146]);
						incLv1InvQuan = int.Parse (fileInfo [i + 147]);
						incLv2SetQuan = int.Parse (fileInfo [i + 148]);
						incLv2InvQuan = int.Parse (fileInfo [i + 149]);
						incLv3SetQuan = int.Parse (fileInfo [i + 150]);
						incLv3InvQuan = int.Parse (fileInfo [i + 151]);
						incLv4SetQuan = int.Parse (fileInfo [i + 152]);
						incLv4InvQuan = int.Parse (fileInfo [i + 153]);
						incB1SetQuan = int.Parse (fileInfo [i + 154]);
						incB1InvQuan = int.Parse (fileInfo [i + 155]);
						incB2SetQuan = int.Parse (fileInfo [i + 156]);
						incB2InvQuan = int.Parse (fileInfo [i + 157]);
						incL1SetQuan = int.Parse (fileInfo [i + 158]);
						incL1InvQuan = int.Parse (fileInfo [i + 159]);
						incL2SetQuan = int.Parse (fileInfo [i + 160]);
						incL2InvQuan = int.Parse (fileInfo [i + 161]);
						incStr1SetQuan = int.Parse (fileInfo [i + 162]);
						incStr1InvQuan = int.Parse (fileInfo [i + 163]);
						incStr2SetQuan = int.Parse (fileInfo [i + 164]);
						incStr2InvQuan = int.Parse (fileInfo [i + 165]);
						incInt1SetQuan = int.Parse (fileInfo [i + 166]);
						incInt1InvQuan = int.Parse (fileInfo [i + 167]);
						incInt2SetQuan = int.Parse (fileInfo [i + 168]);
						incInt2InvQuan = int.Parse (fileInfo [i + 169]);
						incDex1SetQuan = int.Parse (fileInfo [i + 170]);
						incDex1InvQuan = int.Parse (fileInfo [i + 171]);
						incDex2SetQuan = int.Parse (fileInfo [i + 172]);
						incDex2InvQuan = int.Parse (fileInfo [i + 173]);
						incLuk1SetQuan = int.Parse (fileInfo [i + 174]);
						incLuk1InvQuan = int.Parse (fileInfo [i + 175]);
						incLuk2SetQuan = int.Parse (fileInfo [i + 176]);
						incLuk2InvQuan = int.Parse (fileInfo [i + 177]);
						i = fileInfo.Length;
					}
				}
			}
		}

		if (toolBarInt == 2) {
			using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/Heart3.txt")) {
				string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Heart3.txt");
				if(fileInfo.Length > 1) {
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
						aBPQuan = int.Parse (fileInfo [i + 52]);
						phereQuan = int.Parse (fileInfo [i + 53]);
						bBPQuan = int.Parse (fileInfo [i + 54]);
						loveMolQuan = int.Parse (fileInfo [i + 55]);
						abBPQuan = int.Parse (fileInfo [i + 56]);
						loveDustQuan = int.Parse (fileInfo [i + 57]);
						ONegQuan = int.Parse (fileInfo [i + 58]);
						lovePotQuan = int.Parse (fileInfo [i + 59]);
						hPumpQuan = int.Parse (fileInfo [i + 60]);
						aKissQuan = int.Parse (fileInfo [i + 61]);
						adrenQuan = int.Parse (fileInfo [i + 62]);
						nutPillQuan = int.Parse (fileInfo [i + 63]);
						rageQuan = int.Parse (fileInfo [i + 64]);
						fKissQuan = int.Parse (fileInfo [i + 65]);
						epinPillQuan = int.Parse (fileInfo [i + 66]);
						hArmorQuan = int.Parse (fileInfo [i + 67]);
						pKissQuan = int.Parse (fileInfo [i + 68]);
						lArmorQuan = int.Parse (fileInfo [i + 69]);
						lossSetQuan = int.Parse (fileInfo [i + 70]);
						lossInvQuan = int.Parse (fileInfo [i + 71]);
						remSetQuan = int.Parse (fileInfo [i + 72]);
						remInvQuan = int.Parse (fileInfo [i + 73]);
						sadSetQuan = int.Parse (fileInfo [i + 74]);
						sadInvQuan = int.Parse (fileInfo [i + 75]);
						bitSetQuan = int.Parse (fileInfo [i + 76]);
						bitInvQuan = int.Parse (fileInfo [i + 77]);
						sorSetQuan = int.Parse (fileInfo [i + 78]);
						sorInvQuan = int.Parse (fileInfo [i + 79]);
						loneSetQuan = int.Parse (fileInfo [i + 80]);
						loneInvQuan = int.Parse (fileInfo [i + 81]);
						misSetQuan = int.Parse (fileInfo [i + 82]);
						misInvQuan = int.Parse (fileInfo [i + 83]);
						longSetQuan = int.Parse (fileInfo [i + 84]);
						longInvQuan = int.Parse (fileInfo [i + 85]);
						needSetQuan = int.Parse (fileInfo [i + 86]);
						needInvQuan = int.Parse (fileInfo [i + 87]);
						disSetQuan = int.Parse (fileInfo [i + 88]);
						disInvQuan = int.Parse (fileInfo [i + 89]);
						gladSetQuan = int.Parse (fileInfo [i + 90]);
						gladInvQuan = int.Parse (fileInfo [i + 91]);
						happSetQuan = int.Parse (fileInfo [i + 92]);
						happInvQuan = int.Parse (fileInfo [i + 93]);
						hopeSetQuan = int.Parse (fileInfo [i + 94]);
						hopeInvQuan = int.Parse (fileInfo [i + 95]);
						attSetQuan = int.Parse (fileInfo [i + 96]);
						attInvQuan = int.Parse (fileInfo [i + 97]);
						hostSetQuan = int.Parse (fileInfo [i + 98]);
						hostInvQuan = int.Parse (fileInfo [i + 99]);
						rageWepSetQuan = int.Parse (fileInfo [i + 100]);
						rageWepInvQuan = int.Parse (fileInfo [i + 101]);
						passSetQuan = int.Parse (fileInfo [i + 102]);
						passInvQuan = int.Parse (fileInfo [i + 103]);
						triSetQuan = int.Parse (fileInfo [i + 104]);
						triInvQuan = int.Parse (fileInfo [i + 105]);
						sandSetQuan = int.Parse (fileInfo [i + 106]);
						sandInvQuan = int.Parse (fileInfo [i + 107]);
						leaGlovesSetQuan = int.Parse (fileInfo [i + 108]);
						leaGlovesInvQuan = int.Parse (fileInfo [i + 109]);
						leaStrapSetQuan = int.Parse (fileInfo [i + 110]);
						leaStrapInvQuan = int.Parse (fileInfo [i + 111]);
						bronShoesSetQuan = int.Parse (fileInfo [i + 112]);
						bronShoesInvQuan = int.Parse (fileInfo [i + 113]);
						bronGlovesSetQuan = int.Parse (fileInfo [i + 114]);
						bronGlovesInvQuan = int.Parse (fileInfo [i + 115]);
						bronStrapSetQuan = int.Parse (fileInfo [i + 116]);
						bronStrapInvQuan = int.Parse (fileInfo [i + 117]);
						ironShoesSetQuan = int.Parse (fileInfo [i + 118]);
						ironShoesInvQuan = int.Parse (fileInfo [i + 119]);
						ironGlovesSetQuan = int.Parse (fileInfo [i + 120]);
						ironGlovesInvQuan = int.Parse (fileInfo [i + 121]);
						ironStrapSetQuan = int.Parse (fileInfo [i + 122]);
						ironStrapInvQuan = int.Parse (fileInfo [i + 123]);
						steelShoesSetQuan = int.Parse (fileInfo [i + 124]);
						steelShoesInvQuan = int.Parse (fileInfo [i + 125]);
						steelGlovesSetQuan = int.Parse (fileInfo [i + 126]);
						steelGlovesInvQuan = int.Parse (fileInfo [i + 127]);
						steelStrapSetQuan = int.Parse (fileInfo [i + 128]);
						steelStrapInvQuan = int.Parse (fileInfo [i + 129]);
						bloodShoesSetQuan = int.Parse (fileInfo [i + 130]);
						bloodShoesInvQuan = int.Parse (fileInfo [i + 131]);
						bloodGlovesSetQuan = int.Parse (fileInfo [i + 132]);
						bloodGlovesInvQuan = int.Parse (fileInfo [i + 133]);
						bloodStrapSetQuan = int.Parse (fileInfo [i + 134]);
						bloodStrapInvQuan = int.Parse (fileInfo [i + 135]);
						loveShoesSetQuan = int.Parse (fileInfo [i + 136]);
						loveShoesInvQuan = int.Parse (fileInfo [i + 137]);
						loveGlovesSetQuan = int.Parse (fileInfo [i + 138]);
						loveGlovesInvQuan = int.Parse (fileInfo [i + 139]);
						loveStrapSetQuan = int.Parse (fileInfo [i + 140]);
						loveStrapInvQuan = int.Parse (fileInfo [i + 141]);
						uesSetQuan = int.Parse (fileInfo [i + 142]);
						uesInvQuan = int.Parse (fileInfo [i + 143]);
						uisSetQuan = int.Parse (fileInfo [i + 144]);
						uisInvQuan = int.Parse (fileInfo [i + 145]);
						incLv1SetQuan = int.Parse (fileInfo [i + 146]);
						incLv1InvQuan = int.Parse (fileInfo [i + 147]);
						incLv2SetQuan = int.Parse (fileInfo [i + 148]);
						incLv2InvQuan = int.Parse (fileInfo [i + 149]);
						incLv3SetQuan = int.Parse (fileInfo [i + 150]);
						incLv3InvQuan = int.Parse (fileInfo [i + 151]);
						incLv4SetQuan = int.Parse (fileInfo [i + 152]);
						incLv4InvQuan = int.Parse (fileInfo [i + 153]);
						incB1SetQuan = int.Parse (fileInfo [i + 154]);
						incB1InvQuan = int.Parse (fileInfo [i + 155]);
						incB2SetQuan = int.Parse (fileInfo [i + 156]);
						incB2InvQuan = int.Parse (fileInfo [i + 157]);
						incL1SetQuan = int.Parse (fileInfo [i + 158]);
						incL1InvQuan = int.Parse (fileInfo [i + 159]);
						incL2SetQuan = int.Parse (fileInfo [i + 160]);
						incL2InvQuan = int.Parse (fileInfo [i + 161]);
						incStr1SetQuan = int.Parse (fileInfo [i + 162]);
						incStr1InvQuan = int.Parse (fileInfo [i + 163]);
						incStr2SetQuan = int.Parse (fileInfo [i + 164]);
						incStr2InvQuan = int.Parse (fileInfo [i + 165]);
						incInt1SetQuan = int.Parse (fileInfo [i + 166]);
						incInt1InvQuan = int.Parse (fileInfo [i + 167]);
						incInt2SetQuan = int.Parse (fileInfo [i + 168]);
						incInt2InvQuan = int.Parse (fileInfo [i + 169]);
						incDex1SetQuan = int.Parse (fileInfo [i + 170]);
						incDex1InvQuan = int.Parse (fileInfo [i + 171]);
						incDex2SetQuan = int.Parse (fileInfo [i + 172]);
						incDex2InvQuan = int.Parse (fileInfo [i + 173]);
						incLuk1SetQuan = int.Parse (fileInfo [i + 174]);
						incLuk1InvQuan = int.Parse (fileInfo [i + 175]);
						incLuk2SetQuan = int.Parse (fileInfo [i + 176]);
						incLuk2InvQuan = int.Parse (fileInfo [i + 177]);
						i = fileInfo.Length;
					}
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
		file.WriteLine (aBPQuan);
		file.WriteLine (phereQuan);
		file.WriteLine (bBPQuan);
		file.WriteLine (loveMolQuan);
		file.WriteLine (abBPQuan);
		file.WriteLine (loveDustQuan);
		file.WriteLine (ONegQuan);
		file.WriteLine (lovePotQuan);
		file.WriteLine (hPumpQuan);
		file.WriteLine (aKissQuan);
		file.WriteLine (adrenQuan);
		file.WriteLine (nutPillQuan);
		file.WriteLine (rageQuan);
		file.WriteLine (fKissQuan);
		file.WriteLine (epinPillQuan);
		file.WriteLine (hArmorQuan);
		file.WriteLine (pKissQuan);
		file.WriteLine (lArmorQuan);
		file.WriteLine (lossSetQuan);
		file.WriteLine (lossInvQuan);
		file.WriteLine (remSetQuan);
		file.WriteLine (remInvQuan);
		file.WriteLine (sadSetQuan);
		file.WriteLine (sadInvQuan);
		file.WriteLine (bitSetQuan);
		file.WriteLine (bitInvQuan);
		file.WriteLine (sorSetQuan);
		file.WriteLine (sorInvQuan);
		file.WriteLine (loneSetQuan);
		file.WriteLine (loneInvQuan);
		file.WriteLine (misSetQuan);
		file.WriteLine (misInvQuan);
		file.WriteLine (longSetQuan);
		file.WriteLine (longInvQuan);
		file.WriteLine (needSetQuan);
		file.WriteLine (needInvQuan);
		file.WriteLine (disSetQuan);
		file.WriteLine (disInvQuan);
		file.WriteLine (gladSetQuan);
		file.WriteLine (gladInvQuan);
		file.WriteLine (happSetQuan);
		file.WriteLine (happInvQuan);
		file.WriteLine (hopeSetQuan);
		file.WriteLine (hopeInvQuan);
		file.WriteLine (attSetQuan);
		file.WriteLine (attInvQuan);
		file.WriteLine (hostSetQuan);
		file.WriteLine (hostInvQuan);
		file.WriteLine (rageWepSetQuan);
		file.WriteLine (rageWepInvQuan);
		file.WriteLine (passSetQuan);
		file.WriteLine (passInvQuan);
		file.WriteLine (triSetQuan);
		file.WriteLine (triInvQuan);
		file.WriteLine (sandSetQuan);
		file.WriteLine (sandInvQuan);
		file.WriteLine (leaGlovesSetQuan);
		file.WriteLine (leaGlovesInvQuan);
		file.WriteLine (leaStrapSetQuan);
		file.WriteLine (leaStrapInvQuan);
		file.WriteLine (bronShoesSetQuan);
		file.WriteLine (bronShoesInvQuan);
		file.WriteLine (bronGlovesSetQuan);
		file.WriteLine (bronGlovesInvQuan);
		file.WriteLine (bronStrapSetQuan);
		file.WriteLine (bronStrapInvQuan);
		file.WriteLine (ironShoesSetQuan);
		file.WriteLine (ironShoesInvQuan);
		file.WriteLine (ironGlovesSetQuan);
		file.WriteLine (ironGlovesInvQuan);
		file.WriteLine (ironStrapSetQuan);
		file.WriteLine (ironStrapInvQuan);
		file.WriteLine (steelShoesSetQuan);
		file.WriteLine (steelShoesInvQuan);
		file.WriteLine (steelGlovesSetQuan);
		file.WriteLine (steelGlovesInvQuan);
		file.WriteLine (steelStrapSetQuan);
		file.WriteLine (steelStrapInvQuan);
		file.WriteLine (bloodShoesSetQuan);
		file.WriteLine (bloodShoesInvQuan);
		file.WriteLine (bloodGlovesSetQuan);
		file.WriteLine (bloodGlovesInvQuan);
		file.WriteLine (bloodStrapSetQuan);
		file.WriteLine (bloodStrapInvQuan);
		file.WriteLine (loveShoesSetQuan);
		file.WriteLine (loveShoesInvQuan);
		file.WriteLine (loveGlovesSetQuan);
		file.WriteLine (loveGlovesInvQuan);
		file.WriteLine (loveStrapSetQuan);
		file.WriteLine (loveStrapInvQuan);
		file.WriteLine (uesSetQuan);
		file.WriteLine (uesInvQuan);
		file.WriteLine (uisSetQuan);
		file.WriteLine (uisInvQuan);
		file.WriteLine (incLv1SetQuan);
		file.WriteLine (incLv1InvQuan);
		file.WriteLine (incLv2SetQuan);
		file.WriteLine (incLv2InvQuan);
		file.WriteLine (incLv3SetQuan);
		file.WriteLine (incLv3InvQuan);
		file.WriteLine (incLv4SetQuan);
		file.WriteLine (incLv4InvQuan);
		file.WriteLine (incB1SetQuan);
		file.WriteLine (incB1InvQuan);
		file.WriteLine (incB2SetQuan);
		file.WriteLine (incB2InvQuan);
		file.WriteLine (incL1SetQuan);
		file.WriteLine (incL1InvQuan);
		file.WriteLine (incL2SetQuan);
		file.WriteLine (incL2InvQuan);
		file.WriteLine (incStr1SetQuan);
		file.WriteLine (incStr1InvQuan);
		file.WriteLine (incStr2SetQuan);
		file.WriteLine (incStr2InvQuan);
		file.WriteLine (incInt1SetQuan);
		file.WriteLine (incInt1InvQuan);
		file.WriteLine (incInt2SetQuan);
		file.WriteLine (incInt2InvQuan);
		file.WriteLine (incDex1SetQuan);
		file.WriteLine (incDex1InvQuan);
		file.WriteLine (incDex2SetQuan);
		file.WriteLine (incDex2InvQuan);
		file.WriteLine (incLuk1SetQuan);
		file.WriteLine (incLuk1InvQuan);
		file.WriteLine (incLuk2SetQuan);
		file.WriteLine (incLuk2InvQuan);
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

		GameItemStorage.aBPQuan = aBPQuan;
		GameItemStorage.phereQuan = phereQuan;
		GameItemStorage.bBPQuan = bBPQuan;
		GameItemStorage.loveMolQuan = loveMolQuan;
		GameItemStorage.abBPQuan = abBPQuan;
		GameItemStorage.loveDustQuan = loveDustQuan;
		GameItemStorage.ONegQuan = ONegQuan;
		GameItemStorage.lovePotQuan = lovePotQuan;
		GameItemStorage.hPumpQuan = hPumpQuan;
		GameItemStorage.aKissQuan = aKissQuan;
		GameItemStorage.adrenQuan = adrenQuan;
		GameItemStorage.nutPillQuan = nutPillQuan;
		GameItemStorage.rageQuan = rageQuan;
		GameItemStorage.fKissQuan = fKissQuan;
		GameItemStorage.epinPillQuan = epinPillQuan;
		GameItemStorage.hArmorQuan = hArmorQuan;
		GameItemStorage.pKissQuan = pKissQuan;
		GameItemStorage.lArmorQuan = lArmorQuan;
		
		GameItemStorage.lossSetQuan = lossSetQuan;
		GameItemStorage.lossInvQuan = lossInvQuan;
		
		GameItemStorage.remSetQuan = remSetQuan;
		GameItemStorage.remInvQuan = remInvQuan;
		
		GameItemStorage.sadSetQuan = sadSetQuan;
		GameItemStorage.sadInvQuan = sadInvQuan;
		
		GameItemStorage.bitSetQuan = bitSetQuan;
		GameItemStorage.bitInvQuan = bitInvQuan;
		
		GameItemStorage.sorSetQuan = sorSetQuan;
		GameItemStorage.sorInvQuan = sorInvQuan;
		
		GameItemStorage.loneSetQuan = loneSetQuan;
		GameItemStorage.loneInvQuan = loneInvQuan;
		
		GameItemStorage.misSetQuan = misSetQuan;
		GameItemStorage.misInvQuan = misInvQuan;
		
		GameItemStorage.longSetQuan = longSetQuan;
		GameItemStorage.longInvQuan = longInvQuan;
		
		GameItemStorage.needSetQuan = needSetQuan;
		GameItemStorage.needInvQuan = needInvQuan;
		
		GameItemStorage.disSetQuan = disSetQuan;
		GameItemStorage.disInvQuan = disInvQuan;
		
		GameItemStorage.gladSetQuan = gladSetQuan;
		GameItemStorage.gladInvQuan = gladInvQuan;
		
		GameItemStorage.happSetQuan = happSetQuan;
		GameItemStorage.happInvQuan = happInvQuan;
		
		GameItemStorage.hopeSetQuan = hopeSetQuan;
		GameItemStorage.hopeInvQuan = hopeInvQuan;
		
		GameItemStorage.attSetQuan = attSetQuan;
		GameItemStorage.attInvQuan = attInvQuan;
		
		GameItemStorage.hostSetQuan = hostSetQuan;
		GameItemStorage.hostInvQuan = hostInvQuan;
		
		GameItemStorage.rageWepSetQuan = rageWepSetQuan;
		GameItemStorage.rageWepInvQuan = rageWepInvQuan;
		
		GameItemStorage.passSetQuan = passSetQuan;
		GameItemStorage.passInvQuan = passInvQuan;
		
		GameItemStorage.triSetQuan = triSetQuan;
		GameItemStorage.triInvQuan = triInvQuan;
		
		GameItemStorage.sandSetQuan = sandSetQuan;
		GameItemStorage.sandInvQuan = sandInvQuan;
		
		GameItemStorage.leaGlovesSetQuan = leaGlovesSetQuan;
		GameItemStorage.leaGlovesInvQuan = leaGlovesInvQuan;
		
		GameItemStorage.leaStrapSetQuan = leaStrapSetQuan;
		GameItemStorage.leaStrapInvQuan = leaStrapInvQuan;
		
		GameItemStorage.bronShoesSetQuan = bronShoesSetQuan;
		GameItemStorage.bronShoesInvQuan = bronShoesInvQuan;
		
		GameItemStorage.bronGlovesSetQuan = bronGlovesSetQuan;
		GameItemStorage.bronGlovesInvQuan = bronGlovesInvQuan;
		
		GameItemStorage.bronStrapSetQuan = bronStrapSetQuan;
		GameItemStorage.bronStrapInvQuan = bronStrapInvQuan;
		
		GameItemStorage.ironShoesSetQuan = ironShoesSetQuan;
		GameItemStorage.ironShoesInvQuan = ironShoesInvQuan;
		
		GameItemStorage.ironGlovesSetQuan = ironGlovesSetQuan;
		GameItemStorage.ironGlovesInvQuan = ironGlovesInvQuan;
		
		GameItemStorage.ironStrapSetQuan = ironStrapSetQuan;
		GameItemStorage.ironStrapInvQuan = ironStrapInvQuan;
		
		GameItemStorage.steelShoesSetQuan = steelShoesSetQuan;
		GameItemStorage.steelShoesInvQuan = steelShoesInvQuan;
		
		GameItemStorage.steelGlovesSetQuan = steelGlovesSetQuan;
		GameItemStorage.steelGlovesInvQuan = steelGlovesInvQuan;
		
		GameItemStorage.steelStrapSetQuan = steelStrapSetQuan;
		GameItemStorage.steelStrapInvQuan = steelStrapInvQuan;
		
		GameItemStorage.bloodShoesSetQuan = bloodShoesSetQuan;
		GameItemStorage.bloodShoesInvQuan = bloodShoesInvQuan;
		
		GameItemStorage.bloodGlovesSetQuan = bloodGlovesSetQuan;
		GameItemStorage.bloodGlovesInvQuan = bloodGlovesInvQuan;
		
		GameItemStorage.bloodStrapSetQuan = bloodStrapSetQuan;
		GameItemStorage.bloodStrapInvQuan = bloodStrapInvQuan;
		
		GameItemStorage.loveShoesSetQuan = loveShoesSetQuan;
		GameItemStorage.loveShoesInvQuan = loveShoesInvQuan;
		
		GameItemStorage.loveGlovesSetQuan = loveGlovesSetQuan;
		GameItemStorage.loveGlovesInvQuan = loveGlovesInvQuan;
		
		GameItemStorage.loveStrapSetQuan = loveStrapSetQuan;
		GameItemStorage.loveStrapInvQuan = loveStrapInvQuan;
		
		GameItemStorage.uesSetQuan = uesSetQuan;
		GameItemStorage.uesInvQuan = uesInvQuan;
		
		GameItemStorage.uisSetQuan = uisSetQuan;
		GameItemStorage.uisInvQuan = uisInvQuan;
		
		GameItemStorage.incLv1SetQuan = incLv1SetQuan;
		GameItemStorage.incLv1InvQuan = incLv1InvQuan;
		
		GameItemStorage.incLv2SetQuan = incLv2SetQuan;
		GameItemStorage.incLv2InvQuan = incLv2InvQuan;
		
		GameItemStorage.incLv3SetQuan = incLv3SetQuan;
		GameItemStorage.incLv3InvQuan = incLv3InvQuan;
		
		GameItemStorage.incLv4SetQuan = incLv4SetQuan;
		GameItemStorage.incLv4InvQuan = incLv4InvQuan;
		
		GameItemStorage.incB1SetQuan = incB1SetQuan;
		GameItemStorage.incB1InvQuan = incB1InvQuan;
		
		GameItemStorage.incB2SetQuan = incB2SetQuan;
		GameItemStorage.incB2InvQuan = incB2InvQuan;
		
		GameItemStorage.incL1SetQuan = incL1SetQuan;
		GameItemStorage.incL1InvQuan = incL1InvQuan;
		
		GameItemStorage.incL2SetQuan = incL2SetQuan;
		GameItemStorage.incL2InvQuan = incL2InvQuan;
		
		GameItemStorage.incStr1SetQuan = incStr1SetQuan;
		GameItemStorage.incStr1InvQuan = incStr1InvQuan;
		
		GameItemStorage.incStr2SetQuan = incStr2SetQuan;
		GameItemStorage.incStr2InvQuan = incStr2InvQuan;
		
		GameItemStorage.incInt1SetQuan = incInt1SetQuan;
		GameItemStorage.incInt1InvQuan = incInt1InvQuan;
		
		GameItemStorage.incInt2SetQuan = incInt2SetQuan;
		GameItemStorage.incInt2InvQuan = incInt2InvQuan;
		
		GameItemStorage.incDex2SetQuan = incDex1SetQuan;
		GameItemStorage.incDex1InvQuan = incDex1InvQuan;
		
		GameItemStorage.incDex2SetQuan = incDex2SetQuan;
		GameItemStorage.incDex2InvQuan = incDex2InvQuan;
		
		GameItemStorage.incLuk1SetQuan = incLuk1SetQuan;
		GameItemStorage.incLuk1InvQuan = incLuk1InvQuan;
		
		GameItemStorage.incLuk2SetQuan = incLuk2SetQuan;
		GameItemStorage.incLuk2InvQuan = incLuk2InvQuan;
	}
}
