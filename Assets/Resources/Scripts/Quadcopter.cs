using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Resources.Scripts
{
    public class Quadcopter
    {
        public static string Readings = "";
        
        public static string baseURL = "http://10.50.123.102:8080";

        public static IEnumerator PullReadings()
        {
            WWW www = new WWW(baseURL);
            while (!www.isDone){}
            Readings = www.text;
            yield return www;
        }

      
        
        //            users = JsonHelper.getJsonArray<User>(www.text);
//            Debug.Log("Users: " + www.text);
    }
}