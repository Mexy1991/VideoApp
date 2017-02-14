﻿using UnityEngine;
 using System.Collections;
 
 public class PlayVideo1 : MonoBehaviour {
     private string movPath = "small.ogv";
 
     // Use this for initialization
     void Start () {
         StartCoroutine(PlayStreamingVideo(movPath));
     }
 
     private IEnumerator PlayStreamingVideo(string url)
     {
         Handheld.PlayFullScreenMovie(url, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
         yield return new WaitForEndOfFrame();
         //yield return new WaitForEndOfFrame();
         Debug.Log("Video playback completed.");
		//yield return new WaitForEndOfFrame();
        Application.LoadLevel("Main"); 
     }
 }


