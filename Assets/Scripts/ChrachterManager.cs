using UnityEngine;
using System.Collections;

public class ChrachterManager : MonoBehaviour {

	public float JumpForce = 2f ;			//TanTiao XiShu
	public float JumpHorizontalForce = 0.8f ;
	public static ChrachterManager instance = null;
	public AnimationClip rWalk;
	[HideInInspector]public Vector2 lSpeed;//declare force for moving left
	[HideInInspector]public Vector2 rSpeed;//declare force for moving right
	[HideInInspector]public Vector2 jForce;//declare force for jumping
	[HideInInspector] public bool settingUp = true;




	public static bool Standing=true;
	private Rigidbody2D rb2d; 
	//private float xForce;
	//private float yForce;
	private Animator animator;                  //Used to store a reference to the Player's animator component.
	private float scaleX;
	private int jumpCount;
	private Vector3 chScale;
	private float jhForce;
	private float istortoise;

	void Awake()
	{
		instance = this;
	}

	void Start(){
		rb2d = GetComponent<Rigidbody2D> ();

		lSpeed = new Vector2 (-0.09f, 0);
		rSpeed = new Vector2 (0.09f, 0);
		jForce = new Vector2 (0, Screen.height*JumpForce);
		jhForce = Screen.height * JumpHorizontalForce;

		settingUp = false;
		animator = GetComponent<Animator>();
		scaleX = transform.localScale.x;

	}


	void FixedUpdate(){

		/*if (!GameManager.playersTurn) 
			return;

		if (Input.GetButtonDown ("Jump") && canJump() ) {		
			rb2d.AddForce (jForce);
			animator.SetTrigger ("Walk");

			chScale = transform.localScale;
			if(chScale.x==scaleX)
				rb2d.AddForce(new Vector2(jhForce,0f));
			else
				rb2d.AddForce(new Vector2(-jhForce,0f));
		}*/
		
		if (Input.GetButton ("Left")) {
			chScale = transform.localScale;
			if (chScale.x != -scaleX) {
				chScale.x = -scaleX;
				transform.localScale = chScale;
			}
			transform.Translate (lSpeed);
			if (!animator.GetCurrentAnimatorStateInfo (0).IsName ("rJump"))
				animator.SetTrigger ("Walk");
			
			//Debug.Log("done");
		} else if (Input.GetButton ("Right")) {
			chScale = transform.localScale;
			if (chScale.x != scaleX) {
				chScale.x = scaleX;
				transform.localScale = chScale;
			}
			
			transform.Translate (rSpeed);
			if (!animator.GetCurrentAnimatorStateInfo (0).IsName ("rJump"))
				animator.SetTrigger ("Walk");
		} else if (Input.GetButton ("Up"))
			settingUp = settingUp;
		else if (Input.GetButton ("Down"))
			settingUp = settingUp;

		else if (Input.GetKeyDown (KeyCode.Space)) {

			

			if (GameManager.chTab == 2 && !animator.GetCurrentAnimatorStateInfo (0).IsName ("tStay")) {

				animator.SetTrigger ("Suoke");
			}
			if (animator.GetCurrentAnimatorStateInfo (0).IsName ("tStay")) {
				//Debug.Log ("1111");
				animator.SetTrigger ("back");
			}

		} else
			if (GameManager.chTab == 1 && Standing)
			animator.SetTrigger ("Stand");
	  
	}

	void Update(){



	if (!GameManager.playersTurn) 
			return;
		
		if (Input.GetButtonDown ("Jump") && canJump() ) {		
			rb2d.AddForce (jForce);
			animator.SetTrigger ("Walk");
			
			chScale = transform.localScale;
			if(jForce.y!=0){
				if(chScale.x==scaleX)
					rb2d.AddForce(new Vector2(jhForce,0f));
				else
					rb2d.AddForce(new Vector2(-jhForce,0f));
			}
		}

	}

	bool canJump(){

		//Debug.Log("count="+jumpCount);

		if (rb2d.velocity.y == 0) {

			jumpCount = 0;
			return true;
		} 
		else {

			if(jumpCount==0){

				jumpCount++;
				return true;
			}
			else
				return false;
		}
	}
	// Update is called once per frame
	/*void Update () {

		if (!GameManager.playersTurn) 
			return;

		if (rb2d.velocity.x >= 3 || rb2d.velocity.x <= -3 || rb2d.velocity.y >= 3 || rb2d.velocity.y <= -3)
			return;
	
		if (Input.GetButtonDown ("Jump") && rb2d.velocity.y == 0) {		
			rb2d.AddForce (jForce);
			animator.SetTrigger ("Walk");
		}

		if (Input.GetButton ("Left")) {
			Vector3 chScale = transform.localScale;

			if (chScale.x != 1) {
				chScale.x = 1f;
				transform.localScale = chScale;
			}
		
			rb2d.AddForce (lForce);
			animator.SetTrigger ("Walk");

			//Debug.Log("done");
		}

		if (Input.GetButton ("Right")) {
			Vector3 chScale = transform.localScale;
			if (chScale.x != -1) {
				chScale.x = -1f;
				transform.localScale = chScale;
			}

			rb2d.AddForce (rForce);
			animator.SetTrigger ("Walk");
		}
	}*/
}
