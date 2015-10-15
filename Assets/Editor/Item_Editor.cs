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
	//private Vector2 scrollPosition2 = Vector2.zero;

	private ItemDataBase _items;
	private PotionDataBase _potions;
	//Item_Type itemTYPE = Item_Type.None;
	Potion_Type p_type = Potion_Type.None;
	Weapon_Type w_type = Weapon_Type.None;
	void OnEnable(){
		_index= 0;
	if(_items==null)
			LoadDataBase ();
		//itemList = (List<Item>)ItemDataBase.Load_ItemsXML ("Item_Data");

	}
	void LoadDataBase(){
		_items = (ItemDataBase)AssetDatabase.LoadAssetAtPath<ItemDataBase> ("Assets/Resources/ItemDataBase.asset");
		if(_items==null)
			CreateDataBase();

	}
	void CreateDataBase(){
		_items = ScriptableObject.CreateInstance<ItemDataBase>();
		AssetDatabase.CreateAsset (_items, "Assets/Resources/ItemDatBase.asset");
		//_items.Load_ItemsXML ("Item_Data");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	}
	void CreatePotionDataBase(){
		_potions = ScriptableObject.CreateInstance<PotionDataBase>();
		AssetDatabase.CreateAsset (_potions, "Assets/PotionDataBase.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	}
	void CreateNewPotionAsset(){
		Potion potion = ScriptableObject.CreateInstance<Potion>();
		AssetDatabase.CreateAsset(potion,"Assets/Potion.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
	}

	[MenuItem ("DataEditor/Item")]
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
			if(_items.Item(k)){
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


	void Value_Window(){
		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.BeginVertical ("Box",GUILayout.Width(300));
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
*/	 try {
	
		_items.Item(_index).Item = (Item_Type)EditorGUILayout.EnumPopup("Type:" , _items.Item(_index).Item);
		_items.Item(_index).name= EditorGUILayout.TextField("Name",_items.Item(_index).name);
		FindKindType(_items.Item(_index).Item);
		Effect_listView();
		}
	catch (System.ArgumentOutOfRangeException ex){
			Debug.Log ("OUT OF RANGE");
		}
		//FindKindType ();
		//scrollPosition2 = GUILayout.BeginScrollView(scrollPosition2,GUILayout.ExpandHeight(true)); 
		//EditorGUILayout.TextField ("Description", itemList [_index].description);
		//EditorGUILayout.TextArea (itemList [_index].description,GUILayout.ExpandHeight(true));
	//	GUILayout.EndScrollView ();


		EditorGUILayout.EndVertical ();	
		EditorGUILayout.BeginVertical("Box");
		_items.Item(_index).description = EditorGUILayout.TextField("Description",_items.Item(_index).description , GUILayout.Height(100.0f));
		_items.Item(_index).price= 	(int)EditorGUILayout.IntField("Price",_items.Item(_index).price);
		_items.Item(_index).rank = (int)EditorGUILayout.IntField("Rank",_items.Item(_index).rank);
		_items.Item(_index).stock = (int)EditorGUILayout.IntField("Stock",_items.Item(_index).stock);
		_items.Item(_index).duration =(int)EditorGUILayout.IntField("Duration",_items.Item(_index).duration);
		EditorGUILayout.EndVertical();
		EditorGUILayout.EndHorizontal ();




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
		/*
		if (GUILayout.Button ("Create prefabs")) {
			CreateNewPotionAsset();

		}
		if (GUILayout.Button ("Load Selected GameObject")) {
			Create_Selected_GameObject ();

		}	
		*/
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
		/*
		foreach (Item i in itemList) {

			//GameObject go = new GameObject (i.name+" Game Object");
			//go.gameObject.AddComponent<Item_View> ().item = i;



			//Object prefab =PrefabUtility.CreateEmptyPrefab("Assets/"+i.name+".prefab");
			//EditorUtility.ReplacePrefab(i.gameObject, prefab, ReplacePrefabOptions.ConnectToPrefab);
		}
		*/

	}
	void Create_GameObjects(){
		/*
		foreach (Item i in itemList) {

			GameObject go = new GameObject (i.name + " Game Object");
			go.gameObject.AddComponent<Item_View> ().item = i;

		}
	*/

	}

	void Create_Selected_GameObject(){

		GameObject go = new GameObject (_items.Item(_index).name + "-Object");
		go.gameObject.AddComponent<Item_View> ().itemID = _index;

	}
	void Effect_listView(){
		//EditorGUILayout.LabelField("EFFECTS");
		SerializedObject so = new SerializedObject(_items.Item(_index));
		SerializedProperty sp  = so.FindProperty("Effects");
		Show(sp,true);
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
					//SerializedProperty so_Amount =
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
}
