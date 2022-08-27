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
            if (GameIsPause && OptionsMenuUI == true)
            {
                Pause();
                OptionsMenuUI.SetActive(false);
                Time.timeScale = 0f;
            }
        }
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }
    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }
    public void Options()
    {
        PauseMenuUI.SetActive(false);
        OptionsMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }   
}