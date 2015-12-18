using UnityEngine;
using System.Collections;

public class KeyGate : MonoBehaviour {
	//this Script is use when the player has a key he will be able to unlock one but any gate
	private AudioSource[] _audioSources;
	private AudioSource _GateAudioSource;

	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._GateAudioSource = this._audioSources [0];
	}

	void OnTriggerEnter(Collider collider){ 
		if (collider.gameObject.name == "Player" && GameVariables.KeyCount > 0) {
			GameVariables.KeyCount--;// removes a key from the count
			Debug.Log("key remove");
			this._GateAudioSource.Play (); // plays audio of the gate
			gameObject.GetComponent<Collider>().enabled = false; //disable the Collider
			foreach (Transform child in transform) {
				child.position += Vector3.up * 4.0F; //moves the tranform of all the child when the gate opens
			}
			
		}
	}
}
