using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class levelmanerge : MonoBehaviour {
	private Image chap0;
	private Image chap1;
	private Image chap2;
	// Use this for initialization
	void Start () {
		//chap0=GameObject.Find("Chap0").GetComponent<Image>();
		//chap0.enabled = false;
		chap1=GameObject.Find("Chap1").GetComponent<Image>();
		chap1.enabled = false;
		chap2 = GameObject.Find ("Chap2").GetComponent<Image> ();
		chap2.enabled = false;
		if (GameManager.chap1)
			chap1.enabled = true;
		//Debug.Log (GameManager.chap1);
		if (GameManager.chap2)
			chap2.enabled = true;


	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
