using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour {
	//PUBLIC INSTANCE VARIABLES
	//public int FinalScore;
	public Text finalScore;
	public int EndScore;
	//void Awake() {
		//DontDestroyOnLoad (this);
	//}


	// Use this for initialization
	void Start () {

		setLastScore ();//display the Score of the total amount of pick ups they have gotten
	}
	
	// Update is called once per frame
	void Update () {

	}
	void setLastScore ()
	{
		finalScore.text = "TOTAL SCORE : " + GameVariables.FinalScore.ToString ();
	}
}
