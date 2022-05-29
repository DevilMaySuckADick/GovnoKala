using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
}
