using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStateManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Testing");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public static void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    public static void EnterInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }
}
