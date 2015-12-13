using UnityEngine;
using System.Collections;

public class Spell_Hotbar : MonoBehaviour {
	[SerializeField]
	public KeyCode [] SlotKeys;
	[SerializeField]
	public Transform[] slots;
	Player_Control pc;
	public float timeBetweenBullets = 0.15f;  
	float timer;

	// Use this for initialization
	void Start () {
		pc = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_Control>();
		timer += Time.deltaTime;
		useSlots();
		/*
		slots = new Transform[this.transform.childCount];
		for(int i =0;i<slots.Length;i++){
			
			slots[i] = this.transform.GetChild(i);
			
			
		}
		*/
	}


	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		useSlots();
}

	void useSlots(){
		for(int i =0;i<slots.Length;i++){
			
			
			if(Input.GetKeyDown(SlotKeys[i])&& timer >= timeBetweenBullets && Time.timeScale != 0){
				if(slots[i].childCount==1)
					pc.Shoot(slots[i].GetChild(0));
				
				
				
			}
			
		}

	}
}
