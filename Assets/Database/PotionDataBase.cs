using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using System;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;
[Serializable]
public class PotionDataBase : ScriptableObject {
	[SerializeField]
	private List<Potion> database;
	
	void OnEnable(){
	}
	public void Add(Potion potion){
		database.Add (potion);
	}
	public void Remove(Potion potion){
		database.Remove (potion);
		
	}
	public void RemoveAt(int index){
		database.RemoveAt (index);
	}
	
	public int COUNT{
		get { return database.Count; }
		
	}
	public Potion potion (int index){
		return database.ElementAt( index );
	}
}
