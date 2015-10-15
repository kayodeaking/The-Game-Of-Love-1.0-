using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using System.Linq;
using System.IO;
[System.Serializable]
public class Potion_Editor : EditorWindow {
	
	private int _index = 0;
	private Vector2 scrollPosition = Vector2.zero;
	//private Vector2 scrollPosition2 = Vector2.zero;
	private PotionDataBase _potions;
//	SerializedObject so;
	void OnEnable(){

		LoadDataBase();
		
	}
	void LoadDataBase(){
		_potions = (PotionDataBase)AssetDatabase.LoadAssetAtPath<PotionDataBase> ("Assets/Resources/PotionDataBase.asset");
	}

	void OnGUI () {
		
		GUILayout.Label ("Potion DataBase", EditorStyles.boldLabel);
		
		EditorGUILayout.BeginVertical("Box");
			TOP_BUTTONS ();
	
		EditorGUILayout.BeginHorizontal ();
	
			if(_potions.COUNT>0){
				Scroll_Area ();
				Value_Window ();
				}
		EditorGUILayout.EndHorizontal ();
		EditorGUILayout.EndVertical ();
		
		
	}
	void Scroll_Area(){
		
		EditorGUILayout.BeginVertical (GUILayout.Width(250));
		
		scrollPosition = GUILayout.BeginScrollView(scrollPosition,GUILayout.ExpandHeight(true)); 
		if(_potions.COUNT>0){
			ItemTable_Body();
		}
		
		GUILayout.EndScrollView();

		EditorGUILayout.EndVertical ();
		
		
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
		_potions.Add(potion);
	}

	[MenuItem ("DataEditor/Potion")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Potion_Editor));
		
	}
	void ItemTable_Body(){
		
		EditorGUILayout.BeginVertical("Box");
		for (int k = 0; k < _potions.COUNT; k++) {
			EditorGUILayout.BeginHorizontal();
			if(GUILayout.Button(_potions.potion(k).name,"Box",GUILayout.ExpandWidth(true))){
				
				_index = k;

				
			}
			EditorGUILayout.EndHorizontal();
		}
		
		EditorGUILayout.EndVertical();	
		

	}

	
void TOP_BUTTONS(){
	EditorGUILayout.BeginHorizontal ("Box",GUILayout.Width(50));
	
	if(GUILayout.Button("CreateDataBase File")){
		CreatePotionDataBase();
		
	}
	if (GUILayout.Button("New Item")){

			EditorWindow.GetWindow(typeof(NewPotionWindow));

			//CreateNewPotionAsset();
		}

	
	if (GUILayout.Button ("Load DataBase")) {
		//LoadDataBase ();
		
	}
	/*
	if (GUILayout.Button ("Load GameObjects")) {
		//Create_GameObjects ();
	}
	
	if (GUILayout.Button ("Create prefabs")) {

		
	}
	if (GUILayout.Button ("Load Selected GameObject")) {
		//Create_Selected_GameObject ();
		
	}	
	*/
	EditorGUILayout.EndHorizontal();
}
	void Value_Window(){
		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.BeginVertical ("Box",GUILayout.Width(300));

	
	//	_potions.potion(_index).type = (Item_Type)EditorGUILayout.EnumPopup("Type:" , _potions.potion(_index).type);

		_potions.potion(_index).name= EditorGUILayout.TextField("Name",_potions.potion(_index).name);
		_potions.potion(_index).sprite = (Sprite)EditorGUILayout.ObjectField ("Sprite",_potions.potion(_index).sprite, typeof(Sprite), false);
		_potions.potion(_index)._type = (Potion_Type)EditorGUILayout.EnumPopup("Kind",_potions.potion(_index)._type);
		_potions.potion(_index).price = (int)EditorGUILayout.IntSlider("Price",_potions.potion(_index).price ,1, 100);
		_potions.potion(_index).rank = (int)EditorGUILayout.IntSlider("Rank",_potions.potion(_index).rank ,1, 100);
		_potions.potion(_index).stock =  (int)EditorGUILayout.IntSlider("Stock",_potions.potion(_index).stock ,1, 100);
		_potions.potion(_index).duration = (int)EditorGUILayout.IntSlider("Duration",_potions.potion(_index).duration ,1, 100);


		EditorGUILayout.EndVertical ();	
		EditorGUILayout.BeginVertical("Box");
		_potions.potion(_index).description = EditorGUILayout.TextField("Description",_potions.potion(_index).description, GUILayout.Height(100.0f));	
		Effect_listView();
		EditorGUILayout.EndVertical();
		EditorGUILayout.EndHorizontal ();
		
		
		
		
	}

	void Effect_listView(){
		//EditorGUILayout.LabelField("EFFECTS");
		SerializedObject so = new SerializedObject(_potions.potion(_index));
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
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i).FindPropertyRelative("amount"));
				EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i).FindPropertyRelative("e_type"));
				}
			}
		}
		EditorGUI.indentLevel -= 1;
	}



}
