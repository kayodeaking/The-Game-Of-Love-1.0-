using UnityEngine;
using System.Collections;
using UnityEditor;

public class Editor_Menus: EditorWindow {
	
	//[MenuItem("DataEditor/ItemDataBase")]
	public static void  CreateItemDataBase(){
		ItemDataBase _items = ScriptableObject.CreateInstance<ItemDataBase>();
		AssetDatabase.CreateAsset (_items, "Assets/Resources/ItemDatBase.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();


	}
	//[MenuItem("DataEditor/Spells")]
	public static void CreateSpells(){

		Spells _spells = ScriptableObject.CreateInstance<Spells>();

		AssetDatabase.CreateAsset(_spells,"Assets/Resources/Spells.asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();

	}



}
