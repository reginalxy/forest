using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class showfailed : MonoBehaviour {

	[HideInInspector]public static bool isShow;
	public static Image failed;
	public static Image menu;
	public static Image restart;
	// Use this for initialization
	void Start () {

		isShow = false;

		failed=GameObject.Find("failed").GetComponent<Image>();
		failed.enabled = false;
		menu=GameObject.Find("menu").GetComponent<Image>();
		menu.enabled = false;
		//Debug.Log("444");
		restart = GameObject.Find ("restart").GetComponent<Image> ();
		restart.enabled = false;


	}

	public static void hide()
	{
		failed.enabled = false;
		menu.enabled = false;
		restart.enabled = false;

		//Debug.Log("33333");

	}
	public static void show()
	{
		isShow = true;
		failed.enabled = true;
		menu.enabled = true;
		restart.enabled = true;

		health.lives=0;
		Debug.Log("lives="+health.lives);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
