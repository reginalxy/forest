using UnityEngine;
using System.Collections;

public class getegg : MonoBehaviour {
	GameObject wegg;
	// Use this for initialization
	void Start () {
		wegg=GameObject.Find("want_egg_0");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) 
	{
		Destroy (gameObject);
		Destroy (wegg);
		
	}
}
