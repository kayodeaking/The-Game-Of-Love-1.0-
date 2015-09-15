using UnityEngine;
using UnityEditor;
using System.Collections;

public static class Editor_ItemList  {

	public static void Show (SerializedProperty list) {
		EditorGUILayout.PropertyField(list);
		for (int i = 0; i < list.arraySize; i++) {
			EditorGUILayout.PropertyField(list.GetArrayElementAtIndex(i));
		}
	}
}
