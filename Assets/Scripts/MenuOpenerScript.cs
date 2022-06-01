using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpenerScript : MonoBehaviour
{
    public GameObject Menu;
    public GameObject FollowCamera;
    public bool IsPause = false;
    private bool IsOpened = false;

    public void OpenMenu() {
        Menu.SetActive(true);
        Cursor.visible = true;
        if (IsPause)
            Time.timeScale = 0f;
        FollowCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        IsOpened = true;
    }

    public void CloseMenu() {
        Menu.SetActive(false);
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FollowCamera.SetActive(true);
        IsOpened = false;
    }

    public void ToggleMenu() {
        if (IsOpened)
            CloseMenu();
        else 
            OpenMenu();
    }
}
