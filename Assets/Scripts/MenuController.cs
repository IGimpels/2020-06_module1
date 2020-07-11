using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        None,
        Main,
        Settings,
        Level,
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    public CanvasGroup levelScreen;

    void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
        Utility.SetCanvasGroupEnabled(levelScreen, screen == Screen.Level);
    }

    void Awake()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void StartNewGame()
    {
        SetCurrentScreen(Screen.None);
        SetCurrentScreen(Screen.Level);
    }

    public void StartLevel1()
    {
        LoadingScreen.instance.LoadScene("SampleScene");
    }
    public void StartLevel2()
    {
        LoadingScreen.instance.LoadScene("SampleScene 1");
    }
     
    public void LevelBack()
    {
        SetCurrentScreen(Screen.Main);
    }


    public void OpenSettings()
    {
        SetCurrentScreen(Screen.Settings);
    }

    public void CloseSettings()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
