using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OnClickChapters : MonoBehaviour {

	public static int currChapter = 1;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Chapter1(){
		currChapter = 1;
	}

	public void Chapter2(){
		currChapter = 2;
	}

	public void Chapter3(){
		currChapter = 3;
	}
	
	public void Chapter4(){
		currChapter = 4;
	}

	public void Chapter5(){
		currChapter = 5;
	}
}
