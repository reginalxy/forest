using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Events;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frames

	public void Click0 () 
	{
			
			
		Application.LoadLevel("Chap0");
			health.lives=0;
			//Application.LoadLevel();
			Invoke("hide",2f);
			health.resetlives ();
			//Debug.Log ("999");
			
	}
	
	public void Click1 () 
	{
		
		
		Application.LoadLevel("chap1");
		health.lives=0;
		//Application.LoadLevel();
		Invoke("hide",2f);
		health.resetlives ();
		//Debug.Log ("999");
		
	}
	
	public void Click2 () 
	{
		
		
		Application.LoadLevel("Chap2");
		health.lives=0;
		//Application.LoadLevel();
		Invoke("hide",2f);
		health.resetlives ();
	//	Debug.Log ("999");
		
	}
	void hide()
	{
		showfailed.hide ();
	}

}

