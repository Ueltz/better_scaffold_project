using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                StartCoroutine(Resume());
            }
            else
            {
                Pause();
            }
        }
    }

    public IEnumerator Resume()
    {
        pauseMenuUI.SetActive(false);
        yield return new WaitForSecondsRealtime(3);
        Time.timeScale = 1f;
        GameIsPaused = false;
        AudioListener.pause = false;

    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        AudioListener.pause = true;
        Debug.Log(Time.timeScale.ToString());
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit game.");
        Application.Quit();
    }

    public void ResumeButton()
    {
        StartCoroutine(Resume());
    }
}
