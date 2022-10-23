using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

    public GameObject prefab;

    public float max;
    void Start() {

        for (var i = 0; i < max; i++) {
            Vector3 position = new Vector3(Random.Range(-1, 8) * 4, 0, Random.Range(-1, -30) * 4);
            Instantiate(prefab, position, Quaternion.identity);

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
