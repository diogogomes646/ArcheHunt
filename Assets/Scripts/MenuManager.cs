using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Canvas MainCanvas;
    public Canvas OptionsCanvas;
    public Canvas ShopCanvas;
    public Canvas SelectMenu;

    void Awake()
    {
        OptionsCanvas.enabled = false;
        ShopCanvas.enabled = false;

    }

    public void OptionsOn()
    {
        OptionsCanvas.enabled = true;
        MainCanvas.enabled = false;
    }

    public void ShopOn()
    {
        ShopCanvas.enabled = true;
        OptionsCanvas.enabled = false;
        MainCanvas.enabled = false;
    }

    public void ReturnOn()
    {
        OptionsCanvas.enabled = false;
        ShopCanvas.enabled = false;
        MainCanvas.enabled = true;
    }

    public void PlayOn()
    {

        SceneManager.LoadScene(1);


    }

    public void QuitOn()
    {
        Application.Quit();
    }
}
