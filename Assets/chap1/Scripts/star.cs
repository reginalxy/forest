using UnityEngine;
using System.Collections;

public class star : MonoBehaviour {
	private static int count;

	// Use this for initialization
	void Start () {
		count = 0;
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (gameObject);
		count++;
		Debug.Log (count);
	}
	// Update is called once per frame
	void Update () {

	
	}
	public static int getcount()
	{
		return count;
	}
}
