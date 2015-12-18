using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	//this script is used to add a Key variable when the play makes contact

	void OnTriggerEnter(Collider collider){ 
		if (collider.gameObject.name == "Player")
		{
			Debug.Log("key added");
			GameVariables.KeyCount += 1;
			GameVariables.keyDisplay=2;
			Destroy (gameObject);
		}
	}
}
