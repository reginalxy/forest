using UnityEngine;
using System.Collections;

public class DiDao : MonoBehaviour {
	public float inDidaoGravityScale;

	private GameObject player;
	private float Gscale = 0.5f;

	// Use this for initialization
	void Start () {

		player = GameObject.Find ("ChracterManager");
		Gscale = player.GetComponent<Rigidbody2D> ().gravityScale;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject == player)
			player.GetComponent<Rigidbody2D> ().gravityScale = inDidaoGravityScale;
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject == player)
			player.GetComponent<Rigidbody2D> ().gravityScale = Gscale;
	}
}
