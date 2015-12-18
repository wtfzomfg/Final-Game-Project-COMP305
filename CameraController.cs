using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	//Jefferson chin
	//300787653
	//This Script is to follow the player on the main camra


	public GameObject player;//you need to tag the player gamobject
	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - player.transform.position; // at the start of the game camre will be set on to the player
	}
	
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset; // this will update the camrea to follow onto the player
	}
}