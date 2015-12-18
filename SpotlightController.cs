using UnityEngine;
using System.Collections;

public class SpotlightController : MonoBehaviour {
	//this is used to change the flashlight direction

	//bug - using this will also move the player
	private float yRotation = 0.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if		(Input.GetKeyDown (KeyCode.UpArrow)) //if player use the uparrow key the light will point forward
		{
			yRotation += Input.GetAxis("Vertical");
			transform.eulerAngles = new Vector3(0.0f, 0.0f, 0f);
		}
		if		(Input.GetKeyDown (KeyCode.DownArrow)) //if player use the uparrow key the light will point backward
		{
			yRotation += Input.GetAxis("Vertical");
			transform.eulerAngles = new Vector3(0.0f, -180.0f, 0f);
		}
		if		(Input.GetKeyDown (KeyCode.RightArrow))  //if player use the right key the light will point toward the right
		{
			yRotation += Input.GetAxis("Vertical");
			transform.eulerAngles = new Vector3(0.0f, 90.0f, 310f);
		}
		if		(Input.GetKeyDown (KeyCode.LeftArrow)) //if player use the left key the light will point toward the left
		{
			yRotation += Input.GetAxis("Vertical");
			transform.eulerAngles = new Vector3(0.0f, 270f, 310f);
		}
	}
}
