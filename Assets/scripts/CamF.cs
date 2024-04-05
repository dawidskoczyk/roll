using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraFollow : MonoBehaviour
{
    public GameObject ball;

    void FixedUpdate()
    {
        Vector3 pos = ball.transform.position;
        transform.position = pos;
    }
}

