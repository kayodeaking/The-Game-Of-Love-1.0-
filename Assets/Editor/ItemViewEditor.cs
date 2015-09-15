using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
[CustomEditor(typeof(Item_View))]
[CanEditMultipleObjects]
public class ItemViewEditor : Editor {
	
	string[] _choices;
	int _choiceindex = 0;
	Test_Items testItems;
	Item item;
	// Use this for initialization
	void Enable(){
		testItems = new Test_Items ();
		item = new Item ();
		//testItems.name_arr.CopyTo(_choices);

	}
	public override void OnInspectorGUI(){

		Item_View myTarget = (Item_View)target;

		/*

		DrawDefaultInspector ();		
		_choiceindex = EditorGUILayout.Popup (_choiceindex,_choices);
		string name = _choices [_choiceindex];
		item  = testItems.Find_Item (name);
		EditorGUILayout.LabelField (item.name);
		//EditorGUILayout.LabelField (item.type);
		//EditorGUILayout.LabelField (item.kind);


		//EditorUtility.SetDirty(myTarget);
*/
	}
}
