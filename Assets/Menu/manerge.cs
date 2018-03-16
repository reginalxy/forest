using UnityEngine;
using System.Collections;

public class manerge : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Click0()
	{

			
			Application.LoadLevel("Chap0");
			health.lives=0;
			health.resetlives ();
			
			
	}
	public void Click1()
	{
		
		
		Application.LoadLevel("chap1");
		health.lives=0;

		health.resetlives ();
		
		
	}
	public void Click2()
	{
		
		
		Application.LoadLevel("Chap2");
		health.lives=0;
	
		health.resetlives ();
		
		
	}
}
