using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleFromMicrophone : MonoBehaviour
{
    public AudioSource source;
    public Vector3 minScale;
    public Vector3 maxScale;
    public AudioDetection detector;

    private AudioDetection detector2;

    public float loudnessSensibility = 100;
    public float threshold = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        detector2 = this.gameObject.GetComponent<AudioDetection>();
    }

    // Update is called once per frame
    void Update()
    {
        //float loudness = detector.GetLoudnessFromMicrophone() * loudnessSensibility;
        float loudness = detector2.GetLoudnessFromMicrophone() * loudnessSensibility;

        if (loudness < threshold)
            loudness = 0;

        transform.localScale = Vector3.Lerp(minScale, maxScale, loudness);

        vertical = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(0, 0, vertical);
        Vector3 position = transform.position;
        position.z = position.z + 20 * Time.deltaTime;
    }

    float vertical;

}
