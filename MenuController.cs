using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

	private AudioSource[] _audioSources;
	private AudioSource _themeMusicAudioSource;

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}
	// Use this for initialization
	void Start () {
		this._audioSources = this.GetComponents<AudioSource> ();
		this._themeMusicAudioSource = this._audioSources [0];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStartButtonClick() {
		Application.LoadLevel ("Tutorial");
	}
}
