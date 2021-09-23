using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicCam : MonoBehaviour
{
    [Header("Cinematic Controls")]
    public GameObject camDolly;
    public GameObject lookAt;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-2.33f, 1.22f, -5.63f);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(lookAt.transform);
        if (transform.position.z <= 5)
            transform.position = Vector3.Lerp(transform.position, new Vector3(-2.33f, 1.22f, 5.63f), speed);
    }
}
