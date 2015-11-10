using UnityEngine;
using System.Collections;
using UnityEditor;
using System.Collections.Generic;
[System.Serializable]
[CustomEditor(typeof(Inventory))]
public class InventoryInspector : Editor {
//	Inventory inventory;

	// Use this for initialization
	void Start () {
	//	inventory = (Inventory)target;

	}
	// Update is called once per frame
	void Update () {
	
	}
	public override void OnInspectorGUI () {
		DrawDefaultInspector();
		/*
		serializedObject.Update();
	 	EditorGUILayout.PropertyField(serializedObject.FindProperty("Slot") );
		Show (serializedObject.FindProperty("inventory"));
		serializedObject.ApplyModifiedProperties();
		*/

	}
	public void Show (SerializedProperty list) {
		EditorGUILayout.PropertyField(list);
		EditorGUI.indentLevel += 1;
		if (list.isExpanded) {
			for (int i = 0; i < list.arraySize; i++) {
				SerializedProperty so_Object =  list.GetArrayElementAtIndex(i);
				EditorGUILayout.PropertyField(so_Object.FindPropertyRelative("name"));
			

			
			}
		}
		EditorGUI.indentLevel -= 1;
	}
}
