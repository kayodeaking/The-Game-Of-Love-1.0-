using UnityEngine;
using System.Collections;
using UnityEditor;

public class NewPotionWindow : EditorWindow {
	private string Name;
	private Sprite sprite;
	private Potion potion;
	private Weapon weapon;
	private Armor armor;
	private int price;
	private int rank;
	private PotionDataBase _potions;
	public Item_Type Item;
	void CreateNewPotionAsset(){
		 potion = ScriptableObject.CreateInstance<Potion>();
		potion.name = Name;
		potion.price = price;
		AssetDatabase.CreateAsset(potion,"Assets/Resources/Items/"+potion.name.ToString()+".asset");
		AssetDatabase.SaveAssets();
		AssetDatabase.Refresh();
		_potions.Add(potion);
	}

	void OnEnable(){
		LoadDataBase();
		/*
		float width =	this.position.width ;
			width  = 200.0f;
		float height = this.position.height;
			height = 200.0f;
			*/
		//this.position.x = EditorWindow.mouseOverWindow.position.x;
		//this.position.y = EditorWindow.mouseOverWindow.position.y;

	}
	void LoadDataBase(){
		_potions = (PotionDataBase)AssetDatabase.LoadAssetAtPath<PotionDataBase> ("Assets/Resources/PotionDataBase.asset");
	}
	void OnGUI(){

		EditorGUILayout.BeginVertical();
			Item = (Item_Type)EditorGUILayout.EnumPopup("Type:" , Item);
			Name = EditorGUILayout.TextField("Name",Name);
			price = (int)EditorGUILayout.IntSlider("Price",price ,1, 100);
			rank = (int)EditorGUILayout.IntSlider("Rank",rank ,1, 100);
			sprite = (Sprite)EditorGUILayout.ObjectField (sprite, typeof(Sprite), false);
			



		if(GUILayout.Button("Done")){
			ItemSelect();
			this.Close();
		}
		EditorGUILayout.EndVertical();

	}

	 void ItemSelect(){

		switch(Item){
		case Item_Type.Potion:
			CreateNewPotionAsset();
			break;

		case Item_Type.Weapon:
			Debug.Log("CreateWeapon");
			break;

		case Item_Type.Armor:
			Debug.Log("CreateArmor");
			break;
		case Item_Type.Lock:
			Debug.Log("CreateLock");
			break;
		case Item_Type.None:
			break;


		}

	
	}

}
