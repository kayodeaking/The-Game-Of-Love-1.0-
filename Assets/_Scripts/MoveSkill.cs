using UnityEngine;
using System.Collections;

public class MoveSkill : MonoBehaviour {

	public float moveSpeed = .05f;
	Vector3 direction;
	// Use this for initialization
	void Start () {
	
		//direction = Player_Control.VecDirection;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (direction * moveSpeed);
		Destroy (this.gameObject, 2);
	}
}
