using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool GamePaused = false;

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }

    public void Resume()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1.0f;
        GamePaused = false;
    }

    void Pause()
    {

        pauseMenuUI.SetActive(true);
        Time.timeScale = 0.0f;
        GamePaused = true;
    }

    public void LoadMenu()
    {

        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Menu Page");
    }

    public void QuitGame()
    {

        Debug.Log("Quitting Game . . . ");
    }

}