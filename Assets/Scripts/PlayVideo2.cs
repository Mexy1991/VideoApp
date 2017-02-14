using UnityEngine;
 using System.Collections;
 
 public class PlayVideo2 : MonoBehaviour {
	private string movPath = "SampleVideo.mp4";
 
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



