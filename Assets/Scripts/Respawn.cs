using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public MenuChanger MenuChanger;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Killing") {
            MenuChanger.ChangeActiveMenu(MenuState.Restart);
        }
    }
}
