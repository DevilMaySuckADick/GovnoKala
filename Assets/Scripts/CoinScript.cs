using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public AudioClip coinSound;
    // Start is called before the first frame update
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
    }
}
