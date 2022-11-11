using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillFloor : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Transform respawn_point;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
            Instantiate(player, respawn_point.position, Quaternion.identity);
        }
        
        //player.transform.position = respawn_point.transform.position;
    }
}
