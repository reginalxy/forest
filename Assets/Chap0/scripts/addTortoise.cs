using UnityEngine;
using System.Collections;

public class addTortoise : MonoBehaviour {
	
	private DialogeManager dm;
	
	// Use this for initialization
	void Start () {
		
		dm = GameObject.Find ("Dialoge").GetComponent<DialogeManager> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other) {
		
		GameManager.playersTurn = false;
		
		//Dialoge
		dm.displayDialoge (2);
		DialogeManager.dSwitch = true;
		
	}
	
	void OnTriggerExit2D(Collider2D other){
		
		GameManager.instance.addNewChracter ();
		Destroy (gameObject);
	}
}
