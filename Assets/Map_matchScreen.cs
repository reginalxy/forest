using UnityEngine;
using System.Collections;

public class Map_matchScreen : MonoBehaviour {

	public Vector2 ButtonPosition;
	public Vector2 ButtonSize = new Vector2 (197, 187);
	public Vector2 WallPaperSize = new Vector2 (1920, 1080);

	private float w;
	private float h;
	void Update () {

		//set button position

		w = Screen.width;
		h = Screen.height;

		GetComponent<RectTransform> ().anchoredPosition = new Vector2((ButtonPosition.x - WallPaperSize.x / 2) * w / WallPaperSize.x,
		                                                              (ButtonPosition.y - WallPaperSize.y / 2) * h / WallPaperSize.y);

		//set button size

		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Horizontal, 
		                                                          ButtonSize.x * w / WallPaperSize.x);
		GetComponent<RectTransform> ().SetSizeWithCurrentAnchors (RectTransform.Axis.Vertical, 
		                                                          ButtonSize.y * h / WallPaperSize.y);

	}
}
