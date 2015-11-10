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


}
