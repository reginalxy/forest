using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class onTree : MonoBehaviour {
	
	private Image black;
	private GameObject chracter;
	private GameObject tortoise;
	private Rigidbody2D rb2d; 

	void Start(){

		chracter = GameObject.Find ("ChracterManager");
		tortoise = GameObject.Find ("tortoise");
		rb2d = chracter.GetComponent<Rigidbody2D> ();
		black = GameObject.Find ("black").GetComponent<Image> ();
	}
	
	void OnTriggerEnter2D(Collider2D other) {

		//Debug.Log ("enter tree");


		if (GameManager.chTab != 1)
			return;

		ChrachterManager.Standing = false;

		Destroy (GetComponent<Rigidbody2D> ());
		Destroy (GetComponent<Collider2D> ());

		GameManager.playersTurn = false;
		//Debug.Log (GameManager.playersTurn);
				
		Invoke ("function1", 2);
		rb2d.isKinematic = true;

		//
		//tab
		//
		chracter.GetComponent<Animator> ().SetTrigger ("Climb");
		Invoke ("climbUp", 0.5f);
		
		//Debug.Log ("Boooom");
		
	}
	
	void function1(){

		black.enabled = true;

		rb2d.velocity = Vector2.zero;
		rb2d.isKinematic = false;
		
		chracter.transform.position = new Vector3 (3.2f, -3, 0);
		tortoise.transform.position = new Vector3 (7.5f, -3, 0);
		
		Invoke ("function2", 3.5f);
	}
	
	void function2(){

		GameManager.instance.switchChracter ();
		GameManager.playersTurn = true;
		tortoise.GetComponent<Collider2D> ().isTrigger = true;
		black.enabled = false;
		ChrachterManager.Standing = true;
	}

	void climbUp(){

		rb2d.velocity = new Vector2 (0f, 2.1f);
	}


}
