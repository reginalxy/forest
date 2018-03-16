using UnityEngine;
using System.Collections;

public class hualun : MonoBehaviour {
	private Animator amt ;
	private GameObject star2;
	// Use this for initialization
	void Start () {
		amt = GetComponent<Animator> ();
		star2 = GameObject.Find ("star2");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag=="Player") 
		{
			Debug.Log(other.gameObject.tag);
			amt.SetTrigger("Move");
			//amt.SetTrigger ("Down");
			star2.transform.position = new Vector3 (star2.transform.position.x, -6f, 0f);
		}
	}
}
