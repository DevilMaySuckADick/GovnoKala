using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;
    public bool Pause;
    public GameObject FollowCamera;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause = !Pause;
        }
        if (Pause)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }

    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        FollowCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }
    public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Pause = false;
        FollowCamera.SetActive(true);
    }


    public void LoadMenu()
    {
            Time.timeScale = 1;
            SceneManager.LoadScene("MainMenu");
    }
        
    
}
