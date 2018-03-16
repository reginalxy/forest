using UnityEngine;
using System.Collections;

public class onGround : MonoBehaviour {

	public AudioClip walking;

	void OnCollisionEnter2D(Collision2D coll) {

		SoundManager.instance.RandomizeSfx (walking);
	}
}
