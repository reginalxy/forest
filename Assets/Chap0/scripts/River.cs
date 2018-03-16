using UnityEngine;
using System.Collections;

public class River: MonoBehaviour {

	public AudioClip swimming;
	public  Collider2D c;


	private Animator amt;

	void Start(){

		amt = GameObject.Find ("ChracterManager").GetComponent<Animator> ();
		c=GameObject.Find ("ChracterManager").GetComponent<Collider2D> ();
	}
	void Update()
	{
		//OnTriggerEnter2D (c);
	}
	
	void OnTriggerEnter2D(Collider2D other) {

		//Debug.Log ("enter river");
		SoundManager.instance.RandomizeSfx (swimming);
		if (GameManager.chTab == 2) {
			//
			//tab
			//
			amt.SetTrigger("Swim");
		
		}

		else {

			c.isTrigger=true;



			showfailed.show();
			health.resetlives();
		}
	}
}
/*	void OnTriggerStay2D(Collider2D other) {
		
		//Debug.Log ("enter river");
		//SoundManager.instance.RandomizeSfx (swimming);
		if (GameManager.chTab == 2) {
			//
			//tab
			//
			amt.SetTrigger("Swim");
			Application.LoadLevel("chap1");
		}
		
		else {
			
			c.isTrigger=true;
			GameManager.instance.GameOver();

		}
	}
}
*/