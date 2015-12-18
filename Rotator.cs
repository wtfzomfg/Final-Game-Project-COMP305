using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	//this will rotat the pick up & the keys

	//taken from unity roll a ball tutioral
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);//update the pick ups to always be turning
	}
}