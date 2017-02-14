//Thanks to N3K EN (https://youtu.be/TYzdhiRiKd0)

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour {
public void ChangeScene(string sceneName)
    {
        //   Application.LoadLevel(sceneName);
        Application.LoadLevel("video_" + Random.Range(1, 3));

    }
    public void ChangeScene2(string sceneName)
    {
        //   Application.LoadLevel(sceneName);
        Application.LoadLevel("video_" + Random.Range(4, 6));

    }

	public void BackToMain(string sceneName)
    {
        //   Application.LoadLevel(sceneName);
        Application.LoadLevel("Main");

    }
}

