using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCam : MonoBehaviour
{
    [Header("Cinematic Controls")]
    public float start;

    public GameObject camDoly;
    public GameObject target;
    public float speed;
    public float amplitude;
    public float frequency;

    
    // Start is called before the first frame update
    void Start()
    {
        camDoly.transform.position = new Vector3(start, camDoly.transform.position.y, camDoly.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        camDoly.transform.LookAt(target.transform);
        camDoly.transform.position = new Vector3(camDoly.transform.position.x+speed, camDoly.transform.position.y, camDoly.transform.position.z);

        Vector3 wobble;
        wobble.x = PerlinNoise(0.0f, Time.time);
        wobble.y = PerlinNoise(1.0f, Time.time);
        wobble.z = 0;

        transform.localPosition = wobble;
        Debug.Log(Time.time);
    }
    private float PerlinNoise(float x, float y)
    {
        return ((Mathf.PerlinNoise(x * frequency, y) * 2) - 1) * amplitude;
    }
}
