using UnityEngine;
using System.Collections;

public class replay : MonoBehaviour {
	public string level;

	public void button(){

			//Debug.Log("pop");

			GameManager.instance.enabled = false;
			Application.LoadLevel("level");
		health.resetlives ();
	}
}
