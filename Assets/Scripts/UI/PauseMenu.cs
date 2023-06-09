using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour    
{
    

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject VolumeControls;

    public bool AudioOpen = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

        

        
    }

   public void CloseAudio()
    {
        VolumeControls.SetActive(false);
        pauseMenuUI.SetActive(true);
        AudioOpen = false;

    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause ()
    {
        if (AudioOpen == false)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
        }
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void ManageAudio()
    {
        pauseMenuUI.SetActive(false);
        VolumeControls.SetActive(true);
        AudioOpen = true;
        
    }
}
