using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickChapters : MonoBehaviour {

	public GameObject chapter1;
	public GameObject chapter2;
	public GameObject chapter3;
	public GameObject chapter4;
	public GameObject chapter5;
	public GameObject options;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Chapter1(){
		chapter1.SetActive (true);
		chapter2.SetActive (false);
		chapter3.SetActive (false);
		chapter4.SetActive (false);
		chapter5.SetActive (false);
	}

	public void Chapter2(){
		chapter1.SetActive (false);
		chapter2.SetActive (true);
		chapter3.SetActive (false);
		chapter4.SetActive (false);
		chapter5.SetActive (false);
	}

	public void Chapter3(){
		chapter1.SetActive (false);
		chapter2.SetActive (false);
		chapter3.SetActive (true);
		chapter4.SetActive (false);
		chapter5.SetActive (false);
	}
	
	public void Chapter4(){
		chapter1.SetActive (false);
		chapter2.SetActive (false);
		chapter3.SetActive (false);
		chapter4.SetActive (true);
		chapter5.SetActive (false);
	}

	public void Chapter5(){
		chapter1.SetActive (false);
		chapter2.SetActive (false);
		chapter3.SetActive (false);
		chapter4.SetActive (false);
		chapter5.SetActive (true);
	}

	public void Volume() {
	}

	public void SE() {
	}

	public void Open_Options() {
		options.SetActive (true);
		chapter1.SetActive (false);
		chapter2.SetActive (false);
		chapter3.SetActive (false);
		chapter4.SetActive (false);
		chapter5.SetActive (false);
	}

	public void Close_Options() {
		options.SetActive (false);
		chapter1.SetActive (true);
		chapter2.SetActive (false);
		chapter3.SetActive (false);
		chapter4.SetActive (false);
		chapter5.SetActive (false);
	}
}
