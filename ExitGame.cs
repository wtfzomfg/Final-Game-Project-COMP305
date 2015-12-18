using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	//this.finalScoreLabel.text = "Score: " + GameVariables.FinalScore.ToString ();//this will display the gameVariable finalscore instend of keycount

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void OnStartButtonClick() {
		Application.Quit ();
	}
}