using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour
{
    public AudioClip coinSound;
    public GameObject winMenu;
    public GameObject FollowCamera;

    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }

   private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Character")
        {
            other.GetComponent<ScoreScript>().points++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 2f);
            Destroy(gameObject);
        }
        if (gameObject.tag == "babki")
        {
            winningMenu();
            other.GetComponent<ScoreScript>().points++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 3f);
            Destroy(gameObject);
        }

    }
    public void winningMenu()
    {
        winMenu.SetActive(true);
        Time.timeScale = 1;
        Cursor.visible = true;
        FollowCamera.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        winMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        FollowCamera.SetActive(true);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
