using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttomMatchScreen : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Screen.width*3/10);
		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Screen.height/5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}