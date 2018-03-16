/*using UnityEngine;
using System.Collections;

public class Getstone : MonoBehaviour {
	GameObject wstone;
	GameObject mole;
	Collider2D cmole;
	// Use this for initialization
	void Start () {
		wstone=GameObject.Find("want_stone_0");
		mole=GameObject.Find("mole");
		//Collider2D colli = GameObject.Find ("mole").GetComponent<Collider2D>;
		cmole = mole.GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		Destroy (gameObject);
		Destroy (wstone);

		cmole.enabled = false;
		
	}
}*/
