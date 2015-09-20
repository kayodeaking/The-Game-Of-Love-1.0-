using UnityEngine;
using System.Collections;
using UnityEditor;
[CanEditMultipleObjects]
[CustomEditor(typeof(Test_Items))]
public class Custom_Editor : Editor{
	string[] _choices;
	int _choiceindex = 0;
	public override void OnInspectorGUI(){


	Test_Items myTarget = (Test_Items)target;
		_choices = myTarget.name_arr;
		DrawDefaultInspector ();
		_choiceindex = EditorGUILayout.Popup (_choiceindex,_choices);
		string name = _choices [_choiceindex];
		Item item = myTarget.Find_Item (name);
		EditorGUILayout.LabelField (item.name);
			EditorGUILayout.LabelField (item.type);
		EditorGUILayout.LabelField (item.kind);
		//Editor_ItemList.Show (serializedObject.FindProperty ("itemList"));

		EditorUtility.SetDirty(myTarget);

	}



}
