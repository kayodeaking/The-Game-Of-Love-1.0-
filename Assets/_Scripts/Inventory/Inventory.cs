using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
using UnityEditor;
using LitJson;

[System.Serializable]
public class Inventory : MonoBehaviour {
	
	//public GameObject inventoryPanel;
	public GameObject slotPanel;
	ItemDataBase database;
	public 	GameObject inventorySlot;
	public GameObject inventoryItem;
	//string data;

	public int slotAmount =8;
	private List<Item> items = new List<Item>();

	private List<GameObject> slots = new List<GameObject>();
	public List<Item> inventory  = new List<Item>();

	// Use this for initialization
	void Start () {
		
		database = ItemDataBase.GetDataBase();
		

		//inventoryPanel = GameObject.Find("Inventory_Panel");
		//slotPanel = inventoryPanel.transform.FindChild("Slot_Panel").gameObject;
		
		for(int i =0;i<slotAmount;i++){
				items.Add(new Item());
			slots.Add (Instantiate(inventorySlot));
			slots[i].GetComponent<UI_Slot>().id = i;
			slots[i].transform.SetParent(slotPanel.transform);

		}
		AddItem(0);
		AddItem(1);
		AddItem(1);
		AddItem(1);
	
	
	}
	
	
	public void AddItem(int id){

		Item itemtoAdd = database.GetItemByID(id);
		inventory.Add(itemtoAdd);
	
		if(itemtoAdd.Stackable && CheckifItemisInInventory(itemtoAdd)){
			
			for(int i =0;i<items.Count;i++){
				if(items[i].ID == id){
					UI_Item data = slots[i].transform.GetChild(0).GetComponent<UI_Item>();
					data.amount++;
					data.transform.GetChild(0).GetComponent<Text>().text = data.amount.ToString();
					break;
					
				}
			}
		}
		else{
			for(int i =0;i<items.Count;i++){
				
				if(items[i].ID ==-1){
					items[i] = itemtoAdd;
					GameObject itemObj = Instantiate(inventoryItem) as GameObject;
					itemObj.GetComponent<UI_Item>().item = itemtoAdd;
					itemObj.GetComponent<UI_Item>().slot = i;
					itemObj.GetComponent<UI_Item>().amount = 1;
					itemObj.transform.SetParent(slots[i].transform);
					itemObj.transform.position = Vector2.zero;
					itemObj.GetComponent<Image>().sprite = itemtoAdd.sprite;
					itemObj.name = itemtoAdd.name;
					break;
				}
	
	
			}
		}

	}
	
	bool CheckifItemisInInventory(Item item){
		for(int i=0;i<items.Count;i++){
			
			if(items[i].ID ==item.ID){
				 return true;
				
			}
			
		}
		return false;
		
		
	}
	public void Remove(Item item){
		items.Remove (item);
		
	}

	public void RemoveAt(int index){
		items.RemoveAt (index);
	}
	[ContextMenu("Save")]
	public void Save(){
		print("Write");
	//	string [] data = new string[items.Count];
		//FileStream fs = new FileStream(Application.dataPath+"/Inventory.json", FileMode.Create);
		//StreamWriter writer = new StreamWriter(fs);

			
		//string data = JsonUtility.ToJson(inventory,true);
			
			//print(data);
			//writer.Write(data);
			//JsonUtility.ToJson(items[i],true);
		//print(data);

	


		//File.WriteAllText(Application.dataPath+"/Inventory.json",data);
		//writer.Close();
		//fs.Close();
	
		//AssetDatabase.Refresh()
	
		
	}
	[ContextMenu("Load")]
	public void Load(){
		print("READ");
	//	FileStream fs = new FileStream(Application.dataPath+"/Inventory.json", FileMode.Create);
	//	string data =  File.ReadAllText(Application.dataPath+"/Inventory.json");


	


	


		
	

	}
	
}

