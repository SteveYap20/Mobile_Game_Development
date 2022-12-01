using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExplosion : MonoBehaviour {

    public float cubeSize = 0.2f;
    public int cubesInRow = 5;

    float cubesPivotDistance;
    Vector3 cubesPivot;

    void Start() {

        cubesPivotDistance = cubeSize * cubesInRow / 2;
        cubesPivot = new Vector3(cubesPivotDistance, cubesPivotDistance, cubesPivotDistance);
    }

    void Update() {
       
        
    }

    private void onTriggerEnter(Collider other) {

        if (other.gameObject.name == "Floor") {
            explode();
        }

    }

    public void explode() {

        gameObject.SetActive(false);

        for (int x = 0, x < cubesInRow; x++) {
            for (int y = 0; y < cubesInRow; y++) {
                for (int z = 0; z < cubesInRow; z++) {
                    createPiece(x, y, z);
                }
            }
        }

        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, explosionRadius);

        foreach (Collider hit in colliders) {

            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null) {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius, explosionUpward);
            }
        }
    }

    void createPiece(int x, int y, int z) {

        GameObject piece;
        piece = GameObject.CreatePrimitive(PrimitiveType.Cube);

        piece.transform.position = transform.position + new Vector3 (cubeSize * x, cubeSize * y, cubeSize * z) - cubesPivot;
        piece.transform.localScale = new Vector3 (cubeSize, cubeSize, cubeSize);

        piece(AddComponenet<Rigidbody>();
        piece.GetComponent<Rigidbody>().mass = cubeSize;    
    }
}
