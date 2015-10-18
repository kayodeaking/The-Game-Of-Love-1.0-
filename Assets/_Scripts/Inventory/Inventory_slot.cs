using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
[ExecuteInEditMode]
public class Inventory_slot : MonoBehaviour {

	public UI_ItemView itemView;
	Transform child;
	// Use this for initialization
	void OnEnable(){
		child = transform.GetChild(0);
		itemView  =child.GetComponent<UI_ItemView>();
	}
	void Start () {
		child = transform.GetChild(0);
		itemView  =child.GetComponent<UI_ItemView>();
	}
	
	// Update is called once per frame
	void Update () {

	}


}
