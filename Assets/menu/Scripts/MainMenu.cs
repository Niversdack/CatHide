using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void BackSettings()
    {
        GameObject.Find("SettingsMenu").SetActive(true);
        GameObject.Find("MainMenu").SetActive(false);
    }
    public void OpenSettings()
    {
        GameObject.Find("SettingsMenu").SetActive(false);
        GameObject.Find("MainMenu").SetActive(true);
    }
}
