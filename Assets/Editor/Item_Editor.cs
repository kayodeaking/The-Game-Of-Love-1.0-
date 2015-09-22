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


	private int _index = 0;
	private Vector2 scrollPosition = Vector2.zero;
	private Vector2 scrollPosition2 = Vector2.zero;
	private List<Item> itemList;
	private ItemDataBase _items;
	Item_Type itemTYPE = Item_Type.None;
	//Potion_Type p_Type = Potion_Type.None;
	//Weapon_Type w_Type = Weapon_Type.None;
	void OnEnable(){

		//itemList = (List<Item>)ItemDataBase.Load_ItemsXML ("Item_Data");
		LoadDataBase ();

	}
	void LoadDataBase(){
		_items = (ItemDataBase)AssetDatabase.LoadAssetAtPath<ItemDataBase> ("Assets/ItemDataBase.asset");
		itemList = _items.Load_ItemsXML ("Item_Data");
	}
	void CreateDataBase(){
		_items = ScriptableObject.CreateInstance<ItemDataBase>();
		AssetDatabase.CreateAsset (_items, "Assets/ItemDataBase.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	}

	[MenuItem ("DataEditor/Item")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Item_Editor));

	}

	void OnGUI () {

		GUILayout.Label ("Item DataBase", EditorStyles.boldLabel);

		EditorGUILayout.BeginVertical();

		TOP_BUTTONS ();
		EditorGUILayout.BeginHorizontal ();
		Scroll_Area ();
		Value_Window ();
		EditorGUILayout.EndHorizontal ();

		EditorGUILayout.EndVertical ();


	}




	void ItemTable_Body(){

		EditorGUILayout.BeginVertical("Box");

		for (int k = 0; k < _items.COUNT; k++) {
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(_items.Item(k).name,"Box",GUILayout.ExpandWidth(true))){

				_index = k;

			}
			EditorGUILayout.EndHorizontal();
		}

		EditorGUILayout.EndVertical();	

		/*

		for(int j  = 0;j<itemList.Count;j++){
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(itemList[j].name,"Box",GUILayout.ExpandWidth(true))){

				_index = j;

			}
			EditorGUILayout.EndHorizontal();
		}

		GUILayout.EndVertical();	
		*/
	}


	void Value_Window(){
		EditorGUILayout.BeginHorizontal ("Box");
		EditorGUILayout.BeginVertical (GUILayout.Width(250));
	/*
		itemList[_index].name= EditorGUILayout.TextField("Name",itemList[_index].name);
			//EditorGUILayout.TextField("Type",itemList[_index].type);
		itemList[_index].type = (Item_Type)EditorGUILayout.EnumPopup("Type:" , itemList[_index].type);
		itemList[_index].kind = 	EditorGUILayout.TextField("Kind",itemList[_index].kind);
		itemList[_index].price= 	EditorGUILayout.TextField ("Price", itemList [_index].price);
		itemList[_index].rank = EditorGUILayout.TextField ("Rank", itemList [_index].rank);
		itemList[_index].stock = EditorGUILayout.TextField ("Stock", itemList [_index].stock);
		itemList[_index].duration =	EditorGUILayout.TextField ("Duration", itemList [_index].duration);
		itemList [_index].sprite = (Sprite)EditorGUILayout.ObjectField (itemList [_index].sprite, typeof(Sprite), true);
*/


		_items.Item(_index).name= EditorGUILayout.TextField("Name",_items.Item(_index).name);
		//EditorGUILayout.TextField("Type",itemList[_index].type);
		_items.Item(_index).type = (Item_Type)EditorGUILayout.EnumPopup("Type:" , _items.Item(_index).type);
		_items.Item(_index).kind = 	EditorGUILayout.TextField("Kind",_items.Item(_index).kind);
		_items.Item(_index).price= 	EditorGUILayout.TextField ("Price", _items.Item(_index).price);
		_items.Item(_index).rank = EditorGUILayout.TextField ("Rank", _items.Item(_index).rank);
		_items.Item(_index).stock = EditorGUILayout.TextField ("Stock", _items.Item(_index).stock);
		_items.Item(_index).duration =	EditorGUILayout.TextField ("Duration", _items.Item(_index).duration);
		_items.Item(_index).sprite = (Sprite)EditorGUILayout.ObjectField (_items.Item(_index).sprite, typeof(Sprite), true);

		//FindKindType ();
		//scrollPosition2 = GUILayout.BeginScrollView(scrollPosition2,GUILayout.ExpandHeight(true)); 
		//EditorGUILayout.TextField ("Description", itemList [_index].description);
		//EditorGUILayout.TextArea (itemList [_index].description,GUILayout.ExpandHeight(true));
	//	GUILayout.EndScrollView ();


		EditorGUILayout.EndVertical ();	
		EditorGUILayout.EndHorizontal ();




	}

	void TOP_BUTTONS(){
		EditorGUILayout.BeginHorizontal ("box",GUILayout.Width(50));
		if (GUILayout.Button ("Load XML ")) {
			//itemList = (List<Item>)ItemDataBase.Load_ItemsXML ("Item_Data");
			
		}
		if (GUILayout.Button ("Save XML")) {



		}

		if(GUILayout.Button("CreateDataBase File")){
			CreateDataBase ();
		}

		if (GUILayout.Button ("Load DataBase")) {
			LoadDataBase ();

		}
		if (GUILayout.Button ("Load GameObjects")) {
			Create_GameObjects ();
		}

		if (GUILayout.Button ("Create prefabs")) {

		}
		if (GUILayout.Button ("Load Selected GameObject")) {
			Create_Selected_GameObject ();

		}	
		EditorGUILayout.EndHorizontal();
	}
	void Scroll_Area(){

		EditorGUILayout.BeginVertical (GUILayout.Width(250));

		scrollPosition = GUILayout.BeginScrollView(scrollPosition,GUILayout.ExpandHeight(true)); 

		ItemTable_Body();

		GUILayout.EndScrollView();


		EditorGUILayout.EndVertical ();


	}
	void Create_Prefabs(){

		foreach (Item i in itemList) {

			//GameObject go = new GameObject (i.name+" Game Object");
			//go.gameObject.AddComponent<Item_View> ().item = i;



			//Object prefab =PrefabUtility.CreateEmptyPrefab("Assets/"+i.name+".prefab");
			//EditorUtility.ReplacePrefab(i.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
		}

	}
	void Create_GameObjects(){
		foreach (Item i in itemList) {

			GameObject go = new GameObject (i.name + " Game Object");
			go.gameObject.AddComponent<Item_View> ().item = i;

		}

	}

	void Create_Selected_GameObject(){

		GameObject go = new GameObject (itemList [_index].name + "-Object");
		go.gameObject.AddComponent<Item_View> ().item = itemList [_index];

	}
	/*
	void FindKindType(){

		switch (itemTYPE) {

		case ItemType.None:

			break;
		case ItemType.Weapon:

			w_Type =(Weapon_Type)EditorGUILayout.EnumPopup ("Weapon Kind", w_Type);
			break;
		case ItemType.Potion:

			p_Type = (Potion_Type)EditorGUILayout.EnumPopup ("Potion Kind", p_Type);
			break;

		case ItemType.Armor:


			break;


		}

	}
	*/
}
