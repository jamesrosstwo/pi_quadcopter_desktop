using System.Collections;
using System.Collections.Generic;
using Resources.Scripts;
using UnityEngine;

public class Canvas : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		Quadcopter.PullReadings();
		Debug.Log(Quadcopter.Readings);
	}
}
