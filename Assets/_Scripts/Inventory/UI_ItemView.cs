using UnityEngine;
using System.Collections;
using UnityEngine.UI;
[ExecuteInEditMode]
[System.Serializable]
public class UI_ItemView : MonoBehaviour {
	private Image image;
	public Item item;

	// Use this for initialization
	void OnEnable(){
			image = gameObject.GetComponent<Image> ();
			image.overrideSprite = item.sprite;
	}
	void Start () {
		image.overrideSprite = item.sprite;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Image> ().overrideSprite = item.sprite;
	}


	
}
