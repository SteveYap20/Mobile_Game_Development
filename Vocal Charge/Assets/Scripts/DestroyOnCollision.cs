using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
  
        if (collision.gameObject.CompareTag("Player")) {
    
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }

    }

}
