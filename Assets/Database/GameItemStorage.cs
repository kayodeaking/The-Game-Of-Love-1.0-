using UnityEngine;
using System.Collections;

public class GameItemStorage : MonoBehaviour {
	
	public static int aBPQuan = 0;
	public static string aBPName = "A+ Blood Pack";

	public static int phereQuan = 0;
	public static string phereName = "Pheremone";

	public static int bBPQuan = 0;
	public static string bBPName = "B+ Blood Pack";

	public static int loveMolQuan = 0;
	public static string loveMolName = "Love Molecule";

	public static int abBPQuan = 0;
	public static string abBPName = "AB+ Blood Pack";

	public static int loveDustQuan = 0;
	public static string loveDustName = "Love Dust";

	public static int ONegQuan = 0;
	public static string ONegName = "O- Blood Pack";

	public static int lovePotQuan = 0;
	public static string lovePotName = "Love Potion #9";

	public static int hPumpQuan = 0;
	public static string hPumpName = "Heart Pump";

	public static int aKissQuan = 0;
	public static string aKissName = "Air Kiss";

	public static int adrenQuan = 0;
	public static string adrenName = "Adrenaline";

	public static int nutPillQuan = 0;
	public static string nutPillName = "Nutrition Pill";

	public static int rageQuan = 0;
	public static string rageName = "Rage";

	public static int fKissQuan = 0;
	public static string fKissName = "Full Kiss";

	public static int epinPillQuan = 0;
	public static string epinPillName = "Epinephrine Pill";

	public static int hArmorQuan = 0;
	public static string hArmorName = "Heart Armor";

	public static int pKissQuan = 0;
	public static string pKissName = "Power Kiss";

	public static int lArmorQuan = 0;
	public static string lArmorName = "Love Armor";

	public static int uesSetQuan = 7;
	public static int uesInvQuan = 0;
	public static string uesName = "Unlocked Equipment Slots";

	public static int uisSetQuan = 7;
	public static int uisInvQuan = 0;
	public static string uisName = "Unlocked Inventory Slots";
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Slot1(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
		} else if (itemName == abBPQuan) {
			abBPQuan += itemQuan;
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
			} else {
			}
		}else {
		}

	}

	public static void Slot2(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
		}  else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
		} else if (itemName == abBPQuan) {
			abBPQuan += itemQuan;
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
			} else {
			}
		}else {
		}

	}

	public static void Slot3(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
		}  else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
		} else if (itemName == abBPQuan) {
			abBPQuan += itemQuan;
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
			} else {
			}
		}else {
		}

	}

	public static void Slot4(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
		}  else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
		} else if (itemName == abBPQuan) {
			abBPQuan += itemQuan;
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
			} else {
			}
		}else {
		}

	}

	public static void Slot5(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
		}  else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
		} else if (itemName == abBPQuan) {
			abBPQuan += itemQuan;
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
			} else {
			}
		}else {
		}

	}
}
