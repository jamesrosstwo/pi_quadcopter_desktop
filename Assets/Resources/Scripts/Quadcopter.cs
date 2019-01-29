using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public static class Quadcopter
{
    public static QuadcopterData Data = new QuadcopterData();

    // ADD ERROR CHECKS
    public static string baseURL = "http://192.168.0.115:8080";

    public static IEnumerator PullReadings()
    {
        WWW www = new WWW(baseURL);

        while (!www.isDone)
        {
        }
        Data = JsonUtility.FromJson<QuadcopterData>(www.text);
        yield return www;
    }
}

public class QuadcopterData
{
    public string status;
    public float altitude;
    public float xAngle;
    public float yAngle;
    public float distance;
    public float batteryPercentage;
}