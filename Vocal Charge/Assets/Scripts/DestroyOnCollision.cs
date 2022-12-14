using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private Transform respawn_point;
    void OnTriggerEnter(Collider collision)
    {
  
        if (collision.gameObject.CompareTag("Player")) {
    
            Destroy(collision.gameObject);
            Instantiate(player, respawn_point.position, Quaternion.identity);
            Destroy(this.gameObject);
        }

    }

}
