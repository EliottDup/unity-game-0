using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenu : MonoBehaviour
{
    public static bool IsPaused = false;
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
          if (IsPaused)
          {
            Resume();
          } else
          {
            Pause();
          }
        }
    }

    void Start()
    {
    }

    public void Resume()
    {
      Cursor.lockState = CursorLockMode.Locked;
      PauseMenuUI.SetActive(false);
      Time.timeScale = 1f;
      IsPaused = false;
    }

    void Pause()
    {
      Cursor.lockState = CursorLockMode.None;
      PauseMenuUI.SetActive(true);
      Time.timeScale = 0f;
      IsPaused = true;
    }

    public void LoadMenu ()
    {
      IsPaused = false;
      Time.timeScale = 1f;
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Quitgame ()
    {
      Application.Quit();
    }
}
