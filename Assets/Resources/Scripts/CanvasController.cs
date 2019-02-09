using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
	private float refreshCooldown = 0.06f;
	private float _refreshTimer;
	
	void Start()
	{
		Quadcopter.SetupSocket();
		_refreshTimer = refreshCooldown;
		StartCoroutine(Quadcopter.PullReadings(refreshCooldown));
	}
}
