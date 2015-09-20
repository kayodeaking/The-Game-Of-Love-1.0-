using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;
using System.IO;

[System.Serializable]
public class Item_Editor : EditorWindow {
	public float grid_Height = 25.0f;
	public float grid_Width = 20.0f;
	int _index =0;
	Vector2 scrollPosition = Vector2.zero;
	List<Item> itemList;
	void OnEnable(){
		 Load_ItemData("Item_Data");


	}
		[MenuItem ("DataEditor/Item")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Item_Editor));

	}
	
	void OnGUI () {

		GUILayout.Label ("Item DataBase", EditorStyles.boldLabel);
		if (GUILayout.Button ("Load")) {
			Create_Prefabs ();
		}
		if (GUILayout.Button ("Save")) {

		}
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

	void Create_Prefabs(){

		foreach (Item i in itemList) {

				GameObject go = new GameObject (i.name+"GameObject");
				go.gameObject.AddComponent<Item_View>();
			//	Instantiate (go);

			//Object prefab =PrefabUtility.CreateEmptyPrefab("Assets/"+i.name+".prefab");
			//EditorUtility.ReplacePrefab(i.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
		}

	}


	void ItemTable_Body(){
		EditorGUILayout.BeginVertical("Box");


		for(int j  = 0;j<itemList.Count;j++){
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(itemList[j].name)){
				
				_index = j;

			}
			EditorGUILayout.EndHorizontal();
		}
		
		GUILayout.EndVertical();	
	}
	void Load_ItemData(string filepath){
		TextAsset _xml = Resources.Load<TextAsset>(filepath);
		XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
		StringReader reader  = new StringReader(_xml.text);
		 itemList = serializer.Deserialize(reader) as List<Item>;

		reader.Close();
	}

}
