using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class Item_Editor : EditorWindow {
	public float grid_Height = 25.0f;
	public float grid_Width = 20.0f;
	int _index =0;
	Vector2 scrollPosition = Vector2.zero;
	List<Item> itemList;
	void OnEnable(){
		itemList = ItemContainer.Load_Items("Item_Data");

	}
		[MenuItem ("DataEditor/Item")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Item_Editor));
	}
	
	void OnGUI () {

		GUILayout.Label ("Item DataBase", EditorStyles.boldLabel);

		EditorGUILayout.BeginHorizontal ();
			EditorGUILayout.BeginVertical ();
				scrollPosition = GUILayout.BeginScrollView(scrollPosition, true, true,GUILayout.Width(200.0f)); 
			
					ItemTable_Body();

				GUILayout.EndScrollView();
			EditorGUILayout.EndVertical ();

			EditorGUILayout.BeginHorizontal ("Box");
				EditorGUILayout.BeginVertical ();
					EditorGUILayout.BeginHorizontal ();
						EditorGUILayout.TextField("Name",itemList[_index].name);
						EditorGUILayout.TextField("Type",itemList[_index].type);
						EditorGUILayout.TextField("Kind",itemList[_index].kind);
					EditorGUILayout.EndHorizontal ();
					EditorGUILayout.BeginHorizontal ();
						EditorGUILayout.TextField ("Price", itemList [_index].price);
						EditorGUILayout.TextField ("Rank", itemList [_index].rank);
						EditorGUILayout.TextField ("Stock", itemList [_index].stock);
					EditorGUILayout.EndHorizontal ();
						
					//EditorGUILayout.TextField ("Duration", itemList [_index].duration);
					EditorGUILayout.BeginHorizontal();
			EditorGUILayout.TextField ("Description", itemList [_index].description);
						EditorGUILayout.EndHorizontal ();
				
					EditorGUILayout.EndVertical ();	
			EditorGUILayout.EndHorizontal ();

		EditorGUILayout.EndHorizontal ();

	
	}

	void ItemTable_Header(){

		List<string> item_Propertys = new List<string> ();
		item_Propertys.Add("Name");
		item_Propertys.Add("Type");
		item_Propertys.Add("Kind");
		item_Propertys.Add("Effect1");
		item_Propertys.Add("Amount1");
		item_Propertys.Add("Effect2");
		item_Propertys.Add("Amount2");
		item_Propertys.Add("Effect3");
		item_Propertys.Add("Amount3");
		item_Propertys.Add("Effect4");
		item_Propertys.Add("Amount4");
		item_Propertys.Add ("Price");
		item_Propertys.Add ("Rank");
		item_Propertys.Add ("Description");
		item_Propertys.Add ("Stock");
		item_Propertys.Add("Duration");

		GUILayout.BeginHorizontal("Box");
		foreach(string s in item_Propertys){
		
			GUILayout.Box(new GUIContent(s));
			//GUILayout.Space(50.0f);

		}

		GUILayout.EndHorizontal();



	}

	void ItemTable_Body(){
		EditorGUILayout.BeginVertical("Box");
		/*
		foreach(Item i in itemList){
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(i.name)){
			//GUILayout.Label (i.name);
				Debug.Log("clicked:"+ i.name);
			}


			//i.name = EditorGUILayout.TextField(i.name,GUILayout.MaxWidth(grid_Width));
			//i.type = EditorGUILayout.TextField(i.type,GUILayout.MaxWidth(grid_Width));
			//i.kind = EditorGUILayout.TextField(i.kind,GUILayout.MaxWidth(grid_Width));
			//i.effect_1 = EditorGUILayout.TextField(i.effect_1,GUILayout.MaxWidth(grid_Width));
			//i.amount_1 = EditorGUILayout.TextField(i.amount_1,GUILayout.MaxWidth(grid_Width));


			//GUILayout.Box(new GUIContent(i.name));
		//	GUILayout.Box(new GUIContent(i.type),GUILayout.MinWidth(grid_Width),GUILayout.MaxHeight(grid_Height));
		//	GUILayout.Box(new GUIContent(i.kind),GUILayout.MinWidth(grid_Width),GUILayout.MaxHeight(grid_Height));
			//EditorGUILayout.TextField(i.name);
			EditorGUILayout.EndHorizontal();
			
			
		}
		*/
		for(int j  = 0;j<itemList.Count;j++){
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(itemList[j].name)){
				
				_index = j;

			}
			EditorGUILayout.EndHorizontal();
		}
		
		GUILayout.EndVertical();	
	}
}
