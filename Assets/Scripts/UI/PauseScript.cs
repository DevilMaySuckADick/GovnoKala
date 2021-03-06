using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public MenuChanger MenuChanger;

    // Включает и выключает меню нажатием клавиши ESC
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            MenuChanger.ChangeActiveMenu(MenuState.Pause);
        }
    }
}
