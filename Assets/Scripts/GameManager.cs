using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas GameplayCanvas;
    public GameObject PlayerCanvas;
    public GameObject Player;
    public GameObject PauseButton;
    public GameObject PausePanel;
    public GameObject LevelSelect;
    public GameObject Background;
    public GameObject Enemy;
    public Sprite level1;
    public Sprite level2;
    public Sprite level3;


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

    public void Level1()
    {
        Background.GetComponent<SpriteRenderer>().sprite = level1;
        Player.SetActive(true);
        PlayerCanvas.SetActive(true);
        LevelSelect.SetActive(false);
        for (int i = 3; i > 0; i--)
        {
            Instantiate(Enemy, new Vector3(10.0f, -3.0f, 0.0f), transform.rotation);
            StartCoroutine(Wait(10));
        }
    }

    public void Level2()
    {
        Background.GetComponent<SpriteRenderer>().sprite = level2;
        Player.SetActive(true);
        PlayerCanvas.SetActive(true);
        LevelSelect.SetActive(false);
    }

    public void Level3()
    {
        Background.GetComponent<SpriteRenderer>().sprite = level3;
        Player.SetActive(true);
        PlayerCanvas.SetActive(true);
        LevelSelect.SetActive(false);
    }

    IEnumerator Wait(int seconds)
    {
        print(Time.time);
        yield return new WaitForSeconds(seconds);
        print(Time.time);
    }

}

