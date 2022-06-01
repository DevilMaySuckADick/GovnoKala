using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public MenuOpenerScript RespawnMenuOpener;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Killing") {
            RespawnMenuOpener.OpenMenu();
        }
    }

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Killing") {
            RespawnMenuOpener.OpenMenu();
        }
    }
}
