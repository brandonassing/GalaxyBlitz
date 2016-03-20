using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class MainStart : MonoBehaviour
{
    /// <summary>
    /// Used to control scene changes
    /// </summary>

    void Awake()
    {
        Utils.SetCameraBounds(this.GetComponent<Camera>());
        UnityEngine.Cursor.visible = true;

    }
    public void StartGame()
    {
        SceneManager.LoadScene("_Scene_0");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadStart()
    {
        SceneManager.LoadScene("Start Screen");
    }

    public void LoadInstructions()
    {
        SceneManager.LoadScene("Help");
    }

    public void LoadGameMenu()
    {
        SceneManager.LoadScene("Game Menu");
    }
    public void LoadGameLevels()
    {
        SceneManager.LoadScene("Game Levels");
    }
    public void LoadConfigurations()
    {
        SceneManager.LoadScene("Configurations");
    }
    public void LoadEnemies()
    {
        SceneManager.LoadScene("Enemies");
    }
    public void LoadAudio()
    {
        SceneManager.LoadScene("Audio");
    }
    public void LoadBackground()
    {
        SceneManager.LoadScene("Background");
    }
    public void LoadBronze()
    {
        SceneManager.LoadScene("Game Levels Bronze");
    }
    public void LoadSilver()
    {
        SceneManager.LoadScene("Game Levels Silver");
    }
    public void LoadGold()
    {
        SceneManager.LoadScene("Game Levels Gold");
    }
}
