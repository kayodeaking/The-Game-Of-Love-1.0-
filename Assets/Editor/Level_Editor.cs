using UnityEngine;
using System.Collections;
using UnityEditor;
[System.Serializable]
public class Level_Editor :EditorWindow {
	private Vector2 scrollPosition = Vector2.zero;
	private Levels lvls;
	private int _index;
	// Use this for initialization
	void OnEnable(){

		lvls = Resources.Load<Levels>("Levels");

	}
	[MenuItem ("DataEditor/Leveling System Editor")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Level_Editor));
		
		
	}
	
	void OnGUI () {
		GUILayout.Label ("Level Editor", EditorStyles.boldLabel);

		EditorGUILayout.BeginVertical();
	
		EditorGUILayout.BeginHorizontal ();
		ScrollArea();
		Body();
		EditorGUILayout.EndHorizontal();

		EditorGUILayout.EndVertical();

	}
	void ScrollArea(){
		EditorGUILayout.BeginVertical (GUILayout.Width(250));
		if(GUILayout.Button("+",GUILayout.ExpandWidth(true))){
			lvls.Add(new Level());
			
		}
		scrollPosition = GUILayout.BeginScrollView(scrollPosition,GUILayout.ExpandHeight(true)); 

		for(int i = 0;i<lvls.COUNT;i++){
			
			EditorGUILayout.BeginHorizontal();
			
			if(GUILayout.Button(i.ToString(),"Box",GUILayout.ExpandWidth(true))){
				_index= i;
				
			}
			EditorGUILayout.EndHorizontal();
		}


		GUILayout.EndScrollView();
	
		EditorGUILayout.EndVertical ();


	}

	void Body(){
		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.BeginVertical ("Box",GUILayout.Width(300));
		lvls.Level(_index).xp = EditorGUILayout.IntField("xp",lvls.Level(_index).xp);
		lvls.Level(_index).Blood =  EditorGUILayout.IntField("Blood",lvls.Level(_index).Blood);
		lvls.Level(_index).Love = EditorGUILayout.IntField("Love",lvls.Level(_index).Love);
		lvls.Level(_index).Strength = EditorGUILayout.IntField("Stregnth",lvls.Level(_index).Strength);
		lvls.Level(_index).Intelligence = EditorGUILayout.IntField("Intelligence",lvls.Level(_index).Intelligence);
		lvls.Level(_index).Dexterity = EditorGUILayout.IntField("Dexterity",lvls.Level(_index).Dexterity);
		lvls.Level(_index).Luck = EditorGUILayout.IntField("Luck",lvls.Level(_index).Luck);
		EditorGUILayout.EndVertical();
		EditorGUILayout.EndHorizontal();


	}

}
