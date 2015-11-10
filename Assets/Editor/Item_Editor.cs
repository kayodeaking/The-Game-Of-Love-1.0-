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
	private SerializedObject so;

	private ItemDataBase _items;

	
	void OnEnable(){

		_index= 0;
	if(_items==null)
			LoadDataBase ();
		else{
			so = new SerializedObject(_items);
		}
	

	}
	void LoadDataBase(){
		_items = (ItemDataBase)AssetDatabase.LoadAssetAtPath<ItemDataBase> ("Assets/Resources/ItemDatBase.asset");
		if(_items==null)
			CreateDataBase();

	}
	void CreateDataBase(){
		_items = ScriptableObject.CreateInstance<ItemDataBase>();
		AssetDatabase.CreateAsset (_items, "Assets/Resources/ItemDatBase.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	
	}


	[MenuItem ("DataEditor/Item Editor")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Item_Editor));


	}
	/*
	[MenuItem ("DataEditor/Base_item")]
	public static void CreateBaseItem(){
		Base_Item bI = ScriptableObject.CreateInstance<Base_Item>();
		AssetDatabase.CreateAsset(bI,"Assets/Resources/Items/BaseItem.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	}
	*/


	void OnGUI () {

		GUILayout.Label ("Item DataBase", EditorStyles.boldLabel);

		EditorGUILayout.BeginVertical();

		TOP_BUTTONS ();
		EditorGUILayout.BeginHorizontal ();
		if(_items.COUNT>0){
			Scroll_Area ();
			Value_Window ();
		}
		EditorGUILayout.EndHorizontal ();

		EditorGUILayout.EndVertical ();


	}



	void ItemTable_Body(){

		EditorGUILayout.BeginVertical();

		for (int k = 0; k < _items.COUNT; k++) {
			if(_items.Item(k)!=null){
			EditorGUILayout.BeginHorizontal();

				if(GUILayout.Button(_items.Item(k).name,"Box",GUILayout.ExpandWidth(true))){
			
				_index = k;
					EditorUtility.SetDirty(_items);
				

			}

			if(GUILayout.Button("-",GUILayout.Width(15.0f))){
					AssetDatabase.DeleteAsset("Assets/Resources/Items/"+_items.Item(k).name.ToString()+".asset");
					_items.RemoveAt(k);
					EditorUtility.SetDirty(_items);

				}
			EditorGUILayout.EndHorizontal();
			}
		}

		EditorGUILayout.EndVertical();	

	
	}

	void OnSelectionChange(){


	}


	void Value_Window(){
		try {
		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.BeginVertical ("Box",GUILayout.Width(300));

	 
	
		_items.Item(_index).type = (Item_Type)EditorGUILayout.EnumPopup("Type:" , _items.Item(_index).type);
		_items.Item(_index).name= EditorGUILayout.TextField("Name",_items.Item(_index).name);
		_items.Item(_index).sprite= (Sprite)EditorGUILayout.ObjectField ("Sprite",_items.Item(_index).sprite, typeof(Sprite), false);
//		FindKindType(_items.Item(_index).type);
	//	Effect_listView();
			Effect_listView();




		EditorGUILayout.EndVertical ();	
		EditorGUILayout.BeginVertical("Box");
		EditorStyles.textField.wordWrap = true;
		_items.Item(_index).description = EditorGUILayout.TextField("Description",_items.Item(_index).description , GUILayout.Height(100.0f));
		_items.Item(_index).price= 	(int)EditorGUILayout.IntField("Price",_items.Item(_index).price);
		_items.Item(_index).rank = (int)EditorGUILayout.IntField("Rank",_items.Item(_index).rank);
		_items.Item(_index).stock = (int)EditorGUILayout.IntField("Stock",_items.Item(_index).stock);
		_items.Item(_index).duration =(int)EditorGUILayout.IntField("Duration",_items.Item(_index).duration);
		EditorGUILayout.EndVertical();
		EditorGUILayout.EndHorizontal ();
		}

			catch (System.ArgumentOutOfRangeException ex){
				Debug.Log(ex.ToString());
			}
		catch(System.NullReferenceException ex){
			Debug.Log(ex.ToString());
			this.Close();
		}

	}

	void TOP_BUTTONS(){
		EditorGUILayout.BeginHorizontal ("box",GUILayout.Width(50));
		/*
		if (GUILayout.Button ("Load XML ")) {
			_items.Load_ItemsXML ("Item_Data");
			
		}
		*/

		/*
		if (GUILayout.Button ("Save XML")) {

		}
		*/
		/*
		if(GUILayout.Button("CreateDataBase File")){
		//	CreatePotionDataBase();
			CreateDataBase ();
		}
		*/


		if (GUILayout.Button ("Load DataBase")) {
			LoadDataBase ();

		}
		if(GUILayout.Button("New Item")){

			EditorWindow.GetWindow(typeof(NewItemWindow));

		}
		/*
		if (GUILayout.Button ("Load GameObjects")) {
			Create_GameObjects ();
		}

		*/
		if (GUILayout.Button ("Create prefabs")) {
			Create_Prefabs();

		}

		if (GUILayout.Button ("Load Selected GameObject")) {
			Create_Selected_GameObject ();
		

		}	

		EditorGUILayout.EndHorizontal();
	}
	void Scroll_Area(){

		EditorGUILayout.BeginVertical (GUILayout.Width(250));

		scrollPosition = GUILayout.BeginScrollView(scrollPosition,GUILayout.ExpandHeight(true)); 
		if(_items.COUNT>0){
		ItemTable_Body();
		}
		GUILayout.EndScrollView();
		EditorGUILayout.EndVertical ();


	}

	void Create_Prefabs(){

		for (int i = 0; i < _items.COUNT; i++){

			GameObject go = new GameObject (_items.Item (i).name+" Game Object");
			go.gameObject.AddComponent<Item_View> ().item = _items.Item (i);


			Object prefab =PrefabUtility.CreateEmptyPrefab("Assets/_PreFabs/Items/"+_items.Item (i).name+".prefab");
			PrefabUtility.ReplacePrefab(go.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
		}

	}
	void Create_GameObjects(){

		for (int i = 0; i < _items.COUNT; i++) {
			GameObject go = new GameObject (_items.Item(i).name + " Game Object");
			go.gameObject.AddComponent<Item_View> ().item = _items.Item(i);

		}
	

	}

	void Create_Selected_GameObject(){
		GameObject go = new GameObject (_items.Item(_index).name + "-Object");
		go.gameObject.AddComponent<Item_View> ().itemID = _index;


	}

	void Effect_listView(){
		so.Update();
		EditorGUILayout.LabelField("EFFECTS");
	//SerializedObject so = new SerializedObject(_items.Item(_index));
		SerializedProperty db = so.FindProperty("database");
		SerializedProperty indexObject = db.GetArrayElementAtIndex(_index);
		SerializedProperty effects = indexObject.FindPropertyRelative("Effects");

	//SerializedProperty sp  = so.FindProperty("Effects");
		Show(effects,true);
		so.ApplyModifiedProperties();
	}


	public static void Show (SerializedProperty list, bool showListSize = true) {
		EditorGUILayout.PropertyField(list);
		EditorGUI.indentLevel += 1;
		if (list.isExpanded) {
			if (showListSize) {

				EditorGUILayout.PropertyField(list.FindPropertyRelative("Array.size"));
			}
			for (int i = 0; i < list.arraySize; i++) {
				SerializedProperty so_Object =  list.GetArrayElementAtIndex(i);
				EditorGUILayout.PropertyField(so_Object);
				if(so_Object.isExpanded){
					EditorGUI.indentLevel += 1;
					EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i).FindPropertyRelative("e_type"));
					EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i).FindPropertyRelative("amount"));
				}
			}
		}
		EditorGUI.indentLevel -= 1;
	}

	void OnInspectorUpdate(){
		Repaint ();
	}
	/*
	void FindKindType(Item_Type itemType){

		switch (itemType) {

		case Item_Type.None:

			break;
		case Item_Type.Weapon:
			SerializedType();
		// w_type = (Weapon_Type)EditorGUILayout.EnumPopup ("Weapon Kind", w_type);
			break;
		case Item_Type.Potion:
			SerializedType();
		// p_type = (Potion_Type)EditorGUILayout.EnumPopup ("Potion Kind", p_type);
			break;
		case Item_Type.Armor:
			SerializedType();
			break;


		}

	}
	void SerializedType(){

		SerializedObject sO = new SerializedObject(_items.Item(_index));
		sO.Update();
		SerializedProperty sType  =  sO.FindProperty("_type");
		EditorGUILayout.PropertyField(sType);
		sO.ApplyModifiedProperties();

	}
	*/
}
