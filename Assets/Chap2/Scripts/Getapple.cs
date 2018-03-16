using UnityEngine;
using System.Collections;

public class Getapple : MonoBehaviour {
	GameObject wapple;
	// Use this for initialization
	void Start () {
		 wapple=GameObject.Find("want_apple_0");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		Destroy (gameObject);
		Destroy (wapple);
	
	}


}
