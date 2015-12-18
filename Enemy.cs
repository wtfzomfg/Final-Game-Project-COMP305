using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	/// PUBLIC INSTANCE VARIABLES
	public Transform target;
	public float speed;
	
	
	//PRIVATE INSTANCE VARIABLES
	private Transform _transform;
	private float _distanceFromTarget;
	private AudioSource[] _audioSources;
	private AudioSource _AttackAudioSource;
	
	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
		this._audioSources = this.GetComponents<AudioSource> ();
		this._AttackAudioSource = this._audioSources [0];
	}
	
	// Update is called once per frame
	void Update () {
		this._distanceFromTarget = Vector3.Distance(this._transform.position, this.target.position);
		if (this._distanceFromTarget < 10) {
			// move towards the target
			this._transform.position = Vector3.MoveTowards(this._transform.position, target.position, this.speed);
			
			// look at the target
			Vector3 targetDir = this.target.position - this._transform.position;
			Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, this.speed, 0.0F);
			this._transform.rotation = Quaternion.LookRotation(newDir);
		}

	}
	void OnTriggerEnter(Collider otherGameObject) {
		if (otherGameObject.tag == "Player" && !_AttackAudioSource.isPlaying) 
			//if the player is attacked by the wolf they cant be attacked 
			//ontill the attackaudio is finished meaning that player cant 
			//be attack again even by different wolves
		{
			this._AttackAudioSource.Play ();
			GameVariables.Health -= 20;
			Debug.Log("Damging player");
		}
	}
}