using UnityEngine;
using System.Collections;

public class Scoring : MonoBehaviour {

	//this code is to add the player score without reseting when going to next level
	//the score will however reset to zero but won't change the game Variables

	void OnTriggerEnter(Collider collider){ 
		if (collider.gameObject.name == "Player") {
			GameVariables.FinalScore += 1;
			Debug.Log("adding");
		}
	}
}
