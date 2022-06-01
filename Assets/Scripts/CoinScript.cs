using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    // Анимация вращения монет
    void FixedUpdate()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}
