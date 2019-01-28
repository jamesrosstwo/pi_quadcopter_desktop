using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

namespace Resources.Scripts
{
    public class Quadcopter
    {
        public static string Readings = "";
        
        public static string baseURL = "http://192.168.0.115:8080";

        public static void PullReadings()
        {
            WWW www = new WWW(baseURL);
            while (!www.isDone){}
            Readings = www.text;
        }

      
        
        //            users = JsonHelper.getJsonArray<User>(www.text);
//            Debug.Log("Users: " + www.text);
    }
}