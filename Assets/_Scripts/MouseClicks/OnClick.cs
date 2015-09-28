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

	public void Return_ToStart () {
		Application.LoadLevel (0);
	}

	public void Load_GameFromStart (){
		
		Application.LoadLevel(1);
	}

	public void Load_GameFromFile () {
		
		Application.LoadLevel (1);
		
	}

	public void Delete_GameFile () {
		
	}

	public void Load_MyHeartsScene (){
	
		//Current scene would be Title
		if (Application.loadedLevel == 0) {
			loading = true;
		} else {
			saving = true;
		}
		Application.LoadLevel(4);

	}

	public void Load_HeartConditionScene () {
			
		Application.LoadLevel (3);
		
	}

	public void Load_HeartShopSecene () {

		Application.LoadLevel (2);
		
	}

	public void Load_MonsterBook () {

		Application.LoadLevel (6);

	}
	
	public void Load_LevelChoiceScene () {

		if (Application.loadedLevel == 2) { //Current Scene would be Heart Shop
			Application.LoadLevel (1);
		} else if (Application.loadedLevel == 3) { //Current Scene would be Hearts Condition
			Application.LoadLevel (1);
		}  else if (Application.loadedLevel == 5) { //Current Scene would be Levels
			Application.LoadLevel (1);
		} else if (Application.loadedLevel == 6) { //Current Scene would be Monster Book
			Application.LoadLevel (1);
		}

	}

	public void Exit_MyHeartScene () {

		if (saving) {
			saving = false;
			Application.LoadLevel (1);
		}
		
		if (loading) {
			loading = false;
			Application.LoadLevel (0);
		}

	}

	public void Restart_GameLevel () {
			Application.LoadLevel (5);
	}

	public void MoveSet1 () {
		Player_Control.moveSet = 1;
	}
	
	public void MoveSet2 () {
		Player_Control.moveSet = 2;
	}
		
}