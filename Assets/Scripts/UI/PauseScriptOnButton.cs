using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScriptOnButton : MonoBehaviour
{
    public MenuChanger MenuChanger;

    public void Toggle() {
        MenuChanger.ChangeActiveMenu(MenuState.Pause);
    }
}
