using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;

public class ScoreScript : MonoBehaviour
{
    public int points = 0;
    public AudioClip coinSound;
    public MenuChanger MenuChanger;
    public ThirdPersonController CharacterController;
    public Animator CharacterAnimator;

    private bool IsGameOver = false;
    private int counter = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "coin") {
            points++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 2f);
            Destroy(other.gameObject);
        } else if (other.tag == "babki") {
            points++;
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 3f);
            Destroy(other.gameObject);
            MenuChanger.ChangeActiveMenu(MenuState.GameOver);
            IsGameOver = true;
            CharacterController.enabled = false;
        }
    }

    // Jump animation
    void FixedUpdate() {
        if (IsGameOver) {
            if (counter == 20) {
                CharacterAnimator.SetBool("Jump", true);
                counter = 0;
            } else {
                CharacterAnimator.SetBool("Jump", false);
                counter++;
            }
        }
    }
}
