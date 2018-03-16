using UnityEngine;
using System.Collections;

public class passmanerge : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ClickMenu()
	{
		Application.LoadLevel ("Menu");
	}
	public void ClickNext()
	{
		Application.LoadLevel ("Chap2");
	}
	public void Clickrepaly()
	{
		Application.LoadLevel ("chap1");
	}

}
