using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class Effects_List {
	[SerializeField]
	private List<Effect> effects;


	public void Add(Effect effect){
		effects.Add (effect);
	}

	public void Remove(Effect effect){
		effects.Remove (effect);
		
	}

	public void RemoveAt(int index){
		effects.RemoveAt (index);
	}
	
	public int COUNT{
		get { return effects.Count; }
		
	}
	public Effect effect (int index){
		return effects.ElementAt( index );
	}
	public List<Effect> e {
		get{ return effects;  }

	}


	
}

