using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Linq;
using System.IO;




public static class ItemData {

		//public List<Item> itemList;


		public static List<Item> Load_Items(string filepath){
				TextAsset _xml = Resources.Load<TextAsset>(filepath);
				XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
				StringReader reader  = new StringReader(_xml.text);
				List<Item> itemList = serializer.Deserialize(reader) as List<Item>;
				reader.Close();
				return itemList;
		}

		public static void Save_Items(string filepath){

		}
	/*
		public Item Find_Item(string name){
			

			return itemList.Find (x => x.name.Equals (name));
			

		}
*/
	//	public static List<Item> Item_List{ get{ return itemList; }}



		




}
