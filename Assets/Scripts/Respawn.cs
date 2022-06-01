using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public GameObject RespawnMenu;
    public GameObject FollowCamera;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Killing")
        {
            ShowRespawnMenu();
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Killing")
        {
            ShowRespawnMenu();
        }
    }

    public void ShowRespawnMenu() {
        PauseGame();
        RespawnMenu.SetActive(true);
    }

    public void PauseGame() {
        Time.timeScale = 0f;
        Cursor.visible = true;
        FollowCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    public void RestartScene() {
        
        SceneManager.LoadScene( SceneManager.GetActiveScene().buildIndex );
        RespawnMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FollowCamera.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
