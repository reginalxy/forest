using UnityEngine;
using System.Collections;

public class starnum : MonoBehaviour {
	private int num;
	public Texture2D img1;
	public Texture2D img2;
	public Texture2D img3;
	// Use this for initialization
	void Start () {
		num = star.getcount ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI(){
		if(num==1)
		{


			GUI.DrawTexture(new Rect(450, 220, 100, 100), img1);
		   
		}
		if(num==2)
		{
			GUI.DrawTexture(new Rect(450, 220, 100, 100), img1);
			GUI.DrawTexture(new Rect(550, 190, 100, 100), img2);
		}
		if(num==3)
		{
			GUI.DrawTexture(new Rect(450, 220, 100, 100), img1);
			GUI.DrawTexture(new Rect(550, 190, 100, 100), img2);
			GUI.DrawTexture(new Rect(650, 220, 100, 100), img3);
		}
}
}

	