using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {

	public static bool chap1=false;
	public static bool chap2=false;

	public static int levelnum=0;
	public bool IsJiaoxueguan=false;
	public AudioClip switching;
	public AudioClip addTeam;
	//贴图
	// public Sprite[] chRenderer;							//Sprites on chracter
	public Sprite[] chSwitchImg;						//Sprites on UI
	public RuntimeAnimatorController[] controller;
	public static int chTab=0;							//0 for rabbit/ 1 for squirrel/ 2 for tortoise
	public static GameManager instance = null;          //Static instance of GameManager which allows it to be accessed by any other script.
	[HideInInspector] public static bool playersTurn = true;   //Boolean to check if it's players turn, hidden in inspector but public.
	
	private int chCount = 1;//chracter counter
	private GameObject chracter;
	private ChrachterManager chScripe;
	//贴图
	//private SpriteRenderer chSprite;
	private List <Image> chSwitch = new List<Image> ();//images for chracter swiching
	private Image GOImg;
	private Image replay;
	private Image black;
	private Image dSprite;
	private Animator animator;                  //Used to store a reference to the Player's animator component.
	private Vector2 chractorJump;

	
	//Awake is always called before any Start functions
	void Awake()
	{
		//Check if instance already exists
		instance = this;
		initGame ();
	}

	// Use this for initialization
	void Start () {

		initGame ();
	
	}

	void OnLevelWasLoaded(int level){

		//initGame ();
	}

	void initGame(){

		//if (/*!ChrachterManager.instance.settingUp*/) {

			chTab=0;	
			playersTurn = false;
			if (IsJiaoxueguan)
				chCount = 1;
			else
				chCount = 3;
			
			chracter = GameObject.Find ("ChracterManager");
			//贴图
			//chSprite = chracter.GetComponent<SpriteRenderer> ();
			chScripe = chracter.GetComponent<ChrachterManager> ();
			//
			//tab
			//
			animator = chracter.GetComponent<Animator>();
			chractorJump = new Vector2(0f,Screen.height*chScripe.JumpForce);
			
			chSwitch.Add ((GameObject.Find ("Image0")).GetComponent<Image> ());//for rabbit
			chSwitch.Add ((GameObject.Find ("Image1")).GetComponent<Image> ());//for squirrel
			chSwitch.Add ((GameObject.Find ("Image2")).GetComponent<Image> ());//for tortoise
			
			//
			//tab
			//
			for (int i=0; i<3; i++) {
				chSwitch [i].enabled =false;
			}
			for (int i=0; i<chCount; i++) {
				chSwitch [i].enabled = true;
			}
			
			GOImg = GameObject.Find ("GOImg").GetComponent<Image> ();
			GOImg.enabled = false;
			replay = GameObject.Find ("replay").GetComponent<Image> ();
			replay.enabled = false;
			black=GameObject.Find("black").GetComponent<Image>();
			black.enabled=false;
			dSprite=GameObject.Find("Dialoge").GetComponent<Image>();
			dSprite.enabled=false;

			playersTurn = true;
		//}
	}
	
	// Update is called once per frame
	void Update () {
		if (playersTurn) {
			//Debug.Log (GameManager.playersTurn);
			if (Input.GetButtonDown ("Tab"))
				switchChracter ();
		}
	
	}

	public void addNewChracter(){
	
		chSwitch [chCount].sprite = chSwitchImg [chCount * 2];
		chSwitch [chCount].enabled = true;
		chCount++;

		//Debug.Log (chCount);

		SoundManager.instance.PlaySingle (addTeam);
	
	}

	public void switchChracter(){

		chSwitch [chTab].GetComponent<Image>().sprite = chSwitchImg [chTab * 2];
		chTab = (chTab + 1) % chCount;

		//贴图
		//chSprite.sprite = chRenderer [chTab];

		chScripe.lSpeed=new Vector2(-0.18f/(chTab+2),0);
		chScripe.rSpeed=new Vector2(0.18f/(chTab+2),0);
		if(chTab==0)
			chScripe.jForce=chractorJump;
		else 
			chScripe.jForce=new Vector2(0,0);

		chSwitch [chTab].sprite = chSwitchImg [chTab * 2 + 1];

		//Debug.Log ("tab=" + chTab);
		//
		//tab
		//
		animator.runtimeAnimatorController = controller [chTab];

		SoundManager.instance.PlaySingle(switching);
	}

	public void GameOver(){
		playersTurn = false;
		Invoke ("gameover", 1);
	}
	void gameover(){

		GOImg.enabled = true;
		replay.enabled = true;

	}
}
