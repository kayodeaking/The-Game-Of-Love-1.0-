using UnityEngine;
using System.Collections;
using UnityEditor;
[System.Serializable]
public class NewItemWindow : EditorWindow {

	private string Name;
	private Sprite sprite;
	//private Potion potion;
	//private Armor armor;
	private int price;
	private int rank;
	private ItemDataBase _items;
	public Item_Type Item;
	private int click_count =0;

	void OnEnable(){
		Name = "";
		click_count = 0;
		LoadDataBase();
		
	}
	void LoadDataBase(){
		_items = (ItemDataBase)AssetDatabase.LoadAssetAtPath<ItemDataBase> ("Assets/Resources/ItemDatBase.asset");

	}
	void OnGUI(){
		LoadDataBase();
		EditorGUILayout.BeginVertical();
			Item = (Item_Type)EditorGUILayout.EnumPopup("Type:" , Item);
			Name = EditorGUILayout.TextField("Name",Name);
			price = (int)EditorGUILayout.IntSlider("Price",price ,1, 100);
			rank = (int)EditorGUILayout.IntSlider("Rank",rank ,1, 100);
			sprite = (Sprite)EditorGUILayout.ObjectField (sprite, typeof(Sprite), false);
		if(GUILayout.Button("Done")){
			if(click_count == 0){
				NewItemSelect();
				click_count = 1;
			}
			this.Close();
			this.EndWindows();
		}
		EditorGUILayout.EndVertical();
		
	}
	void OnInspectorUpdate(){
		Repaint ();
	}

	void CreateNewPotionAsset(){
		//Potion potion = ScriptableObject.CreateInstance<Potion>();
		Potion potion = new Potion();
		potion.type = Item;
		potion.name = Name;
		potion.price = price;
		//AssetDatabase.AddObjectToAsset(potion,_items);
		//AssetDatabase.CreateAsset(potion,"Assets/Resources/Items/"+potion.name.ToString()+".asset");
		//AssetDatabase.SaveAssets();
		//AssetDatabase.Refresh();
		_items.Add(potion);


	}
	void CreateNewWeaponAsset(){
		//Weapon weapon = ScriptableObject.CreateInstance<Weapon>();
		Weapon weapon = new Weapon();
		weapon.type = Item;
		weapon.name = Name;
		weapon.price = price;
		weapon.rank = rank;
		weapon.sprite = sprite;
		//AssetDatabase.CreateAsset(weapon,"Assets/Resources/Items/"+weapon.name.ToString()+".asset");
		//AssetDatabase.SaveAssets();
		//AssetDatabase.Refresh();
		_items.Add(weapon);

	}
	void CreateNewArmorAsset(){
		//Armor armor = ScriptableObject.CreateInstance<Armor>();
		Armor armor = new Armor();
		armor.type= Item;
		armor.name = Name;
		armor.price = price;
		armor.rank = rank;
		armor.sprite = sprite;
		if(armor!=null){
		//	AssetDatabase.CreateAsset(armor,"Assets/Resources/Items/"+armor.name.ToString()+".asset");
		//	AssetDatabase.SaveAssets();
		//	AssetDatabase.Refresh();
			_items.Add(armor);	
		}



	}
	
	void NewItemSelect(){
		
		switch(Item){
		case Item_Type.Potion:
			CreateNewPotionAsset();
			break;
		case Item_Type.Weapon:
			CreateNewWeaponAsset();
			break;
		case Item_Type.Armor:
			CreateNewArmorAsset();
			break;
		case Item_Type.Lock:
			Debug.Log("CreateLock");
			break;
		case Item_Type.None:
			break;
			
			
		}
		
		
	}





}
