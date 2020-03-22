using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject ball;
    Vector3 distance;
    void Start()
    {
        distance = transform.position - ball.transform.position; //to follow the ball for camera
    }

    void Update()
    {
        transform.position = ball.transform.position + distance;
    }
}
