using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AltitudeController : MonoBehaviour
{
	private TextMeshProUGUI _text;
	// Use this for initialization
	void Start () {
		_text = gameObject.GetComponent<TextMeshProUGUI>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_text.text = "Altitude: " + Quadcopter.Data.altitude + "cm";
	}
}
