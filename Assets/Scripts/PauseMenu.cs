﻿using UnityEngine;
using System.Collections;
using System.Xml.Schema;

public class PauseMenu : MonoBehaviour
{


    public string mainMenu;
    public bool isPaused;
    public GameObject pauseMenuCanvas;
    


    // Update is called once per frame
    void Update()
    {
        if (isPaused)
        {
            pauseMenuCanvas.SetActive(true);
            Time.timeScale = 0f;    
        }
        else
        {
            pauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Quit()
    {
        Application.LoadLevel(mainMenu);
        
    }

    public void OpenPauseMenu()
    {
        pauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
}
