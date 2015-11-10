using UnityEngine;
using System.Collections;

public class Stats : MonoBehaviour{

	Leveling_System ls;
		//public int health;
	//	public int damage;
	//	public int speed;

	int max_Blood;
	int currBlood = 0;
	int max_Love;
	int currLove = 0;
	int max_Exp ;
	int currExp = 0;

	// Use this for initialization
	void Start () {
		ls = gameObject.GetComponent<Leveling_System>();
		max_Blood = ls.currentLevel.Blood;
		max_Love = ls.currentLevel.Love;
		max_Exp = ls.NextLevel.xp;
		currBlood = max_Blood;
		currLove = max_Love;
		currExp = ls.currentXp;
	}
	
	// Update is called once per frame
	void Update () {
		SetStats();
	
	}

	public void SetStats(){

		max_Blood = ls.currentLevel.Blood;
		max_Love = ls.currentLevel.Love;
		max_Exp = ls.NextLevel.xp;

	}





}
