using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	private GameObject chracter;
	public float Xmin;
	public float Xmax;
	public float Ymin;
	public float Ymax;
	// Use this for initialization
	void Start () {

		chracter = GameObject.Find ("ChracterManager");
		//transform.position = new Vector3 (-10.5f, -0, -9f);
		//min = -8.5f;
		//max = 9.0f;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!ChrachterManager.instance.settingUp) {


			if (!GameManager.playersTurn)
				return;

			float Xtarget = chracter.transform.position.x;
			float Xpos = transform.position.x;
			float Ytarget = chracter.transform.position.y;
			float Ypos = transform.position.y;


			if( (Xtarget < Xmin || Xtarget > Xmax)&& (Ytarget < Ymin || Ytarget > Ymax))
				return;
			if( (Xtarget < Xmin || Xtarget > Xmax)&& (Ytarget > Ymin && Ytarget < Ymax))
				transform.Translate (new Vector3 (0,Ytarget - Ypos, 0));
				
			if( (Xtarget > Xmin && Xtarget < Xmax))

			    transform.Translate (new Vector3 (Xtarget - Xpos,0, 0));
			//if( (Xtarget > Xmin && Xtarget < Xmax)&& (Ytarget > Ymin && Ytarget < Ymax))
			    //transform.Translate (new Vector3 (Xtarget - Xpos,0, 0)); 
			
			
			
			
			//Debug.Log (Xtarget);
		}
	}
}
