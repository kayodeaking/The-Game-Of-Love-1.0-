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

	public static int lossSetQuan = 1;
	public static int lossInvQuan = 0;
	public static string lossName = "Loss";

	public static int remSetQuan = 1;
	public static int remInvQuan = 0;
	public static string remName = "Remorse";
	
	public static int sadSetQuan = 1;
	public static int sadInvQuan = 0;
	public static string sadName = "Saddness";
	
	public static int bitSetQuan = 1;
	public static int bitInvQuan = 0;
	public static string bitName = "Bitterness";
	
	public static int sorSetQuan = 1;
	public static int sorInvQuan = 0;
	public static string sorName = "Sorrow";
	
	public static int loneSetQuan = 1;
	public static int loneInvQuan = 0;
	public static string loneName = "Loneliness";
	
	public static int misSetQuan = 1;
	public static int misInvQuan = 0;
	public static string misName = "Misery";
	
	public static int longSetQuan = 1;
	public static int longInvQuan = 0;
	public static string longName = "Longing";
	
	public static int needSetQuan = 1;
	public static int needInvQuan = 0;
	public static string needName = "Neediness";
	
	public static int disSetQuan = 1;
	public static int disInvQuan = 0;
	public static string disName = "Discontent";
	
	public static int gladSetQuan = 1;
	public static int gladInvQuan = 0;
	public static string gladName = "Glad";
	
	public static int happSetQuan = 1;
	public static int happInvQuan = 0;
	public static string happName = "Happiness";
	
	public static int hopeSetQuan = 1;
	public static int hopeInvQuan = 0;
	public static string hopeName = "Hope";
	
	public static int attSetQuan = 1;
	public static int attInvQuan = 0;
	public static string attName = "Attraction";
	
	public static int hostSetQuan = 1;
	public static int hostInvQuan = 0;
	public static string hostName = "Hostility";
	
	public static int rageWepSetQuan = 1;
	public static int rageWepInvQuan = 0;
	public static string rageWepName = "Rage";
	
	public static int passSetQuan = 1;
	public static int passInvQuan = 0;
	public static string passName = "Passion";
	
	public static int triSetQuan = 1;
	public static int triInvQuan = 0;
	public static string triName = "Triumph";
	
	public static int sandSetQuan = 1;
	public static int sandInvQuan = 0;
	public static string sandName = "Sandals";

	public static int leaGlovesSetQuan = 1;
	public static int leaGlovesInvQuan = 0;
	public static string leaGlovesName = "Leather Gloves";

	public static int leaStrapSetQuan = 1;
	public static int leaStrapInvQuan = 0;
	public static string leaStrapName = "Leather Strap";

	public static int bronShoesSetQuan = 1;
	public static int bronShoesInvQuan = 0;
	public static string bronShoesName = "Bronze Shoes";

	public static int bronGlovesSetQuan = 1;
	public static int bronGlovesInvQuan = 0;
	public static string bronGlovesName = "Bronze Gloves";
	
	public static int bronStrapSetQuan = 1;
	public static int bronStrapInvQuan = 0;
	public static string bronStrapName = "Bronze Strap";
	
	public static int ironShoesSetQuan = 1;
	public static int ironShoesInvQuan = 0;
	public static string ironShoesName = "Iron Shoes";

	public static int ironGlovesSetQuan = 1;
	public static int ironGlovesInvQuan = 0;
	public static string ironGlovesName = "Iron Gloves";
	
	public static int ironStrapSetQuan = 1;
	public static int ironStrapInvQuan = 0;
	public static string ironStrapName = "Iron Strap";
	
	public static int steelShoesSetQuan = 1;
	public static int steelShoesInvQuan = 0;
	public static string steelShoesName = "Steel Shoes";

	public static int steelGlovesSetQuan = 1;
	public static int steelGlovesInvQuan = 0;
	public static string steelGlovesName = "Steel Gloves";
	
	public static int steelStrapSetQuan = 1;
	public static int steelStrapInvQuan = 0;
	public static string steelStrapName = "Steel Strap";
	
	public static int bloodShoesSetQuan = 1;
	public static int bloodShoesInvQuan = 0;
	public static string bloodShoesName = "Blood Shoes";

	public static int bloodGlovesSetQuan = 1;
	public static int bloodGlovesInvQuan = 0;
	public static string bloodGlovesName = "Blood Gloves";
	
	public static int bloodStrapSetQuan = 1;
	public static int bloodStrapInvQuan = 0;
	public static string bloodStrapName = "Blood Strap";
	
	public static int loveShoesSetQuan = 1;
	public static int loveShoesInvQuan = 0;
	public static string loveShoesName = "Love Shoes";

	public static int loveGlovesSetQuan = 1;
	public static int loveGlovesInvQuan = 0;
	public static string loveGlovesName = "Love Gloves";
	
	public static int loveStrapSetQuan = 1;
	public static int loveStrapInvQuan = 0;
	public static string loveStrapName = "Love Strap";

	public static int uesSetQuan = 7;
	public static int uesInvQuan = 0;
	public static string uesName = "Unlock Equipment Slots";

	public static int uisSetQuan = 7;
	public static int uisInvQuan = 0;
	public static string uisName = "Unlock Inventory Slots";

	public static int incLv1SetQuan = 10;
	public static int incLv1InvQuan = 0;
	public static string incLv1Name = "Increase Level 1";

	public static int incLv2SetQuan = 10;
	public static int incLv2InvQuan = 0;
	public static string incLv2Name = "Increase Level 2";

	public static int incLv3SetQuan = 5;
	public static int incLv3InvQuan = 0;
	public static string incLv3Name = "Increase Level 3";

	public static int incLv4SetQuan = 10;
	public static int incLv4InvQuan = 0;
	public static string incLv4Name = "Increase Level 4";

	public static int incB1SetQuan = 5;
	public static int incB1InvQuan = 0;
	public static string incB1Name = "Increase Blood 1";

	public static int incB2SetQuan = 5;
	public static int incB2InvQuan = 0;
	public static string incB2Name = "Increase Blood 2";

	public static int incL1SetQuan = 5;
	public static int incL1InvQuan = 0;
	public static string incL1Name = "Increase Love 1";

	public static int incL2SetQuan = 5;
	public static int incL2InvQuan = 0;
	public static string incL2Name = "Increase Love 2";

	public static int incStr1SetQuan = 5;
	public static int incStr1InvQuan = 0;
	public static string incStr1Name = "Increase Strength 1";

	public static int incStr2SetQuan = 5;
	public static int incStr2InvQuan = 0;
	public static string incStr2Name = "Increase Strength 2";

	public static int incInt1SetQuan = 5;
	public static int incInt1InvQuan = 0;
	public static string incInt1Name = "Increase Intelligence 1";

	public static int incInt2SetQuan = 5;
	public static int incInt2InvQuan = 0;
	public static string incInt2Name = "Increase Intelligence 2";

	public static int incDex1SetQuan = 5;
	public static int incDex1InvQuan = 0;
	public static string incDex1Name = "Increase Dexterity 1";

	public static int incDex2SetQuan = 5;
	public static int incDex2InvQuan = 0;
	public static string incDex2Name = "Increase Dexterity 2";

	public static int incLuk1SetQuan = 5;
	public static int incLuk1InvQuan = 0;
	public static string incLuk1Name = "Increase Luck 1";

	public static int incLuk2SetQuan = 5;
	public static int incLuk2InvQuan = 0;
	public static string incLuk2Name = "Increase Luck 2";
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Slot1(string itemName, int itemQuan){

		if (itemName == aBPName) {
			aBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(aBPName, aBPQuan, false);
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
			AddToSlots.AddToInvSlot(phereName, phereQuan, false);
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(bBPName, bBPQuan, false);
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveMolName, loveMolQuan, false);
		} else if (itemName == abBPName) {
			abBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(abBPName, abBPQuan, false);
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveDustName, loveDustQuan, false);
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
			AddToSlots.AddToInvSlot(ONegName, ONegQuan, false);
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
			AddToSlots.AddToInvSlot(lovePotName, lovePotQuan, false);
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
			AddToSlots.AddToInvSlot(hPumpName, hPumpQuan, false);
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(aKissName, aKissQuan, false);
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
			AddToSlots.AddToInvSlot(adrenName, adrenQuan, false);
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(nutPillName, nutPillQuan, false);
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
			AddToSlots.AddToInvSlot(rageName, rageQuan, false);
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(fKissName, fKissQuan, false);
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(epinPillName, epinPillQuan, false);
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(hArmorName, hArmorQuan, false);
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(pKissName, pKissQuan, false);
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(lArmorName, lArmorQuan, false);
		} else if (itemName == lossName) {
			if(lossSetQuan > 0) {
				lossSetQuan -= itemQuan;
				lossInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(lossName, lossInvQuan, false);
			} else {
			}
		} else if (itemName == remName) {
			if(remSetQuan > 0) {
				remSetQuan -= itemQuan;
				remInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(remName, remInvQuan, false);
			} else {
			}
		} else if (itemName == sadName) {
			if(sadSetQuan > 0) {
				sadSetQuan -= itemQuan;
				sadInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sadName, sadInvQuan, false);
			} else {
			}
		} else if (itemName == bitName) {
			if(bitSetQuan > 0) {
				bitSetQuan -= itemQuan;
				bitInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bitName, bitInvQuan, false);
			} else {
			}
		} else if (itemName == sorName) {
			if(sorSetQuan > 0) {
				sorSetQuan -= itemQuan;
				sorInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sorName, sorInvQuan, false);
			} else {
			}
		} else if (itemName == loneName) {
			if(loneSetQuan > 0) {
				loneSetQuan -= itemQuan;
				loneInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loneName, loneInvQuan, false);
			} else {
			}
		} else if (itemName == misName) {
			if(misSetQuan > 0) {
				misSetQuan -= itemQuan;
				misInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(misName, misInvQuan, false);
			} else {
			}
		} else if (itemName == longName) {
			if(longSetQuan > 0) {
				longSetQuan -= itemQuan;
				longInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(longName, longInvQuan, false);
			} else {
			}
		} else if (itemName == needName) {
			if(needSetQuan > 0) {
				needSetQuan -= itemQuan;
				needInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(needName, needInvQuan, false);
			} else {
			}
		} else if (itemName == disName) {
			if(disSetQuan > 0) {
				disSetQuan -= itemQuan;
				disInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(disName, disInvQuan, false);
			} else {
			}
		}  else if (itemName == gladName) {
			if(gladSetQuan > 0) {
				gladSetQuan -= itemQuan;
				gladInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(gladName, gladInvQuan, false);
			} else {
			}
		} else if (itemName == happName) {
			if(happSetQuan > 0) {
				happSetQuan -= itemQuan;
				happInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(happName, happInvQuan, false);
			} else {
			}
		} else if (itemName == hopeName) {
			if(hopeSetQuan > 0) {
				hopeSetQuan -= itemQuan;
				hopeInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hopeName, hopeInvQuan, false);
			} else {
			}
		} else if (itemName == attName) {
			if(attSetQuan > 0) {
				attSetQuan -= itemQuan;
				attInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(attName, attInvQuan, false);
			} else {
			}
		} else if (itemName == hostName) {
			if(hostSetQuan > 0) {
				hostSetQuan -= itemQuan;
				hostInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hostName, hostInvQuan, false);
			} else {
			}
		} else if (itemName == rageWepName) {
			if(rageWepSetQuan > 0) {
				rageWepSetQuan -= itemQuan;
				rageWepInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(rageWepName, rageWepInvQuan, false);
			} else {
			}
		} else if (itemName == passName) {
			if(passSetQuan > 0) {
				passSetQuan -= itemQuan;
				passInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(passName, passInvQuan, false);
			} else {
			}
		} else if (itemName == triName) {
			if(triSetQuan > 0) {
				triSetQuan -= itemQuan;
				triInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(triName, triInvQuan, false);
			} else {
			}
		} else if (itemName == sandName) {
			if(sandSetQuan > 0) {
				sandSetQuan -= itemQuan;
				sandInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sandName, sandInvQuan, false);
			} else {
			}
		} else if (itemName == leaGlovesName) {
			if(leaGlovesSetQuan > 0) {
				leaGlovesSetQuan -= itemQuan;
				leaGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaGlovesName, leaGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == leaStrapName) {
			if(leaStrapSetQuan > 0) {
				leaStrapSetQuan -= itemQuan;
				leaStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaStrapName, leaStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bronShoesName) {
			if(bronShoesSetQuan > 0) {
				bronShoesSetQuan -= itemQuan;
				bronShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronShoesName, bronShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bronGlovesName) {
			if(bronGlovesSetQuan > 0) {
				bronGlovesSetQuan -= itemQuan;
				bronGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronGlovesName, bronGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bronStrapName) {
			if(bronStrapSetQuan > 0) {
				bronStrapSetQuan -= itemQuan;
				bronStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronStrapName, bronStrapInvQuan, false);
			} else {
			}
		} else if (itemName == ironShoesName) {
			if(ironShoesSetQuan > 0) {
				ironShoesSetQuan -= itemQuan;
				ironShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironShoesName, ironShoesInvQuan, false);
			} else {
			}
		} else if (itemName == ironGlovesName) {
			if(ironGlovesSetQuan > 0) {
				ironGlovesSetQuan -= itemQuan;
				ironGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironGlovesName, ironGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == ironStrapName) {
			if(ironStrapSetQuan > 0) {
				ironStrapSetQuan -= itemQuan;
				ironStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironStrapName, ironStrapInvQuan, false);
			} else {
			}
		} else if (itemName == steelShoesName) {
			if(steelShoesSetQuan > 0) {
				steelShoesSetQuan -= itemQuan;
				steelShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelShoesName, steelShoesInvQuan, false);
			} else {
			}
		} else if (itemName == steelGlovesName) {
			if(steelGlovesSetQuan > 0) {
				steelGlovesSetQuan -= itemQuan;
				steelGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelGlovesName, steelGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == steelStrapName) {
			if(steelStrapSetQuan > 0) {
				steelStrapSetQuan -= itemQuan;
				steelStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelStrapName, steelStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bloodShoesName) {
			if(bloodShoesSetQuan > 0) {
				bloodShoesSetQuan -= itemQuan;
				bloodShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodShoesName, bloodShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodGlovesName) {
			if(bloodGlovesSetQuan > 0) {
				bloodGlovesSetQuan -= itemQuan;
				bloodGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodGlovesName, bloodGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodStrapName) {
			if(bloodStrapSetQuan > 0) {
				bloodStrapSetQuan -= itemQuan;
				bloodStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodStrapName, bloodStrapInvQuan, false);
			} else {
			}
		} else if (itemName == loveShoesName) {
			if(loveShoesSetQuan > 0) {
				loveShoesSetQuan -= itemQuan;
				loveShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveShoesName, loveShoesInvQuan, false);
			} else {
			}
		} else if (itemName == loveGlovesName) {
			if(loveGlovesSetQuan > 0) {
				loveGlovesSetQuan -= itemQuan;
				loveGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveGlovesName, loveGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == loveStrapName) {
			if(loveStrapSetQuan > 0) {
				loveStrapSetQuan -= itemQuan;
				loveStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveStrapName, loveStrapInvQuan, false);
			} else {
			}
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uesName, uesInvQuan, false);
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uisName, uisInvQuan, false);
			} else {
			}
		} else if (itemName == incLv1Name) {
			if(incLv1SetQuan > 0) {
				incLv1SetQuan -= itemQuan;
				incLv1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv1Name, incLv1InvQuan, false);
			} else {
			}
		} else if (itemName == incLv2Name) {
			if(incLv2SetQuan > 0) {
				incLv2SetQuan -= itemQuan;
				incLv2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv2Name, incLv2InvQuan, false);
			} else {
			}
		} else if (itemName == incLv3Name) {
			if(incLv3SetQuan > 0) {
				incLv3SetQuan -= itemQuan;
				incLv3InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv3Name, incLv3InvQuan, false);
			} else {
			}
		} else if (itemName == incLv4Name) {
			if(incLv4SetQuan > 0) {
				incLv4SetQuan -= itemQuan;
				incLv4InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv4Name, incLv4InvQuan, false);
			} else {
			}
		} else if (itemName == incB1Name) {
			if(incB1SetQuan > 0) {
				incB1SetQuan -= itemQuan;
				incB1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB1Name, incB1InvQuan, false);
			} else {
			}
		} else if (itemName == incB2Name) {
			if(incB2SetQuan > 0) {
				incB2SetQuan -= itemQuan;
				incB2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB2Name, incB2InvQuan, false);
			} else {
			}
		} else if (itemName == incL1Name) {
			if(incL1SetQuan > 0) {
				incL1SetQuan -= itemQuan;
				incL1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL1Name, incL1InvQuan, false);
			} else {
			}
		} else if (itemName == incL2Name) {
			if(incL2SetQuan > 0) {
				incL2SetQuan -= itemQuan;
				incL2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL2Name, incL2InvQuan, false);
			} else {
			}
		} else if (itemName == incStr1Name) {
			if(incStr1SetQuan > 0) {
				incStr1SetQuan -= itemQuan;
				incStr1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr1Name, incStr1InvQuan, false);
			} else {
			}
		} else if (itemName == incStr2Name) {
			if(incStr2SetQuan > 0) {
				incStr2SetQuan -= itemQuan;
				incStr2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr2Name, incStr2InvQuan, false);
			} else {
			}
		} else if (itemName == incInt1Name) {
			if(incInt1SetQuan > 0) {
				incInt1SetQuan -= itemQuan;
				incInt1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt1Name, incInt1InvQuan, false);
			} else {
			}
		} else if (itemName == incInt2Name) {
			if(incInt2SetQuan > 0) {
				incInt2SetQuan -= itemQuan;
				incInt2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt2Name, incInt2InvQuan, false);
			} else {
			}
		} else if (itemName == incDex1Name) {
			if(incDex1SetQuan > 0) {
				incDex1SetQuan -= itemQuan;
				incDex1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex1Name, incDex1InvQuan, false);
			} else {
			}
		} else if (itemName == incDex2Name) {
			if(incDex2SetQuan > 0) {
				incDex2SetQuan -= itemQuan;
				incDex2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex2Name, incDex2InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk1Name) {
			if(incLuk1SetQuan > 0) {
				incLuk1SetQuan -= itemQuan;
				incLuk1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk1Name, incLuk1InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk2Name) {
			if(incLuk2SetQuan > 0) {
				incLuk2SetQuan -= itemQuan;
				incLuk2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk2Name, incLuk2InvQuan, false);
			} else {
			}
		}  else {
		}
	}

	public static void Slot2(string itemName, int itemQuan){
		
		if (itemName == aBPName) {
			aBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(aBPName, aBPQuan, false);
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
			AddToSlots.AddToInvSlot(phereName, phereQuan, false);
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(bBPName, bBPQuan, false);
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveMolName, loveMolQuan, false);
		} else if (itemName == abBPName) {
			abBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(abBPName, abBPQuan, false);
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveDustName, loveDustQuan, false);
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
			AddToSlots.AddToInvSlot(ONegName, ONegQuan, false);
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
			AddToSlots.AddToInvSlot(lovePotName, lovePotQuan, false);
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
			AddToSlots.AddToInvSlot(hPumpName, hPumpQuan, false);
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(aKissName, aKissQuan, false);
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
			AddToSlots.AddToInvSlot(adrenName, adrenQuan, false);
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(nutPillName, nutPillQuan, false);
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
			AddToSlots.AddToInvSlot(rageName, rageQuan, false);
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(fKissName, fKissQuan, false);
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(epinPillName, epinPillQuan, false);
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(hArmorName, hArmorQuan, false);
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(pKissName, pKissQuan, false);
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(lArmorName, lArmorQuan, false);
		} else if (itemName == lossName) {
			if(lossSetQuan > 0) {
				lossSetQuan -= itemQuan;
				lossInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(lossName, lossInvQuan, false);
			} else {
			}
		} else if (itemName == remName) {
			if(remSetQuan > 0) {
				remSetQuan -= itemQuan;
				remInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(remName, remInvQuan, false);
			} else {
			}
		} else if (itemName == sadName) {
			if(sadSetQuan > 0) {
				sadSetQuan -= itemQuan;
				sadInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sadName, sadInvQuan, false);
			} else {
			}
		} else if (itemName == bitName) {
			if(bitSetQuan > 0) {
				bitSetQuan -= itemQuan;
				bitInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bitName, bitInvQuan, false);
			} else {
			}
		} else if (itemName == sorName) {
			if(sorSetQuan > 0) {
				sorSetQuan -= itemQuan;
				sorInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sorName, sorInvQuan, false);
			} else {
			}
		} else if (itemName == loneName) {
			if(loneSetQuan > 0) {
				loneSetQuan -= itemQuan;
				loneInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loneName, loneInvQuan, false);
			} else {
			}
		} else if (itemName == misName) {
			if(misSetQuan > 0) {
				misSetQuan -= itemQuan;
				misInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(misName, misInvQuan, false);
			} else {
			}
		} else if (itemName == longName) {
			if(longSetQuan > 0) {
				longSetQuan -= itemQuan;
				longInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(longName, longInvQuan, false);
			} else {
			}
		} else if (itemName == needName) {
			if(needSetQuan > 0) {
				needSetQuan -= itemQuan;
				needInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(needName, needInvQuan, false);
			} else {
			}
		} else if (itemName == disName) {
			if(disSetQuan > 0) {
				disSetQuan -= itemQuan;
				disInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(disName, disInvQuan, false);
			} else {
			}
		}  else if (itemName == gladName) {
			if(gladSetQuan > 0) {
				gladSetQuan -= itemQuan;
				gladInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(gladName, gladInvQuan, false);
			} else {
			}
		} else if (itemName == happName) {
			if(happSetQuan > 0) {
				happSetQuan -= itemQuan;
				happInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(happName, happInvQuan, false);
			} else {
			}
		} else if (itemName == hopeName) {
			if(hopeSetQuan > 0) {
				hopeSetQuan -= itemQuan;
				hopeInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hopeName, hopeInvQuan, false);
			} else {
			}
		} else if (itemName == attName) {
			if(attSetQuan > 0) {
				attSetQuan -= itemQuan;
				attInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(attName, attInvQuan, false);
			} else {
			}
		} else if (itemName == hostName) {
			if(hostSetQuan > 0) {
				hostSetQuan -= itemQuan;
				hostInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hostName, hostInvQuan, false);
			} else {
			}
		} else if (itemName == rageWepName) {
			if(rageWepSetQuan > 0) {
				rageWepSetQuan -= itemQuan;
				rageWepInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(rageWepName, rageWepInvQuan, false);
			} else {
			}
		} else if (itemName == passName) {
			if(passSetQuan > 0) {
				passSetQuan -= itemQuan;
				passInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(passName, passInvQuan, false);
			} else {
			}
		} else if (itemName == triName) {
			if(triSetQuan > 0) {
				triSetQuan -= itemQuan;
				triInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(triName, triInvQuan, false);
			} else {
			}
		} else if (itemName == sandName) {
			if(sandSetQuan > 0) {
				sandSetQuan -= itemQuan;
				sandInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sandName, sandInvQuan, false);
			} else {
			}
		} else if (itemName == leaGlovesName) {
			if(leaGlovesSetQuan > 0) {
				leaGlovesSetQuan -= itemQuan;
				leaGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaGlovesName, leaGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == leaStrapName) {
			if(leaStrapSetQuan > 0) {
				leaStrapSetQuan -= itemQuan;
				leaStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaStrapName, leaStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bronShoesName) {
			if(bronShoesSetQuan > 0) {
				bronShoesSetQuan -= itemQuan;
				bronShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronShoesName, bronShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bronGlovesName) {
			if(bronGlovesSetQuan > 0) {
				bronGlovesSetQuan -= itemQuan;
				bronGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronGlovesName, bronGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bronStrapName) {
			if(bronStrapSetQuan > 0) {
				bronStrapSetQuan -= itemQuan;
				bronStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronStrapName, bronStrapInvQuan, false);
			} else {
			}
		} else if (itemName == ironShoesName) {
			if(ironShoesSetQuan > 0) {
				ironShoesSetQuan -= itemQuan;
				ironShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironShoesName, ironShoesInvQuan, false);
			} else {
			}
		} else if (itemName == ironGlovesName) {
			if(ironGlovesSetQuan > 0) {
				ironGlovesSetQuan -= itemQuan;
				ironGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironGlovesName, ironGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == ironStrapName) {
			if(ironStrapSetQuan > 0) {
				ironStrapSetQuan -= itemQuan;
				ironStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironStrapName, ironStrapInvQuan, false);
			} else {
			}
		} else if (itemName == steelShoesName) {
			if(steelShoesSetQuan > 0) {
				steelShoesSetQuan -= itemQuan;
				steelShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelShoesName, steelShoesInvQuan, false);
			} else {
			}
		} else if (itemName == steelGlovesName) {
			if(steelGlovesSetQuan > 0) {
				steelGlovesSetQuan -= itemQuan;
				steelGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelGlovesName, steelGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == steelStrapName) {
			if(steelStrapSetQuan > 0) {
				steelStrapSetQuan -= itemQuan;
				steelStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelStrapName, steelStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bloodShoesName) {
			if(bloodShoesSetQuan > 0) {
				bloodShoesSetQuan -= itemQuan;
				bloodShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodShoesName, bloodShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodGlovesName) {
			if(bloodGlovesSetQuan > 0) {
				bloodGlovesSetQuan -= itemQuan;
				bloodGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodGlovesName, bloodGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodStrapName) {
			if(bloodStrapSetQuan > 0) {
				bloodStrapSetQuan -= itemQuan;
				bloodStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodStrapName, bloodStrapInvQuan, false);
			} else {
			}
		} else if (itemName == loveShoesName) {
			if(loveShoesSetQuan > 0) {
				loveShoesSetQuan -= itemQuan;
				loveShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveShoesName, loveShoesInvQuan, false);
			} else {
			}
		} else if (itemName == loveGlovesName) {
			if(loveGlovesSetQuan > 0) {
				loveGlovesSetQuan -= itemQuan;
				loveGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveGlovesName, loveGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == loveStrapName) {
			if(loveStrapSetQuan > 0) {
				loveStrapSetQuan -= itemQuan;
				loveStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveStrapName, loveStrapInvQuan, false);
			} else {
			}
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uesName, uesInvQuan, false);
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uisName, uisInvQuan, false);
			} else {
			}
		} else if (itemName == incLv1Name) {
			if(incLv1SetQuan > 0) {
				incLv1SetQuan -= itemQuan;
				incLv1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv1Name, incLv1InvQuan, false);
			} else {
			}
		} else if (itemName == incLv2Name) {
			if(incLv2SetQuan > 0) {
				incLv2SetQuan -= itemQuan;
				incLv2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv2Name, incLv2InvQuan, false);
			} else {
			}
		} else if (itemName == incLv3Name) {
			if(incLv3SetQuan > 0) {
				incLv3SetQuan -= itemQuan;
				incLv3InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv3Name, incLv3InvQuan, false);
			} else {
			}
		} else if (itemName == incLv4Name) {
			if(incLv4SetQuan > 0) {
				incLv4SetQuan -= itemQuan;
				incLv4InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv4Name, incLv4InvQuan, false);
			} else {
			}
		} else if (itemName == incB1Name) {
			if(incB1SetQuan > 0) {
				incB1SetQuan -= itemQuan;
				incB1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB1Name, incB1InvQuan, false);
			} else {
			}
		} else if (itemName == incB2Name) {
			if(incB2SetQuan > 0) {
				incB2SetQuan -= itemQuan;
				incB2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB2Name, incB2InvQuan, false);
			} else {
			}
		} else if (itemName == incL1Name) {
			if(incL1SetQuan > 0) {
				incL1SetQuan -= itemQuan;
				incL1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL1Name, incL1InvQuan, false);
			} else {
			}
		} else if (itemName == incL2Name) {
			if(incL2SetQuan > 0) {
				incL2SetQuan -= itemQuan;
				incL2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL2Name, incL2InvQuan, false);
			} else {
			}
		} else if (itemName == incStr1Name) {
			if(incStr1SetQuan > 0) {
				incStr1SetQuan -= itemQuan;
				incStr1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr1Name, incStr1InvQuan, false);
			} else {
			}
		} else if (itemName == incStr2Name) {
			if(incStr2SetQuan > 0) {
				incStr2SetQuan -= itemQuan;
				incStr2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr2Name, incStr2InvQuan, false);
			} else {
			}
		} else if (itemName == incInt1Name) {
			if(incInt1SetQuan > 0) {
				incInt1SetQuan -= itemQuan;
				incInt1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt1Name, incInt1InvQuan, false);
			} else {
			}
		} else if (itemName == incInt2Name) {
			if(incInt2SetQuan > 0) {
				incInt2SetQuan -= itemQuan;
				incInt2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt2Name, incInt2InvQuan, false);
			} else {
			}
		} else if (itemName == incDex1Name) {
			if(incDex1SetQuan > 0) {
				incDex1SetQuan -= itemQuan;
				incDex1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex1Name, incDex1InvQuan, false);
			} else {
			}
		} else if (itemName == incDex2Name) {
			if(incDex2SetQuan > 0) {
				incDex2SetQuan -= itemQuan;
				incDex2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex2Name, incDex2InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk1Name) {
			if(incLuk1SetQuan > 0) {
				incLuk1SetQuan -= itemQuan;
				incLuk1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk1Name, incLuk1InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk2Name) {
			if(incLuk2SetQuan > 0) {
				incLuk2SetQuan -= itemQuan;
				incLuk2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk2Name, incLuk2InvQuan, false);
			} else {
			}
		}  else {
		}
	}

	public static void Slot3(string itemName, int itemQuan){
		
		if (itemName == aBPName) {
			aBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(aBPName, aBPQuan, false);
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
			AddToSlots.AddToInvSlot(phereName, phereQuan, false);
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(bBPName, bBPQuan, false);
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveMolName, loveMolQuan, false);
		} else if (itemName == abBPName) {
			abBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(abBPName, abBPQuan, false);
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveDustName, loveDustQuan, false);
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
			AddToSlots.AddToInvSlot(ONegName, ONegQuan, false);
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
			AddToSlots.AddToInvSlot(lovePotName, lovePotQuan, false);
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
			AddToSlots.AddToInvSlot(hPumpName, hPumpQuan, false);
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(aKissName, aKissQuan, false);
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
			AddToSlots.AddToInvSlot(adrenName, adrenQuan, false);
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(nutPillName, nutPillQuan, false);
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
			AddToSlots.AddToInvSlot(rageName, rageQuan, false);
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(fKissName, fKissQuan, false);
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(epinPillName, epinPillQuan, false);
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(hArmorName, hArmorQuan, false);
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(pKissName, pKissQuan, false);
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(lArmorName, lArmorQuan, false);
		} else if (itemName == lossName) {
			if(lossSetQuan > 0) {
				lossSetQuan -= itemQuan;
				lossInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(lossName, lossInvQuan, false);
			} else {
			}
		} else if (itemName == remName) {
			if(remSetQuan > 0) {
				remSetQuan -= itemQuan;
				remInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(remName, remInvQuan, false);
			} else {
			}
		} else if (itemName == sadName) {
			if(sadSetQuan > 0) {
				sadSetQuan -= itemQuan;
				sadInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sadName, sadInvQuan, false);
			} else {
			}
		} else if (itemName == bitName) {
			if(bitSetQuan > 0) {
				bitSetQuan -= itemQuan;
				bitInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bitName, bitInvQuan, false);
			} else {
			}
		} else if (itemName == sorName) {
			if(sorSetQuan > 0) {
				sorSetQuan -= itemQuan;
				sorInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sorName, sorInvQuan, false);
			} else {
			}
		} else if (itemName == loneName) {
			if(loneSetQuan > 0) {
				loneSetQuan -= itemQuan;
				loneInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loneName, loneInvQuan, false);
			} else {
			}
		} else if (itemName == misName) {
			if(misSetQuan > 0) {
				misSetQuan -= itemQuan;
				misInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(misName, misInvQuan, false);
			} else {
			}
		} else if (itemName == longName) {
			if(longSetQuan > 0) {
				longSetQuan -= itemQuan;
				longInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(longName, longInvQuan, false);
			} else {
			}
		} else if (itemName == needName) {
			if(needSetQuan > 0) {
				needSetQuan -= itemQuan;
				needInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(needName, needInvQuan, false);
			} else {
			}
		} else if (itemName == disName) {
			if(disSetQuan > 0) {
				disSetQuan -= itemQuan;
				disInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(disName, disInvQuan, false);
			} else {
			}
		}  else if (itemName == gladName) {
			if(gladSetQuan > 0) {
				gladSetQuan -= itemQuan;
				gladInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(gladName, gladInvQuan, false);
			} else {
			}
		} else if (itemName == happName) {
			if(happSetQuan > 0) {
				happSetQuan -= itemQuan;
				happInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(happName, happInvQuan, false);
			} else {
			}
		} else if (itemName == hopeName) {
			if(hopeSetQuan > 0) {
				hopeSetQuan -= itemQuan;
				hopeInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hopeName, hopeInvQuan, false);
			} else {
			}
		} else if (itemName == attName) {
			if(attSetQuan > 0) {
				attSetQuan -= itemQuan;
				attInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(attName, attInvQuan, false);
			} else {
			}
		} else if (itemName == hostName) {
			if(hostSetQuan > 0) {
				hostSetQuan -= itemQuan;
				hostInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hostName, hostInvQuan, false);
			} else {
			}
		} else if (itemName == rageWepName) {
			if(rageWepSetQuan > 0) {
				rageWepSetQuan -= itemQuan;
				rageWepInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(rageWepName, rageWepInvQuan, false);
			} else {
			}
		} else if (itemName == passName) {
			if(passSetQuan > 0) {
				passSetQuan -= itemQuan;
				passInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(passName, passInvQuan, false);
			} else {
			}
		} else if (itemName == triName) {
			if(triSetQuan > 0) {
				triSetQuan -= itemQuan;
				triInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(triName, triInvQuan, false);
			} else {
			}
		} else if (itemName == sandName) {
			if(sandSetQuan > 0) {
				sandSetQuan -= itemQuan;
				sandInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sandName, sandInvQuan, false);
			} else {
			}
		} else if (itemName == leaGlovesName) {
			if(leaGlovesSetQuan > 0) {
				leaGlovesSetQuan -= itemQuan;
				leaGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaGlovesName, leaGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == leaStrapName) {
			if(leaStrapSetQuan > 0) {
				leaStrapSetQuan -= itemQuan;
				leaStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaStrapName, leaStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bronShoesName) {
			if(bronShoesSetQuan > 0) {
				bronShoesSetQuan -= itemQuan;
				bronShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronShoesName, bronShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bronGlovesName) {
			if(bronGlovesSetQuan > 0) {
				bronGlovesSetQuan -= itemQuan;
				bronGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronGlovesName, bronGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bronStrapName) {
			if(bronStrapSetQuan > 0) {
				bronStrapSetQuan -= itemQuan;
				bronStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronStrapName, bronStrapInvQuan, false);
			} else {
			}
		} else if (itemName == ironShoesName) {
			if(ironShoesSetQuan > 0) {
				ironShoesSetQuan -= itemQuan;
				ironShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironShoesName, ironShoesInvQuan, false);
			} else {
			}
		} else if (itemName == ironGlovesName) {
			if(ironGlovesSetQuan > 0) {
				ironGlovesSetQuan -= itemQuan;
				ironGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironGlovesName, ironGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == ironStrapName) {
			if(ironStrapSetQuan > 0) {
				ironStrapSetQuan -= itemQuan;
				ironStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironStrapName, ironStrapInvQuan, false);
			} else {
			}
		} else if (itemName == steelShoesName) {
			if(steelShoesSetQuan > 0) {
				steelShoesSetQuan -= itemQuan;
				steelShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelShoesName, steelShoesInvQuan, false);
			} else {
			}
		} else if (itemName == steelGlovesName) {
			if(steelGlovesSetQuan > 0) {
				steelGlovesSetQuan -= itemQuan;
				steelGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelGlovesName, steelGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == steelStrapName) {
			if(steelStrapSetQuan > 0) {
				steelStrapSetQuan -= itemQuan;
				steelStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelStrapName, steelStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bloodShoesName) {
			if(bloodShoesSetQuan > 0) {
				bloodShoesSetQuan -= itemQuan;
				bloodShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodShoesName, bloodShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodGlovesName) {
			if(bloodGlovesSetQuan > 0) {
				bloodGlovesSetQuan -= itemQuan;
				bloodGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodGlovesName, bloodGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodStrapName) {
			if(bloodStrapSetQuan > 0) {
				bloodStrapSetQuan -= itemQuan;
				bloodStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodStrapName, bloodStrapInvQuan, false);
			} else {
			}
		} else if (itemName == loveShoesName) {
			if(loveShoesSetQuan > 0) {
				loveShoesSetQuan -= itemQuan;
				loveShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveShoesName, loveShoesInvQuan, false);
			} else {
			}
		} else if (itemName == loveGlovesName) {
			if(loveGlovesSetQuan > 0) {
				loveGlovesSetQuan -= itemQuan;
				loveGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveGlovesName, loveGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == loveStrapName) {
			if(loveStrapSetQuan > 0) {
				loveStrapSetQuan -= itemQuan;
				loveStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveStrapName, loveStrapInvQuan, false);
			} else {
			}
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uesName, uesInvQuan, false);
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uisName, uisInvQuan, false);
			} else {
			}
		} else if (itemName == incLv1Name) {
			if(incLv1SetQuan > 0) {
				incLv1SetQuan -= itemQuan;
				incLv1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv1Name, incLv1InvQuan, false);
			} else {
			}
		} else if (itemName == incLv2Name) {
			if(incLv2SetQuan > 0) {
				incLv2SetQuan -= itemQuan;
				incLv2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv2Name, incLv2InvQuan, false);
			} else {
			}
		} else if (itemName == incLv3Name) {
			if(incLv3SetQuan > 0) {
				incLv3SetQuan -= itemQuan;
				incLv3InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv3Name, incLv3InvQuan, false);
			} else {
			}
		} else if (itemName == incLv4Name) {
			if(incLv4SetQuan > 0) {
				incLv4SetQuan -= itemQuan;
				incLv4InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv4Name, incLv4InvQuan, false);
			} else {
			}
		} else if (itemName == incB1Name) {
			if(incB1SetQuan > 0) {
				incB1SetQuan -= itemQuan;
				incB1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB1Name, incB1InvQuan, false);
			} else {
			}
		} else if (itemName == incB2Name) {
			if(incB2SetQuan > 0) {
				incB2SetQuan -= itemQuan;
				incB2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB2Name, incB2InvQuan, false);
			} else {
			}
		} else if (itemName == incL1Name) {
			if(incL1SetQuan > 0) {
				incL1SetQuan -= itemQuan;
				incL1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL1Name, incL1InvQuan, false);
			} else {
			}
		} else if (itemName == incL2Name) {
			if(incL2SetQuan > 0) {
				incL2SetQuan -= itemQuan;
				incL2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL2Name, incL2InvQuan, false);
			} else {
			}
		} else if (itemName == incStr1Name) {
			if(incStr1SetQuan > 0) {
				incStr1SetQuan -= itemQuan;
				incStr1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr1Name, incStr1InvQuan, false);
			} else {
			}
		} else if (itemName == incStr2Name) {
			if(incStr2SetQuan > 0) {
				incStr2SetQuan -= itemQuan;
				incStr2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr2Name, incStr2InvQuan, false);
			} else {
			}
		} else if (itemName == incInt1Name) {
			if(incInt1SetQuan > 0) {
				incInt1SetQuan -= itemQuan;
				incInt1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt1Name, incInt1InvQuan, false);
			} else {
			}
		} else if (itemName == incInt2Name) {
			if(incInt2SetQuan > 0) {
				incInt2SetQuan -= itemQuan;
				incInt2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt2Name, incInt2InvQuan, false);
			} else {
			}
		} else if (itemName == incDex1Name) {
			if(incDex1SetQuan > 0) {
				incDex1SetQuan -= itemQuan;
				incDex1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex1Name, incDex1InvQuan, false);
			} else {
			}
		} else if (itemName == incDex2Name) {
			if(incDex2SetQuan > 0) {
				incDex2SetQuan -= itemQuan;
				incDex2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex2Name, incDex2InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk1Name) {
			if(incLuk1SetQuan > 0) {
				incLuk1SetQuan -= itemQuan;
				incLuk1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk1Name, incLuk1InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk2Name) {
			if(incLuk2SetQuan > 0) {
				incLuk2SetQuan -= itemQuan;
				incLuk2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk2Name, incLuk2InvQuan, false);
			} else {
			}
		}  else {
		}
	}

	public static void Slot4(string itemName, int itemQuan){
		
		if (itemName == aBPName) {
			aBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(aBPName, aBPQuan, false);
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
			AddToSlots.AddToInvSlot(phereName, phereQuan, false);
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(bBPName, bBPQuan, false);
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveMolName, loveMolQuan, false);
		} else if (itemName == abBPName) {
			abBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(abBPName, abBPQuan, false);
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveDustName, loveDustQuan, false);
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
			AddToSlots.AddToInvSlot(ONegName, ONegQuan, false);
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
			AddToSlots.AddToInvSlot(lovePotName, lovePotQuan, false);
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
			AddToSlots.AddToInvSlot(hPumpName, hPumpQuan, false);
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(aKissName, aKissQuan, false);
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
			AddToSlots.AddToInvSlot(adrenName, adrenQuan, false);
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(nutPillName, nutPillQuan, false);
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
			AddToSlots.AddToInvSlot(rageName, rageQuan, false);
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(fKissName, fKissQuan, false);
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(epinPillName, epinPillQuan, false);
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(hArmorName, hArmorQuan, false);
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(pKissName, pKissQuan, false);
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(lArmorName, lArmorQuan, false);
		} else if (itemName == lossName) {
			if(lossSetQuan > 0) {
				lossSetQuan -= itemQuan;
				lossInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(lossName, lossInvQuan, false);
			} else {
			}
		} else if (itemName == remName) {
			if(remSetQuan > 0) {
				remSetQuan -= itemQuan;
				remInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(remName, remInvQuan, false);
			} else {
			}
		} else if (itemName == sadName) {
			if(sadSetQuan > 0) {
				sadSetQuan -= itemQuan;
				sadInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sadName, sadInvQuan, false);
			} else {
			}
		} else if (itemName == bitName) {
			if(bitSetQuan > 0) {
				bitSetQuan -= itemQuan;
				bitInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bitName, bitInvQuan, false);
			} else {
			}
		} else if (itemName == sorName) {
			if(sorSetQuan > 0) {
				sorSetQuan -= itemQuan;
				sorInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sorName, sorInvQuan, false);
			} else {
			}
		} else if (itemName == loneName) {
			if(loneSetQuan > 0) {
				loneSetQuan -= itemQuan;
				loneInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loneName, loneInvQuan, false);
			} else {
			}
		} else if (itemName == misName) {
			if(misSetQuan > 0) {
				misSetQuan -= itemQuan;
				misInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(misName, misInvQuan, false);
			} else {
			}
		} else if (itemName == longName) {
			if(longSetQuan > 0) {
				longSetQuan -= itemQuan;
				longInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(longName, longInvQuan, false);
			} else {
			}
		} else if (itemName == needName) {
			if(needSetQuan > 0) {
				needSetQuan -= itemQuan;
				needInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(needName, needInvQuan, false);
			} else {
			}
		} else if (itemName == disName) {
			if(disSetQuan > 0) {
				disSetQuan -= itemQuan;
				disInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(disName, disInvQuan, false);
			} else {
			}
		}  else if (itemName == gladName) {
			if(gladSetQuan > 0) {
				gladSetQuan -= itemQuan;
				gladInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(gladName, gladInvQuan, false);
			} else {
			}
		} else if (itemName == happName) {
			if(happSetQuan > 0) {
				happSetQuan -= itemQuan;
				happInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(happName, happInvQuan, false);
			} else {
			}
		} else if (itemName == hopeName) {
			if(hopeSetQuan > 0) {
				hopeSetQuan -= itemQuan;
				hopeInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hopeName, hopeInvQuan, false);
			} else {
			}
		} else if (itemName == attName) {
			if(attSetQuan > 0) {
				attSetQuan -= itemQuan;
				attInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(attName, attInvQuan, false);
			} else {
			}
		} else if (itemName == hostName) {
			if(hostSetQuan > 0) {
				hostSetQuan -= itemQuan;
				hostInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hostName, hostInvQuan, false);
			} else {
			}
		} else if (itemName == rageWepName) {
			if(rageWepSetQuan > 0) {
				rageWepSetQuan -= itemQuan;
				rageWepInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(rageWepName, rageWepInvQuan, false);
			} else {
			}
		} else if (itemName == passName) {
			if(passSetQuan > 0) {
				passSetQuan -= itemQuan;
				passInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(passName, passInvQuan, false);
			} else {
			}
		} else if (itemName == triName) {
			if(triSetQuan > 0) {
				triSetQuan -= itemQuan;
				triInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(triName, triInvQuan, false);
			} else {
			}
		} else if (itemName == sandName) {
			if(sandSetQuan > 0) {
				sandSetQuan -= itemQuan;
				sandInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sandName, sandInvQuan, false);
			} else {
			}
		} else if (itemName == leaGlovesName) {
			if(leaGlovesSetQuan > 0) {
				leaGlovesSetQuan -= itemQuan;
				leaGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaGlovesName, leaGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == leaStrapName) {
			if(leaStrapSetQuan > 0) {
				leaStrapSetQuan -= itemQuan;
				leaStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaStrapName, leaStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bronShoesName) {
			if(bronShoesSetQuan > 0) {
				bronShoesSetQuan -= itemQuan;
				bronShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronShoesName, bronShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bronGlovesName) {
			if(bronGlovesSetQuan > 0) {
				bronGlovesSetQuan -= itemQuan;
				bronGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronGlovesName, bronGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bronStrapName) {
			if(bronStrapSetQuan > 0) {
				bronStrapSetQuan -= itemQuan;
				bronStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronStrapName, bronStrapInvQuan, false);
			} else {
			}
		} else if (itemName == ironShoesName) {
			if(ironShoesSetQuan > 0) {
				ironShoesSetQuan -= itemQuan;
				ironShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironShoesName, ironShoesInvQuan, false);
			} else {
			}
		} else if (itemName == ironGlovesName) {
			if(ironGlovesSetQuan > 0) {
				ironGlovesSetQuan -= itemQuan;
				ironGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironGlovesName, ironGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == ironStrapName) {
			if(ironStrapSetQuan > 0) {
				ironStrapSetQuan -= itemQuan;
				ironStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironStrapName, ironStrapInvQuan, false);
			} else {
			}
		} else if (itemName == steelShoesName) {
			if(steelShoesSetQuan > 0) {
				steelShoesSetQuan -= itemQuan;
				steelShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelShoesName, steelShoesInvQuan, false);
			} else {
			}
		} else if (itemName == steelGlovesName) {
			if(steelGlovesSetQuan > 0) {
				steelGlovesSetQuan -= itemQuan;
				steelGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelGlovesName, steelGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == steelStrapName) {
			if(steelStrapSetQuan > 0) {
				steelStrapSetQuan -= itemQuan;
				steelStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelStrapName, steelStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bloodShoesName) {
			if(bloodShoesSetQuan > 0) {
				bloodShoesSetQuan -= itemQuan;
				bloodShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodShoesName, bloodShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodGlovesName) {
			if(bloodGlovesSetQuan > 0) {
				bloodGlovesSetQuan -= itemQuan;
				bloodGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodGlovesName, bloodGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodStrapName) {
			if(bloodStrapSetQuan > 0) {
				bloodStrapSetQuan -= itemQuan;
				bloodStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodStrapName, bloodStrapInvQuan, false);
			} else {
			}
		} else if (itemName == loveShoesName) {
			if(loveShoesSetQuan > 0) {
				loveShoesSetQuan -= itemQuan;
				loveShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveShoesName, loveShoesInvQuan, false);
			} else {
			}
		} else if (itemName == loveGlovesName) {
			if(loveGlovesSetQuan > 0) {
				loveGlovesSetQuan -= itemQuan;
				loveGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveGlovesName, loveGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == loveStrapName) {
			if(loveStrapSetQuan > 0) {
				loveStrapSetQuan -= itemQuan;
				loveStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveStrapName, loveStrapInvQuan, false);
			} else {
			}
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uesName, uesInvQuan, false);
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uisName, uisInvQuan, false);
			} else {
			}
		} else if (itemName == incLv1Name) {
			if(incLv1SetQuan > 0) {
				incLv1SetQuan -= itemQuan;
				incLv1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv1Name, incLv1InvQuan, false);
			} else {
			}
		} else if (itemName == incLv2Name) {
			if(incLv2SetQuan > 0) {
				incLv2SetQuan -= itemQuan;
				incLv2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv2Name, incLv2InvQuan, false);
			} else {
			}
		} else if (itemName == incLv3Name) {
			if(incLv3SetQuan > 0) {
				incLv3SetQuan -= itemQuan;
				incLv3InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv3Name, incLv3InvQuan, false);
			} else {
			}
		} else if (itemName == incLv4Name) {
			if(incLv4SetQuan > 0) {
				incLv4SetQuan -= itemQuan;
				incLv4InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv4Name, incLv4InvQuan, false);
			} else {
			}
		} else if (itemName == incB1Name) {
			if(incB1SetQuan > 0) {
				incB1SetQuan -= itemQuan;
				incB1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB1Name, incB1InvQuan, false);
			} else {
			}
		} else if (itemName == incB2Name) {
			if(incB2SetQuan > 0) {
				incB2SetQuan -= itemQuan;
				incB2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB2Name, incB2InvQuan, false);
			} else {
			}
		} else if (itemName == incL1Name) {
			if(incL1SetQuan > 0) {
				incL1SetQuan -= itemQuan;
				incL1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL1Name, incL1InvQuan, false);
			} else {
			}
		} else if (itemName == incL2Name) {
			if(incL2SetQuan > 0) {
				incL2SetQuan -= itemQuan;
				incL2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL2Name, incL2InvQuan, false);
			} else {
			}
		} else if (itemName == incStr1Name) {
			if(incStr1SetQuan > 0) {
				incStr1SetQuan -= itemQuan;
				incStr1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr1Name, incStr1InvQuan, false);
			} else {
			}
		} else if (itemName == incStr2Name) {
			if(incStr2SetQuan > 0) {
				incStr2SetQuan -= itemQuan;
				incStr2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr2Name, incStr2InvQuan, false);
			} else {
			}
		} else if (itemName == incInt1Name) {
			if(incInt1SetQuan > 0) {
				incInt1SetQuan -= itemQuan;
				incInt1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt1Name, incInt1InvQuan, false);
			} else {
			}
		} else if (itemName == incInt2Name) {
			if(incInt2SetQuan > 0) {
				incInt2SetQuan -= itemQuan;
				incInt2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt2Name, incInt2InvQuan, false);
			} else {
			}
		} else if (itemName == incDex1Name) {
			if(incDex1SetQuan > 0) {
				incDex1SetQuan -= itemQuan;
				incDex1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex1Name, incDex1InvQuan, false);
			} else {
			}
		} else if (itemName == incDex2Name) {
			if(incDex2SetQuan > 0) {
				incDex2SetQuan -= itemQuan;
				incDex2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex2Name, incDex2InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk1Name) {
			if(incLuk1SetQuan > 0) {
				incLuk1SetQuan -= itemQuan;
				incLuk1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk1Name, incLuk1InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk2Name) {
			if(incLuk2SetQuan > 0) {
				incLuk2SetQuan -= itemQuan;
				incLuk2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk2Name, incLuk2InvQuan, false);
			} else {
			}
		}  else {
		}
	}

	public static void Slot5(string itemName, int itemQuan){
		
		if (itemName == aBPName) {
			aBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(aBPName, aBPQuan, false);
		} else if (itemName == phereName) {
			phereQuan += itemQuan;
			AddToSlots.AddToInvSlot(phereName, phereQuan, false);
		} else if (itemName == bBPName) {
			bBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(bBPName, bBPQuan, false);
		} else if (itemName == loveMolName) {
			loveMolQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveMolName, loveMolQuan, false);
		} else if (itemName == abBPName) {
			abBPQuan += itemQuan;
			AddToSlots.AddToInvSlot(abBPName, abBPQuan, false);
		} else if (itemName == loveDustName) {
			loveDustQuan += itemQuan;
			AddToSlots.AddToInvSlot(loveDustName, loveDustQuan, false);
		} else if (itemName == ONegName) {
			ONegQuan += itemQuan;
			AddToSlots.AddToInvSlot(ONegName, ONegQuan, false);
		} else if (itemName == lovePotName) {
			lovePotQuan += itemQuan;
			AddToSlots.AddToInvSlot(lovePotName, lovePotQuan, false);
		} else if (itemName == hPumpName) {
			hPumpQuan += itemQuan;
			AddToSlots.AddToInvSlot(hPumpName, hPumpQuan, false);
		} else if (itemName == aKissName) {
			aKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(aKissName, aKissQuan, false);
		} else if (itemName == adrenName) {
			adrenQuan += itemQuan;
			AddToSlots.AddToInvSlot(adrenName, adrenQuan, false);
		} else if (itemName == nutPillName) {
			nutPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(nutPillName, nutPillQuan, false);
		} else if (itemName == rageName) {
			rageQuan += itemQuan;
			AddToSlots.AddToInvSlot(rageName, rageQuan, false);
		} else if (itemName == fKissName) {
			fKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(fKissName, fKissQuan, false);
		} else if (itemName == epinPillName) {
			epinPillQuan += itemQuan;
			AddToSlots.AddToInvSlot(epinPillName, epinPillQuan, false);
		} else if (itemName == hArmorName) {
			hArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(hArmorName, hArmorQuan, false);
		} else if (itemName == pKissName) {
			pKissQuan += itemQuan;
			AddToSlots.AddToInvSlot(pKissName, pKissQuan, false);
		} else if (itemName == lArmorName) {
			lArmorQuan += itemQuan;
			AddToSlots.AddToInvSlot(lArmorName, lArmorQuan, false);
		} else if (itemName == lossName) {
			if(lossSetQuan > 0) {
				lossSetQuan -= itemQuan;
				lossInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(lossName, lossInvQuan, false);
			} else {
			}
		} else if (itemName == remName) {
			if(remSetQuan > 0) {
				remSetQuan -= itemQuan;
				remInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(remName, remInvQuan, false);
			} else {
			}
		} else if (itemName == sadName) {
			if(sadSetQuan > 0) {
				sadSetQuan -= itemQuan;
				sadInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sadName, sadInvQuan, false);
			} else {
			}
		} else if (itemName == bitName) {
			if(bitSetQuan > 0) {
				bitSetQuan -= itemQuan;
				bitInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bitName, bitInvQuan, false);
			} else {
			}
		} else if (itemName == sorName) {
			if(sorSetQuan > 0) {
				sorSetQuan -= itemQuan;
				sorInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sorName, sorInvQuan, false);
			} else {
			}
		} else if (itemName == loneName) {
			if(loneSetQuan > 0) {
				loneSetQuan -= itemQuan;
				loneInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loneName, loneInvQuan, false);
			} else {
			}
		} else if (itemName == misName) {
			if(misSetQuan > 0) {
				misSetQuan -= itemQuan;
				misInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(misName, misInvQuan, false);
			} else {
			}
		} else if (itemName == longName) {
			if(longSetQuan > 0) {
				longSetQuan -= itemQuan;
				longInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(longName, longInvQuan, false);
			} else {
			}
		} else if (itemName == needName) {
			if(needSetQuan > 0) {
				needSetQuan -= itemQuan;
				needInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(needName, needInvQuan, false);
			} else {
			}
		} else if (itemName == disName) {
			if(disSetQuan > 0) {
				disSetQuan -= itemQuan;
				disInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(disName, disInvQuan, false);
			} else {
			}
		}  else if (itemName == gladName) {
			if(gladSetQuan > 0) {
				gladSetQuan -= itemQuan;
				gladInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(gladName, gladInvQuan, false);
			} else {
			}
		} else if (itemName == happName) {
			if(happSetQuan > 0) {
				happSetQuan -= itemQuan;
				happInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(happName, happInvQuan, false);
			} else {
			}
		} else if (itemName == hopeName) {
			if(hopeSetQuan > 0) {
				hopeSetQuan -= itemQuan;
				hopeInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hopeName, hopeInvQuan, false);
			} else {
			}
		} else if (itemName == attName) {
			if(attSetQuan > 0) {
				attSetQuan -= itemQuan;
				attInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(attName, attInvQuan, false);
			} else {
			}
		} else if (itemName == hostName) {
			if(hostSetQuan > 0) {
				hostSetQuan -= itemQuan;
				hostInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(hostName, hostInvQuan, false);
			} else {
			}
		} else if (itemName == rageWepName) {
			if(rageWepSetQuan > 0) {
				rageWepSetQuan -= itemQuan;
				rageWepInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(rageWepName, rageWepInvQuan, false);
			} else {
			}
		} else if (itemName == passName) {
			if(passSetQuan > 0) {
				passSetQuan -= itemQuan;
				passInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(passName, passInvQuan, false);
			} else {
			}
		} else if (itemName == triName) {
			if(triSetQuan > 0) {
				triSetQuan -= itemQuan;
				triInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(triName, triInvQuan, false);
			} else {
			}
		} else if (itemName == sandName) {
			if(sandSetQuan > 0) {
				sandSetQuan -= itemQuan;
				sandInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(sandName, sandInvQuan, false);
			} else {
			}
		} else if (itemName == leaGlovesName) {
			if(leaGlovesSetQuan > 0) {
				leaGlovesSetQuan -= itemQuan;
				leaGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaGlovesName, leaGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == leaStrapName) {
			if(leaStrapSetQuan > 0) {
				leaStrapSetQuan -= itemQuan;
				leaStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(leaStrapName, leaStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bronShoesName) {
			if(bronShoesSetQuan > 0) {
				bronShoesSetQuan -= itemQuan;
				bronShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronShoesName, bronShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bronGlovesName) {
			if(bronGlovesSetQuan > 0) {
				bronGlovesSetQuan -= itemQuan;
				bronGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronGlovesName, bronGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bronStrapName) {
			if(bronStrapSetQuan > 0) {
				bronStrapSetQuan -= itemQuan;
				bronStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bronStrapName, bronStrapInvQuan, false);
			} else {
			}
		} else if (itemName == ironShoesName) {
			if(ironShoesSetQuan > 0) {
				ironShoesSetQuan -= itemQuan;
				ironShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironShoesName, ironShoesInvQuan, false);
			} else {
			}
		} else if (itemName == ironGlovesName) {
			if(ironGlovesSetQuan > 0) {
				ironGlovesSetQuan -= itemQuan;
				ironGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironGlovesName, ironGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == ironStrapName) {
			if(ironStrapSetQuan > 0) {
				ironStrapSetQuan -= itemQuan;
				ironStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(ironStrapName, ironStrapInvQuan, false);
			} else {
			}
		} else if (itemName == steelShoesName) {
			if(steelShoesSetQuan > 0) {
				steelShoesSetQuan -= itemQuan;
				steelShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelShoesName, steelShoesInvQuan, false);
			} else {
			}
		} else if (itemName == steelGlovesName) {
			if(steelGlovesSetQuan > 0) {
				steelGlovesSetQuan -= itemQuan;
				steelGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelGlovesName, steelGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == steelStrapName) {
			if(steelStrapSetQuan > 0) {
				steelStrapSetQuan -= itemQuan;
				steelStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(steelStrapName, steelStrapInvQuan, false);
			} else {
			}
		} else if (itemName == bloodShoesName) {
			if(bloodShoesSetQuan > 0) {
				bloodShoesSetQuan -= itemQuan;
				bloodShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodShoesName, bloodShoesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodGlovesName) {
			if(bloodGlovesSetQuan > 0) {
				bloodGlovesSetQuan -= itemQuan;
				bloodGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodGlovesName, bloodGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == bloodStrapName) {
			if(bloodStrapSetQuan > 0) {
				bloodStrapSetQuan -= itemQuan;
				bloodStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(bloodStrapName, bloodStrapInvQuan, false);
			} else {
			}
		} else if (itemName == loveShoesName) {
			if(loveShoesSetQuan > 0) {
				loveShoesSetQuan -= itemQuan;
				loveShoesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveShoesName, loveShoesInvQuan, false);
			} else {
			}
		} else if (itemName == loveGlovesName) {
			if(loveGlovesSetQuan > 0) {
				loveGlovesSetQuan -= itemQuan;
				loveGlovesInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveGlovesName, loveGlovesInvQuan, false);
			} else {
			}
		} else if (itemName == loveStrapName) {
			if(loveStrapSetQuan > 0) {
				loveStrapSetQuan -= itemQuan;
				loveStrapInvQuan += itemQuan;
				AddToSlots.AddToEquipSlot(loveStrapName, loveStrapInvQuan, false);
			} else {
			}
		} else if (itemName == uesName) {
			if(uesSetQuan > 0) {
				uesSetQuan -= itemQuan;
				uesInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uesName, uesInvQuan, false);
			} else {
			}
		} else if (itemName == uisName) {
			if(uisSetQuan > 0) {
				uisInvQuan -= itemQuan;
				uisInvQuan += itemQuan;
				AddToSlots.AddToInvSlot(uisName, uisInvQuan, false);
			} else {
			}
		} else if (itemName == incLv1Name) {
			if(incLv1SetQuan > 0) {
				incLv1SetQuan -= itemQuan;
				incLv1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv1Name, incLv1InvQuan, false);
			} else {
			}
		} else if (itemName == incLv2Name) {
			if(incLv2SetQuan > 0) {
				incLv2SetQuan -= itemQuan;
				incLv2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv2Name, incLv2InvQuan, false);
			} else {
			}
		} else if (itemName == incLv3Name) {
			if(incLv3SetQuan > 0) {
				incLv3SetQuan -= itemQuan;
				incLv3InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv3Name, incLv3InvQuan, false);
			} else {
			}
		} else if (itemName == incLv4Name) {
			if(incLv4SetQuan > 0) {
				incLv4SetQuan -= itemQuan;
				incLv4InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLv4Name, incLv4InvQuan, false);
			} else {
			}
		} else if (itemName == incB1Name) {
			if(incB1SetQuan > 0) {
				incB1SetQuan -= itemQuan;
				incB1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB1Name, incB1InvQuan, false);
			} else {
			}
		} else if (itemName == incB2Name) {
			if(incB2SetQuan > 0) {
				incB2SetQuan -= itemQuan;
				incB2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incB2Name, incB2InvQuan, false);
			} else {
			}
		} else if (itemName == incL1Name) {
			if(incL1SetQuan > 0) {
				incL1SetQuan -= itemQuan;
				incL1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL1Name, incL1InvQuan, false);
			} else {
			}
		} else if (itemName == incL2Name) {
			if(incL2SetQuan > 0) {
				incL2SetQuan -= itemQuan;
				incL2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incL2Name, incL2InvQuan, false);
			} else {
			}
		} else if (itemName == incStr1Name) {
			if(incStr1SetQuan > 0) {
				incStr1SetQuan -= itemQuan;
				incStr1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr1Name, incStr1InvQuan, false);
			} else {
			}
		} else if (itemName == incStr2Name) {
			if(incStr2SetQuan > 0) {
				incStr2SetQuan -= itemQuan;
				incStr2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incStr2Name, incStr2InvQuan, false);
			} else {
			}
		} else if (itemName == incInt1Name) {
			if(incInt1SetQuan > 0) {
				incInt1SetQuan -= itemQuan;
				incInt1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt1Name, incInt1InvQuan, false);
			} else {
			}
		} else if (itemName == incInt2Name) {
			if(incInt2SetQuan > 0) {
				incInt2SetQuan -= itemQuan;
				incInt2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incInt2Name, incInt2InvQuan, false);
			} else {
			}
		} else if (itemName == incDex1Name) {
			if(incDex1SetQuan > 0) {
				incDex1SetQuan -= itemQuan;
				incDex1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex1Name, incDex1InvQuan, false);
			} else {
			}
		} else if (itemName == incDex2Name) {
			if(incDex2SetQuan > 0) {
				incDex2SetQuan -= itemQuan;
				incDex2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incDex2Name, incDex2InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk1Name) {
			if(incLuk1SetQuan > 0) {
				incLuk1SetQuan -= itemQuan;
				incLuk1InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk1Name, incLuk1InvQuan, false);
			} else {
			}
		} else if (itemName == incLuk2Name) {
			if(incLuk2SetQuan > 0) {
				incLuk2SetQuan -= itemQuan;
				incLuk2InvQuan += itemQuan;
				AddToSlots.AddToInvSlot(incLuk2Name, incLuk2InvQuan, false);
			} else {
			}
		}  else {
		}
	}
}
