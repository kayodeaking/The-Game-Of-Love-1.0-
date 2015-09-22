using UnityEngine;
using System.Collections;

public class MonsterInfo : MonoBehaviour {

	public static bool unlock;
	public static string enemyButName;
	public static string enemyName;
	public static int age;
	public static string type;
	public static int rank;
	public static int blood;
	public static int love;
	public static int exp;
	public static int gold;
	public static string skill1;
	public static int skill1cost;
	public static string skill2;
	public static int skill2cost;
	public static string description;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Unlock(){
		unlock = true;
		if (unlock) {
			enemyButName = "Cholesterol";
		}
	}

	public void Choose(){
		if (unlock) {
			enemyName = "Cholesterol";
			age = 5;
			type = "Attacker";
			rank = 1;
			blood = 50;
			love = 0;
			exp = 5;
			gold = 150;
			skill1 = "None";
			skill1cost = 0;
			skill2 = "None";
			skill2cost = 0;
			description = "A destructive force to the heart over time.";
		} else {
		}
	}
}
