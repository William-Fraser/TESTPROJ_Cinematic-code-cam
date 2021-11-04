using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCam : MonoBehaviour
{
    [Header("Cinematic Controls")]
    public float start;

    public GameObject camDolly;
    public GameObject target;
    public float speed;
    public float amplitude;
    public float frequency;

    
    // Start is called before the first frame update
    void Start()
    {
        camDolly.transform.position = new Vector3(start, camDolly.transform.position.y, camDolly.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        camDolly.transform.LookAt(target.transform);
        camDolly.transform.position = new Vector3(camDolly.transform.position.x+speed, camDolly.transform.position.y, camDolly.transform.position.z);

        Vector3 wobble;
        wobble.x = PerlinNoise(Time.time, 0.0f);
        wobble.y = PerlinNoise(Time.time, 1.0f);
        wobble.z = 0;

        transform.localPosition = wobble;
    }
    private float PerlinNoise(float x, float y)
    {
        return ((Mathf.PerlinNoise(x * frequency, y) * 2) - 1) * amplitude;
    }
}
