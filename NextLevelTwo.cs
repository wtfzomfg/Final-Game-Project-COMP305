using UnityEngine;
using System.Collections;

public class NextLevelTwo : MonoBehaviour {
	private AudioSource[] _audioSources;
	private AudioSource _NextLevelAudioSource;

	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._NextLevelAudioSource = this._audioSources [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider otherGameObject) {
		if (otherGameObject.tag == "Player") {
			this._NextLevelAudioSource.Play ();
			Application.LoadLevel ("levelTwo");
		}
	}
}
