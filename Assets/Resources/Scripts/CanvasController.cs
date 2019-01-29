using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
	private float refreshCooldown = 0.1f;
	private float refreshTimer;
	
	void Start()
	{
		refreshTimer = refreshCooldown;
		StartCoroutine(Quadcopter.PullReadings());
	}
	// Update is called once per frame
	void Update ()
	{
		refreshTimer -= Time.deltaTime;
		if (refreshTimer <= 0)
		{
			StartCoroutine(Quadcopter.PullReadings());
			refreshTimer = refreshCooldown;
		}
	}
}
