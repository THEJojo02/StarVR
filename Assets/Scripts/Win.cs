﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour {
    float time;

    public void Gesamtszene()
    {

        Screen.orientation = ScreenOrientation.LandscapeLeft;
        SceneManager.LoadScene("Gesamtszene", LoadSceneMode.Single);
    }


     void Update()
    {
        time = Time.deltaTime + time;
        if (time > 20)
        {
			Gesamtszene();
        }
    }

}
