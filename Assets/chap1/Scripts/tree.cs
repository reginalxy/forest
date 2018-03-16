using UnityEngine;
using System.Collections;

public class tree : MonoBehaviour {
	public float climbSpead=0.06f;

	private bool canClimb;
	private Animator amt;
	private GameObject chracter;
	private Rigidbody2D rb2d; 
//	private Collider2D c;
	// Use this for initialization
	void Start () {
		chracter=GameObject.Find ("ChracterManager");
		amt = GameObject.Find ("ChracterManager").GetComponent<Animator> ();
		rb2d = chracter.GetComponent<Rigidbody2D> ();
//		c = chracter.GetComponent<Collider2D>();
		canClimb = false;
	}
	
	// Update is called once per frame
	void Update () {
		//OnTriggerEnter2D (c);
		//Debug.Log("@@@@@");
		if(canClimb && GameManager.chTab == 1)
		{
			//Debug.Log("@@@@@");
			if (Input.GetButton("Up")) 
			{
				amt.SetTrigger("Climb");
				chracter.transform.position = chracter.transform.position + new Vector3(0,climbSpead,0);
				
			}
			if (Input.GetButton("Down")) 
			{
				amt.SetTrigger("Climb");
				chracter.transform.position = chracter.transform.position - new Vector3(0,climbSpead,0);
				
			}
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){

		//Debug.Log (other.gameObject == chracter);
		if (other.gameObject == chracter && GameManager.chTab == 1) {
			canClimb=true;
			rb2d.isKinematic=true;
			ChrachterManager.Standing=false;
			//Debug.Log ("canClimb="+canClimb);
		}
	}

	void OnTriggerExit2D(Collider2D other){

		//Debug.Log ("exit");
		if (other.gameObject == chracter && GameManager.chTab == 1) {
			canClimb=false;
			rb2d.isKinematic=false;
			ChrachterManager.Standing=true;
			//amt.SetTrigger("Stand");
			//Debug.Log ("canClimb="+canClimb);
		}
	}


	/*void function1(){
		

		
		//rb2d.velocity = Vector2.zero;
		rb2d.isKinematic = false;
		
		chracter.transform.position = new Vector3 (-22, 6f, 5);

	
	}
	void climbUp(){

		rb2d.velocity = new Vector2 (0f, 0.5f);
	}*/
}
