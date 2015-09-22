using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoEnemyImage : MonoBehaviour {

	Image image;
	public Sprite enemyImage;
	public Sprite blank;
	// Use this for initialization
	void Start () {
	
		image = GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		if (MonsterInfo.unlock == true) {
			if(MonsterInfo.enemyName != null) {
				image.sprite = enemyImage;
			}
		} else {
			image.sprite = blank;
		}
	}
}
