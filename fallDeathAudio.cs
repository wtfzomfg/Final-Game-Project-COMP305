using UnityEngine;
using System.Collections;

public class fallDeathAudio : MonoBehaviour {
	// PRIVATE INSTANCE VARIABLES
	private AudioSource[] _audioSources;
	private AudioSource _fallAudioSource;

	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._fallAudioSource = this._audioSources [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherGameObject) {
		if (otherGameObject.tag == "Player") 
		{
			this._fallAudioSource.Play ();
			Application.LoadLevel("Endgame");
		}
	}
}
