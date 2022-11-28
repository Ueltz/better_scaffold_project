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

    public static void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public static void EnterInstructions()
    {
        SceneManager.LoadScene("Instructions");
    }

    public static void EndCredits()
    {
        SceneManager.LoadScene("EndCredits");
    }
}
