using UnityEngine;
using System.Collections;
using System.IO;

public class HospitalShop : MonoBehaviour
{

	private Rect windowRec = new Rect ((Screen.width * 0), (Screen.height * 0), Screen.width, Screen.height);
	private Rect miniWindowRec = new Rect ((Screen.width / 2) - 150, (Screen.height / 2) - 150, 300, 300);
	Vector2 scrollViewPos = Vector2.zero;

	int shopChoice = 0;
	public static int currNotes = 5000;
	int totalNotes;
	
	string descriptValue;

	string slot1Info;
	bool slot1Empty = true;
	bool slot1Full;
	int slot1Quantity;
	int slot1Price;

	string slot2Info;
	bool slot2Empty = true;
	bool slot2Full;
	int slot2Quantity;
	int slot2Price;

	string slot3Info;
	bool slot3Empty = true;
	bool slot3Full;
	int slot3Quantity;
	int slot3Price;

	string slot4Info;
	bool slot4Empty = true;
	bool slot4Full;
	int slot4Quantity;
	int slot4Price;

	string slot5Info;
	bool slot5Empty = true;
	bool slot5Full;
	int slot5Quantity;
	int slot5Price;

	bool allFull = false;
	bool openGui;
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI ()
	{
		windowRec = GUI.Window (3, windowRec, BackWin, "Hospital Shop");

		if (openGui == true) {
			miniWindowRec = GUI.Window (6, miniWindowRec, TinyWin, "Confirmed");
		}
	}

	void BackWin (int windowID)
	{

		//The base for the screen
		float screenMid = windowRec.width / 2;
		float screenTop = windowRec.height * 0;
		float heightHalf = windowRec.height / 2;
		
		//The basic size of each button
		int width = 50;
		int height = 50;

		GUI.Box (new Rect (5, 20, screenMid, heightHalf), "Choices");
		if (GUI.Button (new Rect (20, screenTop + 40, width * 2, height), "Items")) {
			shopChoice = 1;
		}
		if (GUI.Button (new Rect (20, screenTop + 100, width * 2, height), "Weapons")) {
			shopChoice = 2;
		}
		if (GUI.Button (new Rect (20, screenTop + 160, width * 2, height), "Special")) {
			shopChoice = 3;
		}
		if (GUI.Button (new Rect (20, screenTop + 220, width * 2, height), "Exit")) {
			shopChoice = 0;
			Application.LoadLevel (1);
		}
		Description (descriptValue);

		ShoppingList ();

		scrollViewPos = GUI.BeginScrollView (new Rect ((windowRec.width * 0) + 5, heightHalf + 30, (screenMid * 1.5f) - 15, heightHalf - 40), scrollViewPos, new Rect (0, 0, (screenMid * 1.5f) - 35, windowRec.height));

		GUI.Box (new Rect (0, 0, (screenMid * 1.5f) - 35, windowRec.height), "Choices");

		if (shopChoice == 1) {
			BuyItems ();
		}
		if (shopChoice == 2) {
			BuyWeapons ();
		}
		if (shopChoice == 3) {
			BuySpecial ();
		}
		GUI.EndScrollView ();
	}

	void BuyItems () {

		string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Items.txt");
		int spotCount = 1;
		int line = 1;
		string[] info = new string[4];
		int rowCount = 0;

		for (int i = 0; i < fileInfo.Length; i++) {
			if(line == 1){
				info[0] = fileInfo[i]; 
			}else if(line == 2){
				info[1] = fileInfo[i]; 
			}else if(line == 3){
				info[2] = fileInfo[i]; 
			}else if(line == 4){
				info[3] = fileInfo[i]; 
			}else{
				DisplayItemInfo (info, spotCount, rowCount);				
				if(spotCount >= 3){
					spotCount = 0;
					rowCount++;
				}
				spotCount++;
				line = 0;
			}
			line++;
		}
	}

	void BuyWeapons () { 

		string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Weapons.txt");
		int spotCount = 1;
		int line = 1;
		string[] info = new string[4];
		int rowCount = 0;
		
		for (int i = 0; i < fileInfo.Length; i++) {
			if(line == 1){
				info[0] = fileInfo[i]; 
			}else if(line == 2){
				info[1] = fileInfo[i]; 
			}else if(line == 3){
				info[2] = fileInfo[i]; 
			}else if(line == 4){
				info[3] = fileInfo[i]; 
			}else{
				DisplayItemInfo (info, spotCount, rowCount);				
				if(spotCount >= 3){
					spotCount = 0;
					rowCount++;
				}
				spotCount++;
				line = 0;
			}
			line++;
		}
	}

	void BuySpecial () {

		string[] fileInfo = File.ReadAllLines (Application.dataPath + "/Database/Special.txt");
		int spotCount = 1;
		int line = 1;
		string[] info = new string[4];
		int rowCount = 0;
		
		for (int i = 0; i < fileInfo.Length; i++) {
			if(line == 1){
				info[0] = fileInfo[i]; 
			}else if(line == 2){
				info[1] = fileInfo[i]; 
			}else if(line == 3){
				info[2] = fileInfo[i]; 
			}else if(line == 4){
				info[3] = fileInfo[i]; 
			}else{
				DisplayItemInfo (info, spotCount, rowCount);				
				if(spotCount >= 3){
					spotCount = 0;
					rowCount++;
				}
				spotCount++;
				line = 0;
			}
			line++;
		}
	}

	void DisplayItemInfo (string[] info, int spotCount, int rowCount) {

		if (spotCount == 1){
			if (GUI.Button (new Rect (75, (50 + (90*rowCount)), 200, 50), info[0])) {
				if(allFull == false) {
					descriptValue = info[3];
					totalNotes += int.Parse (info[1]);
					CheckSlots (false, info[0], int.Parse (info[1]));
				}
			}
			GUI.Label (new Rect (75,  ((110) + (90*rowCount)), 200, 50), info[0] + " -- Price: " + info[1] + " LN");			
		}
		if (spotCount == 2) {
			if (GUI.Button (new Rect (285, (50 + (90*rowCount)), 200, 50), info[0])) {
				if(allFull == false) {
					descriptValue = info[3];
					totalNotes += int.Parse (info[1]);
					CheckSlots (false, info[0], int.Parse(info[1]));
				}
			}
			GUI.Label (new Rect (285, (110 + (90*rowCount)), 200, 50),  info[0] +" -- Price: " + info[1] + " LN");
		}
		if (spotCount == 3) {
			if (GUI.Button (new Rect (495, (50 + (90*rowCount)), 200, 50), info[0])) {
				if(allFull == false) {
					descriptValue = info[3];
					totalNotes += int.Parse (info[1]);
					CheckSlots (false, info[0], int.Parse(info[1]));
				}
			}
			GUI.Label (new Rect (495, (110 + (90*rowCount)), 200, 50), info[0] + " -- Price: " + info[1] + " LN");	
		}
		
	}

	void ShoppingList ()
	{
		
		if ((slot1Empty == true) && (slot1Full == false)) {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 65, (windowRec.width / 4), (windowRec.height / 2) - 40), "<Empty Slot>");	
		} else {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 65, (windowRec.width / 4), (windowRec.height / 2) - 40), slot1Info + " LN: " + slot1Price + " x" + slot1Quantity);
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 65, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "+")){
				slot1Quantity += 1;
				totalNotes += slot1Price;
			}
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 82, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "-")){
				slot1Quantity -= 1;
				totalNotes -= slot1Price;
				if(slot1Quantity <= 0){
					slot1Info = null;
					slot1Price = 0;
					slot1Quantity = 0;
					slot1Full = false;
					slot1Empty = true;
				}
			}
			if (GUI.Button (new Rect (windowRec.width - 50, (windowRec.height / 2) + 65, (windowRec.width / 32), (windowRec.height / 8) - 50), "x")) {
				slot1Info = null;
				totalNotes -= (slot1Price*slot1Quantity);
				slot1Price = 0;
				slot1Quantity = 0;
				slot1Full = false;
				slot1Empty = true;
				allFull = false;
			}
		}
		
		if ((slot2Empty == true) && (slot2Full == false)) {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 105, (windowRec.width / 4), (windowRec.height / 2) - 40), "<Empty Slot>");
		} else {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 105, (windowRec.width / 4), (windowRec.height / 2) - 40), slot2Info + " LN: " + slot2Price + " x" + slot2Quantity);
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 105, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "+")){
				slot2Quantity += 1;
				totalNotes += slot2Price;
			}
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 122, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "-")){
				slot2Quantity -= 1;
				totalNotes -= slot2Price;
				if(slot2Quantity <= 0){
					slot2Info = null;
					slot2Price = 0;
					slot2Quantity = 0;
					slot2Full = false;
					slot2Empty = true;
				}
			}
			if (GUI.Button (new Rect (windowRec.width - 50, (windowRec.height / 2) + 105, (windowRec.width / 32), (windowRec.height / 8) - 50), "x")) {	
				slot2Info = null;
				totalNotes -= (slot2Price*slot2Quantity);
				slot2Price = 0;
				slot2Quantity = 0;
				slot2Full = false;
				slot2Empty = true;
				allFull = false;
			}
		}
		
		if ((slot3Empty == true) && (slot3Full == false)) {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 145, (windowRec.width / 4), (windowRec.height / 2) - 40), "<Empty Slot>");
		} else {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 145, (windowRec.width / 4), (windowRec.height / 2) - 40), slot3Info + " LN: " + slot3Price + " x" + slot3Quantity);
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 145, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "+")){
				slot3Quantity += 1;
				totalNotes += slot3Price;
			}
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 162, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "-")){
				slot3Quantity -= 1;
				totalNotes -= slot3Price;
				if(slot3Quantity <= 0){
					slot3Info = null;
					slot3Price = 0;
					slot3Quantity = 0;
					slot3Full = false;
					slot3Empty = true;
				}
			}
			if (GUI.Button (new Rect (windowRec.width - 50, (windowRec.height / 2) + 145, (windowRec.width / 32), (windowRec.height / 8) - 50), "x")) {	
				slot3Info = null;
				totalNotes -= (slot3Price*slot3Quantity);
				slot3Price = 0;
				slot3Quantity = 0;
				slot3Full = false;
				slot3Empty = true;
				allFull = false;
			}
		}
		
		if ((slot4Empty == true) && (slot4Full == false)) {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 185, (windowRec.width / 4), (windowRec.height / 2) - 40), "<Empty Slot>");
		} else {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 185, (windowRec.width / 4), (windowRec.height / 2) - 40), slot4Info + " LN: " + slot4Price + " x" + slot4Quantity);
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 185, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "+")){
				slot4Quantity += 1;
				totalNotes += slot4Price;
			}
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 202, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "-")){
				slot4Quantity -= 1;
				totalNotes -= slot4Price;
				if(slot4Quantity <= 0){
					slot4Info = null;
					slot4Price = 0;
					slot4Quantity = 0;
					slot4Full = false;
					slot4Empty = true;
				}
			}
			if (GUI.Button (new Rect (windowRec.width - 50, (windowRec.height / 2) + 185, (windowRec.width / 32), (windowRec.height / 8) - 50), "x")) {	
				slot4Info = null;
				totalNotes -= (slot4Price*slot4Quantity);
				slot4Price = 0;
				slot4Quantity = 0;
				slot4Full = false;
				slot4Empty = true;
				allFull = false;
			}
		}
		
		if ((slot5Empty == true) && (slot5Full == false)) {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 225, (windowRec.width / 4), (windowRec.height / 2) - 40), "<Empty Slot>");
		} else {
			GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 225, (windowRec.width / 4), (windowRec.height / 2) - 40), slot5Info + " LN: " + slot5Price + " x" + slot5Quantity);
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 225, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "+")){
				slot5Quantity += 1;
				totalNotes += slot5Price;
			}
			if(GUI.Button(new Rect (windowRec.width - 90, (windowRec.height / 2) + 242, (windowRec.width / 32), ((windowRec.height / 8) - 50)/2), "-")){
				slot5Quantity -= 1;
				totalNotes -= slot5Price;
				if(slot5Quantity <= 0){
					slot5Info = null;
					slot5Price = 0;
					slot5Quantity = 0;
					slot5Full = false;
					slot5Empty = true;
				}
			}
			if (GUI.Button (new Rect (windowRec.width - 50, (windowRec.height / 2) + 225, (windowRec.width / 32), (windowRec.height / 8) - 50), "x")) {	
				slot5Info = null;
				totalNotes -= (slot5Price*slot5Quantity);
				slot5Price = 0;
				slot5Quantity = 0;
				slot5Full = false;
				slot5Empty = true;
				allFull = false;
			}
		}
		GUI.Label (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 265, (windowRec.width / 4), (windowRec.height / 2) - 40), "Total Love Notes: " + totalNotes);

		GUI.Box (new Rect (((windowRec.width / 2) * 1.5f) - 5, (windowRec.height / 2) + 30, (windowRec.width / 4), (windowRec.height / 2) - 40), "Buy/No");

		if (GUI.Button (new Rect ((((windowRec.width / 2) * 1.75f) - 80), (windowRec.height) - 43, (windowRec.width / 8), (windowRec.height / 8) - 50), "Buy")) {
			openGui = true;
		}
	}

	void TinyWin(int windowID) {

		string message;
		if (currNotes >= totalNotes) {
			message = "Congratulations, The items you have purchased have been added to you inventory.";
			GUI.Label (new Rect((miniWindowRec.width*0) + 15, (miniWindowRec.height*0) + 75, miniWindowRec.width - 15, miniWindowRec.height - 25),
			           "1) " + slot1Info + " LN: " + slot1Price + " x " + slot1Quantity + "\n" +
			           "2) " + slot2Info + " LN: " + slot2Price + " x " + slot2Quantity + "\n" +
			           "3) " + slot3Info + " LN: " + slot3Price + " x " + slot3Quantity + "\n" +
			           "4) " + slot4Info + " LN: " + slot4Price + " x " + slot4Quantity + "\n" +
			           "5) " + slot5Info + " LN: " + slot5Price + " x " + slot5Quantity + "\n");
			if (GUI.Button (new Rect ((miniWindowRec.width * 0) + 15, miniWindowRec.height - 55, miniWindowRec.width - 30, 25), "Thank You")) {
				openGui = false;
				if(currNotes >= totalNotes) {
					currNotes -= totalNotes;
				}
			}
			
		} else {
			message = "Sorry, it seems you do not have enough Love notes to purchase this item.";
		}

		GUI.Label (new Rect((miniWindowRec.width*0) + 15, (miniWindowRec.height*0) + 25, miniWindowRec.width - 15, 50), message); 
		if (GUI.Button (new Rect ((miniWindowRec.width * 0) + 15, miniWindowRec.height - 30, miniWindowRec.width - 30, 25), "Change Purchase")) {
			openGui = false;
		}
	}

	void CheckSlots (bool status, string name, int price)
	{
		
		if (slot1Empty == true) {
			slot1Empty = status;
			slot1Full = !status;
			slot1Price = price;
			slot1Quantity = 1;
			slot1Info = name;
		} else if ((slot1Empty == false) && (slot2Empty == true)) {
			slot2Empty = status;
			slot2Full = !status;
			slot2Price = price;
			slot2Quantity = 1;
			slot2Info = name;
		} else if ((slot1Empty == false) && (slot2Empty == false) && (slot3Empty == true)) {
			slot3Empty = status;
			slot3Full = !status;
			slot3Price = price;
			slot3Quantity = 1;
			slot3Info = name;
		} else if ((slot1Empty == false) && (slot2Empty == false) && (slot3Empty == false) && (slot4Empty == true)) {
			slot4Empty = status;
			slot4Full = !status;
			slot4Price = price;
			slot4Quantity = 1;
			slot4Info = name;
		} else {
			slot5Empty = status;
			slot5Full = !status;
			slot5Price = price;
			slot5Quantity = 1;
			slot5Info = name;
			allFull = true;
		}
		ShoppingList ();
		
	}
	
	void Description (string info)
	{
		GUI.Box (new Rect ((windowRec.width / 2) + 10, 20, (windowRec.width / 2) - 15, (windowRec.height / 2)), "Description");
		GUI.Label (new Rect ((windowRec.width / 2) + 50, 50, (windowRec.width / 2) - 35, (windowRec.height / 2)), " " + info);
	}
}
