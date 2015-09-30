using UnityEngine;
using System.Collections;

public class Player_Stats : MonoBehaviour {

	public static float max_Blood = 500;
	public static float currBlood = 0f;

	public static float max_Love = 250;
	public static float currLove = 0f;

	public static float max_Exp = 50;
	public static float currExp = 0;

	public GameObject bloodBar;
	public GameObject loveBar;
	public GameObject expBar;

	// Use this for initialization
	void Start () {

		currBlood = max_Blood;
		InvokeRepeating ("DecreaseHealth", 1f, 1f);

		currLove = max_Love;
		InvokeRepeating ("DecreaseMagic", 1f, 1f);

		InvokeRepeating ("IncreaseExp", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void DecreaseHealth() {
		currBlood -= 25f;
		float tempBlood = currBlood / max_Blood;
		SetBloodBar (tempBlood);
	}

	void DecreaseMagic() {
		currLove -= 25f;
		float tempLove = currLove / max_Love;
		SetLoveBar (tempLove);
	}

	void IncreaseExp() {
		currExp += 10;
		float tempExp = currExp / max_Exp;
		SetExpBar (tempExp);
	}

	public void SetBloodBar (float health) {

		bloodBar.transform.localScale = new Vector3 (health, bloodBar.transform.localScale.y, bloodBar.transform.localScale.z);
	}

	public void SetLoveBar (float magic) {
		
		loveBar.transform.localScale = new Vector3 (magic, loveBar.transform.localScale.y, loveBar.transform.localScale.z);
	}

	public void SetExpBar (float exp) {
		
		expBar.transform.localScale = new Vector3 (exp, expBar.transform.localScale.y, expBar.transform.localScale.z);
	}

}
