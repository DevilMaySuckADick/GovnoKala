using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject respawnPoint;
    public GameObject player;

     private void OnCollisionEnter(Collision other) {
         
         if (other.gameObject.tag == "Player")
        {
            Debug.Log("hueta");
            player.transform.position = respawnPoint.transform.position;
        }  
     }
     private void OnCollisionStay(Collision other) {
         if (other.gameObject.tag == "Player")
        {
            Debug.Log("hueta");
            player.transform.position = respawnPoint.transform.position;
        }  
     }
}
