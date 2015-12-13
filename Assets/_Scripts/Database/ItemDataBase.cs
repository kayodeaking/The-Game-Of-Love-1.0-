using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
[Serializable]
public class ItemDataBase:ScriptableObject{
	[SerializeField]
	private List<Item> database;


	void OnEnable(){
		if(database==null ){
			database = new List<Item>();
		}
		else {
			for(int i = 0;i<database.Count;i++){
				
				database[i].ID = i;
			}


		}


	}
	public void Add(Item item){
		database.Add(item);
	}
	public void Remove(Item item){
		database.Remove (item);

	}
	public void RemoveAt(int index){
		database.RemoveAt (index);
	}

	public int COUNT{
		get { return database.Count; }
	
	}
	public Item Item(int index){
		return database.ElementAt( index );
	}
	public static ItemDataBase GetDataBase(){
		return (ItemDataBase)Resources.Load<ItemDataBase> ("ItemDatBase");
	}
	public Item GetItemByID(int id){
		
		for(int i =0; i<database.Count;i++){
			if(database[i].ID == id)
				return database[i];
			
		}
		return null;
		
	}
	public Item GetItemByName(string name){

		for (int i =0; i < database.Count; i++) {
			if(database[i].name == name)
				return database[i];
		}
		return null;
	}

	/*
	public void Load_ItemsXML(string filepath){
		TextAsset _xml = Resources.Load<TextAsset>(filepath);
		XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
		StringReader reader  = new StringReader(_xml.text);
		//List<Item> itemList = serializer.Deserialize(reader) as List<Item>;
		reader.Close();
		//database = itemList;
	}
	public void Save_ItemXML(string filepath,List<Item> items){

		var serializer = new XmlSerializer (typeof(List<Item>));
		var stream = new FileStream (filepath, FileMode.Create);
		serializer.Serialize (stream, items);
		stream.Close ();

	}
	*/
}

