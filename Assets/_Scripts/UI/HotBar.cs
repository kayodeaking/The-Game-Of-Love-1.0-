using UnityEngine;
using System.Collections;
using System.Collections.Generic;
[System.Serializable]
public class HotBar : MonoBehaviour {
	
	[SerializeField]
	public KeyCode[] SlotKeys;
	[SerializeField]
	public Transform[] slots;
	
	
	
	// Use this for initialization
	void Start () {
		/*
		slots = new Transform[this.transform.childCount];
		for(int i =0;i<slots.Length;i++){
			
			slots[i] = this.transform.GetChild(i);
			

		}
		*/
	
	
	}
	
	// Update is called once per frame
	void Update () {
		UseSlot();
	
		
	}

	void UseSlot(){

		for(int i =0;i<slots.Length;i++){


				if(Input.GetKeyDown(SlotKeys[i])){
				if(slots[i].childCount==1)
					slots[i].GetChild(0).GetComponent<UI_Item>().ConsumeItem();



				}

			}

		}


	

			

	
	
}
