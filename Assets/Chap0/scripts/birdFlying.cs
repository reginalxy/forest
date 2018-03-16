using UnityEngine;
using System.Collections;

public class birdFlying : MonoBehaviour {

	public AudioClip flying;

	private bool startFlying = false;
	float xv;
	Vector2 v;
	//Vector3 r;
	
	// Use this for initialization
	void Start () {

		startFlying = false;
		xv = 0;
		v = GetComponent<Rigidbody2D> ().velocity;
		//r = new Vector3 (0, 0, 1f);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!startFlying)
			return;

		xv += -0.1f;
		v = new Vector2 (xv, v.y);
		GetComponent<Rigidbody2D> ().velocity = v;
		transform.Rotate (0, 0, 1);
		//r.z+=0.1f;
		//transform.forward = new Vector3 (0, 0, 25);

		if (transform.position.y > 7.0f)
			Destroy (gameObject);
	
	}

	void OnTriggerEnter2D(Collider2D other) {
	
		SoundManager.instance.PlaySingle (flying);
		GetComponent<Animator> ().SetTrigger ("fly");
		startFlying = true;
		fly ();
		Destroy (GetComponent<Collider2D> ());
	}

	void fly(){
		
		v = new Vector2 (0f, 0.5f);
		GetComponent<Rigidbody2D> ().velocity = v;
	}
}
