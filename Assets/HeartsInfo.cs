using UnityEngine;
using System.Collections;
using System.IO;

public class HeartsInfo : MonoBehaviour {

	public static int statPoints = 0;
	public static int skillPoints = 0;

	public static int strPoints;
	public static int pumpLow;
	public static int pumpHigh;

	public static int intPoints;
	public static int loveLow;
	public static int loveHigh;

	public static int dexPoints;
	public static int cardioLow;
	public static int cardioHigh;

	public static int lukPoints;
	public static int shellLow;
	public static int shellHigh;

	public static int blood;
	public static int love;
	public static int exp;

	public static int pace = 1;
	
	// Use this for initialization
	void Start () {	
		FindLevel ();
	}
	
	// Update is called once per frame
	void Update () {
		Status ();
	}

	public static void FindLevel(){

		int tempBlood = 0;
		int tempLove = 0;
		int tempExp = 0;
		int tempPumpLow = 0;
		int tempPumpHigh = 0;
		int tempLoveLow = 0;
		int tempLoveHigh = 0;
		int tempCardioLow = 0;
		int tempCardioHigh = 0;
		int tempShellLow = 0;
		int tempShellHigh = 0;
		
		using (StreamReader readFile = new StreamReader (Application.dataPath + "/Database/PlayerCurves.txt")) {
			
			string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/PlayerCurves.txt");

			for (int i = 0; i < fileInfo.Length; i++) {
				if(pace == (int.Parse (fileInfo[i]))) {
					tempBlood = (int.Parse (fileInfo[i + 1])) + (HeartCondition.BP * 50) + ((strPoints + dexPoints) * 25);
					tempLove = (int.Parse (fileInfo[i + 2])) + (HeartCondition.LP * 50) + ((intPoints + lukPoints) * 25);
					tempExp = (int.Parse (fileInfo[i + 3]));

					tempPumpLow = (int.Parse (fileInfo[i + 4])) + (strPoints * 25);
					tempPumpHigh = (int.Parse (fileInfo[i + 5])) + (strPoints * 50);
					
					tempLoveLow = (int.Parse (fileInfo[i + 6])) + (intPoints * 25);
					tempLoveHigh = (int.Parse (fileInfo[i + 7])) + (intPoints * 50);
					
					tempCardioLow = (int.Parse (fileInfo[i + 8])) + (dexPoints * 25);
					tempCardioHigh = (int.Parse (fileInfo[i + 9])) + (dexPoints * 50);
					
					tempShellLow = (int.Parse (fileInfo[i + 10])) + (lukPoints * 25);
					tempShellHigh = (int.Parse (fileInfo[i + 11])) + (lukPoints * 50);

					i = fileInfo.Length;
				}else {
					i += 14;
				}
			}
		} 

		blood = tempBlood;
		love = tempLove;
		exp = tempExp;
		pumpLow = tempPumpLow;
		pumpHigh = tempPumpHigh;
		loveLow = tempLoveLow;
		loveHigh = tempLoveHigh;
		cardioLow = tempCardioLow;
		cardioHigh = tempCardioHigh;
		shellLow = tempShellLow;
		shellHigh = tempShellHigh;
	}
	void Status(){
		FindLevel ();
	}
}
