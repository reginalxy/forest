using UnityEngine;
using System.Collections;

public class Next : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) {
		if (GameManager.chTab == 2) {
			Debug.Log("1111");
			Application.LoadLevel("chap1");
			GameManager.chap1=true;
		}
	}
}
