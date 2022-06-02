using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MenuState
{
    Restart = 1,
    GameOver = 2,
    Pause = 3,
    Default = 4
}

public class MenuChanger : MonoBehaviour
{
    [SerializeField] private GameObject FollowCamera;
    [SerializeField] private GameObject DefaultMenu;
    [SerializeField] private GameObject GameOverMenu;
    [SerializeField] private GameObject RestartMenu;
    [SerializeField] private GameObject PauseMenu;
    [SerializeField] private MenuState state = MenuState.Default;

    public void ChangeActiveMenu(MenuState newState)
    {
        if (newState == state)
        {
            // Если повторно присылается то же меню, то оно выключается
            if (state != MenuState.Default)
            {
                GetMenuByState(state).SetActive(false);
                // Меняем состояние на состояние по умолчанию
                state = MenuState.Default;
                GetMenuByState(state).SetActive(true);
                // Блокируем курсор, ибо "входим" в игру
                LockCursor();
            }
        }
        else
        {
            // Предотвращаем включение паузы во время рестарта и конца игры
            if ((state == MenuState.GameOver || state == MenuState.Restart)
                && newState == MenuState.Pause)
            {
                return;
            }

            // Выключаем прошлое меню
            GetMenuByState(state).SetActive(false);
            // И включаем новое 
            GetMenuByState(newState).SetActive(true);
            // Меняем состояние
            state = newState;

            // Меняем состояние курсора
            if (state != MenuState.Default) 
                FreeCursor();
            else
                LockCursor();
        }
    }

    private void FreeCursor() {
        Cursor.visible = true;
        if (IsPause(state))
            Time.timeScale = 0f;
        FollowCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    private void LockCursor() {
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FollowCamera.SetActive(true);
    }

    private bool IsPause(MenuState state) {
        return state == MenuState.Pause || state == MenuState.Restart;
    }

    private GameObject GetMenuByState(MenuState state)
    {
        switch (state)
        {
            case MenuState.Default: return DefaultMenu;
            case MenuState.Restart: return RestartMenu;
            case MenuState.GameOver: return GameOverMenu;
            case MenuState.Pause: return PauseMenu;
        }

        // TODO or throw error
        return null;
    }
}
