using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public MenuOpenerScript MenuOpener;

    // Включает и выключает меню нажатием клавиши ESC
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            MenuOpener.ToggleMenu();
        }
    }
}
