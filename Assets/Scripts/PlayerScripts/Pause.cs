using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject panel;
    public static bool pause;
    private bool paused = false;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!paused)
            {
                Time.timeScale = 0;
                paused = true;
                panel.SetActive(true);
                AudioListener.pause = true;
                
            }
            else
            {
                Time.timeScale = 1;
                paused = false;
                panel.SetActive(true);
                AudioListener.pause = false;
            }
        }
    }
}
