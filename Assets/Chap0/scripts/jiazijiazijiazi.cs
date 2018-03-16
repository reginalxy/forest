using UnityEngine;
using System.Collections;

public class jiazijiazijiazi : MonoBehaviour {

	public Sprite close;
	public AudioClip jiazi;
	// Use this for initialization
	void Start () {

	}

	void OnTriggerEnter2D(Collider2D other) {

		//Debug.Log ("Boooom");

		SoundManager.instance.PlaySingle (jiazi);

		//GameManager.playersTurn = false;
		Vector2 cPosition = other.transform.position;
		cPosition.x = 10.6f;
		other.transform.position = cPosition;
		
		GetComponent<SpriteRenderer> ().sprite = close;
		health.lives = 0;


	}
}
