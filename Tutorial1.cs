using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorial1 : MonoBehaviour {

	public Text MovementControllers; //when player is on the starting zone this line of text shows

	// Use this for initialization
	void Start () {
		this.MovementControllers.enabled = true;
	}

	void OnTriggerEnter(Collider other) 
	{
		Debug.Log ("player");
		
		if (other.gameObject.CompareTag ("Player"))
		{
			this.MovementControllers.enabled = false;
		}

	}
	// Update is called once per frame
	void Update () 
	{

	}

}
