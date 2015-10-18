using UnityEngine;
using System.Collections;
using UnityEditor;

public class Editor_Menus:EditorWindow {
	
	//[MenuItem("DataEditor/ItemDataBase")]
	public static void  CreateItemDataBase(){
		ItemDataBase _items = ScriptableObject.CreateInstance<ItemDataBase>();
		AssetDatabase.CreateAsset (_items, "Assets/Resources/ItemDatBase.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();


	}
	public static void AddItem(){

	}
	[MenuItem("DataEditor/Create Levels")]
	public static void CreateLevels(){

		Levels lvls = ScriptableObject.CreateInstance<Levels>();
		AssetDatabase.CreateAsset(lvls,"Assets/Resources/Levels.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();

	}
}
