using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("gae");
        if (collision.collider.CompareTag("Player")) {
            Debug.Log("yeetusthefetus");
            Destroy(collision.gameObject);
        }

    }
    //    private void OnTriggerEnter(Collider other)
    //{

    //        if (other.CompareTag("Player")) {

    //            Destroy(other.gameObject);
    //        }
    //}

}
