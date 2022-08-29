using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject PauseMenuUI;
    public GameObject OptionsMenuUI;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }   
        
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        GameIsPause = false;
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        GameIsPause = true;
        Time.timeScale = 0f;
    }
    public void Options()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(true);
        GameIsPause = true;
        Time.timeScale = 0f;
    }
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
        GameIsPause = false;
        Time.timeScale = 1f;
    }
    public void BackButton()
    {
        PauseMenuUI.SetActive(true);
        OptionsMenuUI.SetActive(false);
        GameIsPause = true; 
        Time.timeScale = 0f;
    }
}