using UnityEngine;
using System.Collections;

public class BacktoMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnStartButtonClick() {
		GameVariables.Health = 100;
		GameVariables.FinalScore = 0;
		GameVariables.KeyCount = 0;
		Application.LoadLevel ("Menu");

	}
}
