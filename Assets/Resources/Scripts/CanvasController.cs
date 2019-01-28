using System.Collections;
using System.Collections.Generic;
using Resources.Scripts;
using UnityEngine;

public class CanvasController : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		StartCoroutine(Quadcopter.PullReadings());
		Debug.Log(Input.GetAxis("Vertical"));
	}
}
