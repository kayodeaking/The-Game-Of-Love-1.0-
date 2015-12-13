﻿using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
[CustomEditor(typeof(Item_View))]
public class ItemViewInspector :Editor {
	int choice;
	Item_View itemView;
	string [] nameArr;
	ItemDataBase _items;


	// Use this for initialization

	void OnEnable(){
		Init();
	}
	void Init(){
	
		itemView = (Item_View)target;
		//choice = itemView.itemID;
	/*
		nameArr = new string[ItemDataBase.GetDataBase().COUNT];
		for(int i = 0; i< nameArr.Length;i++){

			nameArr[i] = ItemDataBase.GetDataBase().Item(i).name;
		}
*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnInspectorGUI () {
		itemView = (Item_View)target;
		//DrawDefaultInspector();


		//choice = EditorGUILayout.Popup(choice,nameArr);
		//itemView.ChangeData(choice);
		EditorGUILayout.LabelField("Item",itemView.name.ToString());

		
	}


}
