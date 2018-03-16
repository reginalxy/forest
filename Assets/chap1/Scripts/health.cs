using UnityEngine;
using System.Collections;

public class health : MonoBehaviour {
	private const int maxLives = 3;
	public Texture2D img1;
	public static int lives = maxLives;

	//private showfailed sf;
	private Animator animator;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		//sf = GameObject.Find ("failed").GetComponent<showfailed> ();
	}
	public static void DecreaseLive()
		
	{
		
		lives--;
		
		if(lives==0)
			
		{
			GameManager.playersTurn=false;
	
			showfailed.show();


		}
		
	}
	public static void resetlives()
	{
		lives = maxLives;
	}


	// Update is called once per frame
	void Update () 
	{
		if(lives==0)
			
		{
			if(!showfailed.isShow)
				showfailed.show();
			
			
		}
	}
 void OnGUI()
	{
		for(int i=0;i<lives;i++)
		{
			GUI.DrawTexture(new Rect(Screen.width-80-40*i, 40, 40, 40), img1);

		}


	}
void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.tag=="hurt")
		{
			if(animator.GetCurrentAnimatorStateInfo(0).IsTag ("Suoke"))

			{
				Debug.Log("22222");
				return;
			}
			else DecreaseLive();
		}
	}


}
