using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Map1");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public void Pause()
    {
        SceneManager.LoadScene("PauseScreen");
    }
}
