using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClick : MonoBehaviour {

	public static bool loading;
	public static bool saving;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Load_StartLevel(){
		
		Application.LoadLevel(1);
	}

	public void Load_MyHeartsLevel(){
	
		//Current scene would be Title
		if (Application.loadedLevel == 0) {
			loading = true;
		} else {
			saving = true;
		}
		Application.LoadLevel(4);

	}

	public void Load_GameFromFile() {

		Application.LoadLevel (1);

	}
	
	public void Return() {

		if (Application.loadedLevel == 1) { //Current Scene would be Levels
			Application.LoadLevel (0);
		}else if (Application.loadedLevel == 3) { //Current Scene would be Hearts Condition
			Application.LoadLevel (1);
		}else if (Application.loadedLevel == 2) { //Current Scene would be Heart Shop
			Application.LoadLevel (1);
		}else if (Application.loadedLevel == 4) { //Current scene would be My Hearts
			if (saving) {
				saving = false;
				Application.LoadLevel (1);
			}
			
			if (loading) {
				loading = false;
				Application.LoadLevel (0);
			}
		}

	}

	public void Delete_GameFile() {

	}

	public void Load_HeartCondition() {
			
		Application.LoadLevel (3);
		
	}

	public void Load_HeartShop () {

		Application.LoadLevel (2);
		
	}

	public void Inv_Equip_Tab1() {
	}

	public void Inv_Equip_Tab2() {
	}

	public void Inv_Equip_Tab3() {
	}
}