using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformAttach : MonoBehaviour
{
    private GameObject Player;
    private Vector3 prevTransform;

    void Start() {
        prevTransform = transform.position;
    }

    void FixedUpdate() {
        Vector3 delta = transform.position - prevTransform;
        // Передвигаем прикрепленного игрока на изменение местоположения за момент времени
        if (Player) {
            Player.transform.position += delta;
        }
        prevTransform = transform.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Character") {
            // Запоминаем пользователя, который находится на платформе
            Player = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Character") {
            Player = null;
        }
    }

}
