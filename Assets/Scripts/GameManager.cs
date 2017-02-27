using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas GameplayCanvas;
    public GameObject PauseButton;
    public GameObject PausePanel;



    public void Start()
    {
        Resume();
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        PauseButton.SetActive(false);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        PauseButton.SetActive(true);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }


    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void QuitOn()
    {
        Application.Quit();
    }
}
