using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HandelPointsDisplay : MonoBehaviour {

	public static int tempSP = 100;
	public static int tempStrP;
	public static int tempIntP;
	public static int tempDexP;
	public static int tempLukP;
	public static float tempPump = 50;
	public static float tempCardio = 50;
	public static float tempShell = 50;
	public static float tempAff = 50;
	public static float tempSkP = 50;

	public GameObject bloodHud;
	public GameObject loveHud;
	public GameObject exp;
	public GameObject blood;
	public GameObject love;
	public GameObject str;
	public GameObject intel;
	public GameObject dex;
	public GameObject luk;
	public GameObject pump;
	public GameObject aff;
	public GameObject cardio;
	public GameObject shell;
	public GameObject status;
	public GameObject slashSkill;
	public GameObject blastSkill;
	public GameObject buffSkill;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		exp.GetComponent<Text>().text = "Exp: " + Player_Stats.currExp + "/" + Player_Stats.max_Exp;
		blood.GetComponent<Text>().text = "Blood: " + Player_Stats.currBlood + "/" + Player_Stats.max_Blood;
		love.GetComponent<Text>().text = "Love: " + Player_Stats.currLove + "/" + Player_Stats.max_Love;
		if (Application.loadedLevel == 5) {
			bloodHud.GetComponent<Text>().text = Player_Stats.currBlood + "/" + Player_Stats.max_Blood;
			loveHud.GetComponent<Text>().text = Player_Stats.currLove + "/" + Player_Stats.max_Love;
			str.GetComponent<Text>().text = "Strength: " + HandelPointsDisplay.tempStrP;
			intel.GetComponent<Text>().text = "Intelligence: " + HandelPointsDisplay.tempIntP;
			dex.GetComponent<Text>().text = "Dexterity: " + HandelPointsDisplay.tempDexP;
			luk.GetComponent<Text>().text = "Luck: " + HandelPointsDisplay.tempLukP;
			status.GetComponent<Text>().text = HandelPointsDisplay.tempSP + " Points";
			slashSkill.GetComponent<Text>().text = "" + HandelPointsDisplay.tempSkP;
			blastSkill.GetComponent<Text>().text = "" + HandelPointsDisplay.tempSkP;
			buffSkill.GetComponent<Text>().text = "" + HandelPointsDisplay.tempSkP;
			
		}
		if (Application.loadedLevel == 3) {
			str.GetComponent<Text>().text = "Str: " + HandelPointsDisplay.tempStrP;
			intel.GetComponent<Text>().text = "Int: " + HandelPointsDisplay.tempIntP;
			dex.GetComponent<Text>().text = "Dex: " + HandelPointsDisplay.tempDexP;
			luk.GetComponent<Text>().text = "Luk: " + HandelPointsDisplay.tempLukP;
			status.GetComponent<Text>().text = "Status Points: " + HandelPointsDisplay.tempSP;
			slashSkill.GetComponent<Text>().text = "Skill Points: " + HandelPointsDisplay.tempSkP;
			blastSkill.GetComponent<Text>().text = "" + HandelPointsDisplay.tempSkP;
			pump.GetComponent<Text>().text = "Pump: " + (82.5 + (HandelPointsDisplay.tempPump*.33f) * (5*HandelPointsDisplay.tempStrP)) + "~" + (250 + (HandelPointsDisplay.tempPump) * (5*HandelPointsDisplay.tempStrP));
			aff.GetComponent<Text>().text = "Affection: " + (49.5 + (HandelPointsDisplay.tempAff*.33f) * (3*HandelPointsDisplay.tempIntP)) + "~" + (150 + (HandelPointsDisplay.tempAff) * (3*HandelPointsDisplay.tempIntP));
			cardio.GetComponent<Text>().text = "Cardio: " + (33 + (HandelPointsDisplay.tempCardio*.33f) * (2*HandelPointsDisplay.tempDexP)) + "~" + (100 + (HandelPointsDisplay.tempCardio) * (2*HandelPointsDisplay.tempDexP));
			shell.GetComponent<Text>().text = "Shell: " + (165 + (HandelPointsDisplay.tempShell*.33f) * (10*HandelPointsDisplay.tempLukP)) + "~" + (500 + (HandelPointsDisplay.tempShell) * (10*HandelPointsDisplay.tempLukP));
		}
	}

	public void IncStr() {
		if (tempSP > 0) {
			tempSP -= 1;
			tempStrP += 1;
		}
	}

	public void IncInt() {
		if (tempSP > 0) {
			tempSP -= 1;
			tempIntP += 1;
		}
	}

	public void IncDex() {
		if (tempSP > 0) {
			tempSP -= 1;
			tempDexP += 1;
		}
	}

	public void IncLuk() {
		if (tempSP > 0) {
			tempSP -= 1;
			tempLukP += 1;
		}
	}

	public void IncBlood() {
		if (tempSP > 0) {
			tempSP -= 1;
			Player_Stats.max_Blood += 50;
		}
	}

	public void IncLove() {
		if (tempSP > 0) {
			tempSP -= 1;
			Player_Stats.max_Love += 50;
		}
	}
	
}
