using UnityEngine;
using System.Collections;

public class addSquirrel : MonoBehaviour {

	private DialogeManager dm;

	// Use this for initialization
	void Start () {

		dm = GameObject.Find ("Dialoge").GetComponent<DialogeManager> ();

	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {

		GameManager.playersTurn = false;

		//Dialoge
		dm.displayDialoge (1);
		DialogeManager.dSwitch = true;
			//GameManager.playersTurn = true;

		//Debug.Log ("Boooom");

		//GameManager.instance.addNewChracter ();
		//Destroy (gameObject);

	}

	void OnTriggerExit2D(Collider2D other){

		GameManager.instance.addNewChracter ();
		Destroy (gameObject);
	}
}
