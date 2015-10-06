using UnityEngine;
using System.Collections;
using UnityEngine.UI;
///[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CircleCollider2D))]
 
//[ExecuteInEditMode]
public class Enemy : MonoBehaviour {
	public int health =100;
	public int maxHealth = 100;
	public int damage= 10;
	public Image image;
	public GameObject player;
	float sqrMagnitude;
	public float Magnitude = 3.0f;
	public bool attack = false;
	private Animator anim;
	void Init(){
		anim = gameObject.GetComponent<Animator>();
		image = gameObject.transform.GetComponentInChildren<Image>();
		//player = GameObject.FindGameObjectWithTag("Player");
		sqrMagnitude = Magnitude*Magnitude;

	}
	// Use this for initialization
	void Start () {
		Init();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 direction;
		direction = player.transform.position - transform.position;
		if(Vector3.SqrMagnitude(direction) < sqrMagnitude){
			attack = true;
			//Attack(damage);
			//anim.SetBool("Attack",attack);

		}
		else{
			attack= false;
		}


		anim.SetBool("Attack",attack);



		if(health<=0){
			Destroy(this.gameObject);
		}
	}

	public void Shoot(){


	}
	void OnDestory(){
		print ("DIE");
	}

	public void Hit(int dmg){
		health-= dmg;
		image.fillAmount =(float)health/(float)maxHealth;

	}
	

	[ContextMenu("Damage")]
	public void TestDMG(){
		player.gameObject.GetComponent<Player_Stats>().Hit (damage);
		//Hit(damage);
		
	}



}
