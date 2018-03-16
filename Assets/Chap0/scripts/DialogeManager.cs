using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class DialogeManager : MonoBehaviour {
	
	public Sprite[] Dialoge1;
	public Sprite[] Dialoge2;
	[HideInInspector]public static bool dSwitch; 		//True for starting dialoges
	
	private Image dSprite;
	private List<Sprite> dImg;
	private int countOfImg;
	private int m;
	
	// Use this for initialization
	void Start () {
		
		dSprite = GetComponent<Image> ();
		dSwitch = false;
		countOfImg = 0;
		m = 1;
		dImg = new List<Sprite> ();
		
	}
	
	void Update(){
		
		if (!dSwitch)
			return;
		
		if (Input.GetMouseButtonDown(0)||Input.GetButtonDown("Jump")) {

			dSprite.enabled=true;


			if(m<countOfImg){
				
				dSprite.sprite=dImg[m];
				m++;
			}
			else
			{
				m=1;
				dImg.Clear();

				dSprite.enabled=false;
				dSwitch=false;

				//yield return 1;
				Invoke("SetPlayersTurn", 0.5f);
			}
		}
		
	}
	
	// Update is called once per frame
	public void displayDialoge(int index){

		if (index==1) {
			
			countOfImg = Dialoge1.Length;
			
			for (int i=0;i<countOfImg;i++)
				dImg.Add(Dialoge1[i]);

		}
		
		else if(index==2){
			
			countOfImg = Dialoge2.Length;
			
			for (int i=0;i<countOfImg;i++)
				dImg.Add(Dialoge2[i]);
		}

		dSprite.enabled=true;
		dSprite.sprite = dImg [0];
		
	}

	void SetPlayersTurn(){

		GameManager.playersTurn=true;
	}
}
