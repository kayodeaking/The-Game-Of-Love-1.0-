using UnityEngine;
using System.Collections;

public class HandelPointsDisplay : MonoBehaviour {

	public static int tempSP = 100;
	public static int tempStrP;
	public static int tempIntP;
	public static int tempDexP;
	public static int tempLukP;
	public static int tempBlP = 500;
	public static int tempAffP = 250;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
			tempBlP += 50;
		}
	}

	public void IncAff() {
		if (tempSP > 0) {
			tempSP -= 1;
			tempAffP += 50;
		}
	}

}
