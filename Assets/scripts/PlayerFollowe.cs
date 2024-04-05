using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollowe : MonoBehaviour
{
    private Transform Player;
    public Vector3 cameraDistance;
    
    void Start()
    {
        Player = GameObject.Find("PlayerParent").transform;
        cameraDistance = Player.transform.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.transform.position - cameraDistance;
    }
}
