using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class OnClickShop : MonoBehaviour {

	ItemDataBase database;
	GameObject chosenArea;

	// Use this for initialization
	void Start () {
		database = ItemDataBase.GetDataBase ();
		chosenArea = transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.parent.gameObject.transform.parent.GetChild (9).GetChild (0).GetChild (0).GetChild (1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Buy() {

		Item itemToBuy = database.GetItemByName (gameObject.transform.parent.name);
		print (itemToBuy.name + " added to inventory");
	}

	public void Info() {
		Item itemToBuy = database.GetItemByName (gameObject.transform.parent.name);
		int k = 0;
		for (int i = 0; i < 13; i++) {
			if (i == 0) {
				chosenArea.transform.GetChild(i).GetComponent<Text>().text = itemToBuy.description;
			} 
			else if (i == 1) {
				chosenArea.transform.GetChild(i).GetComponent<Text>().text = "Type: " +itemToBuy.type;
			}
			else if (i == 2) {
				chosenArea.transform.GetChild(i).GetComponent<Text>().text = "Rank: " +itemToBuy.rank;
			}
			else if (i == 3) {
				if(itemToBuy.duration > 0) {
					chosenArea.transform.GetChild(i).GetComponent<Text>().text = "Potion Time: " +itemToBuy.duration + " s";
				} else {

					int m = i;
					if(itemToBuy.Effects != null) {
						for (int j = 0; j < itemToBuy.Effects.Count; j ++) {
							chosenArea.transform.GetChild(m).GetComponent<Text>().text = itemToBuy.Effects[j].e_type + ": " + itemToBuy.Effects[j].amount;
							m++;
						}
						k = m;
						i = 11;
					} else {
						k = m;
						i = 11;
					}
				}
			}
			else if ((i >= 4) && (i <= 11)) {

				int m = i;
				if(itemToBuy.Effects != null) {
					for (int j = 0; j < itemToBuy.Effects.Count; j ++) {
						chosenArea.transform.GetChild(m).GetComponent<Text>().text = itemToBuy.Effects[j].e_type + ": " + itemToBuy.Effects[j].amount;
						m++;
					}
					k = m;
					i = 11;
				} else {
					k = m;
					i = 11;
				}
			}
			else {
				chosenArea.transform.GetChild(k).GetComponent<Text>().text = "Stock: " +itemToBuy.stock;
			}
		}
	}
}
