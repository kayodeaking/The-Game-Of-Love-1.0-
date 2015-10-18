using UnityEngine;
using System.Collections;

public class PlayerState : MonoBehaviour {
	private Leveling_System ls;

	void Start () {
		ls = gameObject.GetComponent<Leveling_System>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
