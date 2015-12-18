using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	/// PUBLIC INSTANCE VARIABLES
	public float speed;//set the speed as a p

	public Text keyholder;//displays number of keys the player has
	public Text countText;//display the count of pickup gotten 
	public Text healthLabel; //displays health
	public int keyNum;//
	public int count;//Score
	public int healthNumber;
	//PRIVATE INSTANCE VARIABLES
	private Rigidbody rb;

	private bool endgame;
	
	//private HighScoreScript _highScoreScript;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		count = 0;// sets the play score to zero
		setCountText ();

		healthNumber = 90;
		setHealthText ();

		this.endgame = false;//So the game doens't start with the endgam display
		//this._highScoreScript = GameObject.FindWithTag ("HighScoreController").GetComponent("HighScoreController") as HighScoreScript;
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKeyDown(KeyCode.R) && endgame) //only when the player hits the death tigger they may resest it
		{
			Application.LoadLevel(Application.loadedLevel); //reloads the level 
			
		}
		if (GameVariables.Health <= 0)
		{
			Application.LoadLevel("Endgame");
		}
		setKeyHold ();
		//Debug.Log (GameVariables.Health);
		setHealthText (); // always updates the Variable to be able to display the most up to date number
	 
	}

	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal"); // player movement for Horizontal
		float moveVertical = Input.GetAxis ("Vertical");// player movement for Vertical
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
	
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			setCountText (); 
		}

	}
	void setHealthText()
	{
		healthLabel.text = "Health: " +  GameVariables.Health.ToString(); //displays the Health Number into a stingon the UI
	}
	void setCountText ()
	{
		countText.text = "Count: " + count.ToString ();// displays the count Number into a stingon the UI
	}
	void setKeyHold ()
	{
		keyholder.text = "Keys: " + GameVariables.KeyCount.ToString ();// displays the count Number into a stingon the UI
	}
}