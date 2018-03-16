using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MatchScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {

		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, Screen.width);
		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, Screen.height);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
