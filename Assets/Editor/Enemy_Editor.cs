using UnityEngine;
using System.Collections;
using UnityEditor;
[System.Serializable]
public class Enemy_Editor :EditorWindow {
	private Enemys e;
	private int _index;
	private Vector2 scrollPosition = Vector2.zero;
	void OnEnable(){
		_index =0;
		if(e){

		e = Resources.Load<Enemys>("Enemys");
		}

		else {
			e = ScriptableObject.CreateInstance<Enemys>();
			AssetDatabase.CreateAsset (e, "Assets/Resources/Enemys.asset");
			AssetDatabase.SaveAssets();
			AssetDatabase.Refresh();
		}


	}
//	[MenuItem ("DataEditor/Enemy Editor")]
	public static void  ShowWindow () {
		EditorWindow.GetWindow(typeof(Enemy_Editor));
		
		
	}

	void OnGUI () {
		try{
		GUILayout.Label ("Enemy Editor", EditorStyles.boldLabel);
		
		EditorGUILayout.BeginVertical();
		
		EditorGUILayout.BeginHorizontal ();
		ScrollArea();
		Body ();

		EditorGUILayout.EndHorizontal();
		
		EditorGUILayout.EndVertical();

		}

		catch (System.ArgumentOutOfRangeException ex){
			Debug.Log(ex.ToString());
		}
		catch(System.NullReferenceException ex){
			Debug.Log(ex.ToString());
			this.Close();
		}

	}
	void ScrollArea(){

		EditorGUILayout.BeginVertical (GUILayout.Width(250));
		scrollPosition = GUILayout.BeginScrollView(scrollPosition,GUILayout.ExpandHeight(true)); 

		for(int i = 0;i<e.COUNT;i++){
			
			EditorGUILayout.BeginHorizontal();
			
			if(GUILayout.Button(e.Enemy(i).name,"Box",GUILayout.ExpandWidth(true))){
				_index= i;
				
			}
			
			EditorGUILayout.EndHorizontal();
		}


		
		GUILayout.EndScrollView();
		if(GUILayout.Button("+",GUILayout.ExpandWidth(true))){
			
			e.Add (new EnemyData());
			
		}
		EditorGUILayout.EndVertical ();

	}



	void Body(){

		EditorGUILayout.BeginHorizontal ();
		EditorGUILayout.BeginVertical ("Box",GUILayout.Width(300));
		e.Enemy(_index).name =  EditorGUILayout.TextField("Name",e.Enemy(_index).name);
		e.Enemy(_index).maxHealth = EditorGUILayout.IntField("Health",e.Enemy(_index).maxHealth);
		e.Enemy(_index).damage = EditorGUILayout.IntField("Damage",e.Enemy(_index).damage);
		e.Enemy(_index).Age = EditorGUILayout.IntField("Age",e.Enemy(_index).Age);

	


		EditorGUILayout.EndVertical();
		EditorGUILayout.EndHorizontal();


	}
}
