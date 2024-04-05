using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using System;

public class Player_movement : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject Collectibles;
    public float thrust = 5;
    public float score;
    private float x, z;
    private bool jump = false;
    public event Action pickupEvent;
    public event Action nextSceneEvent;
    
    public Transform cam;
    public float jumpBoost = 1.5f;
    public float movementBoost = 1;
    bool grounded;

    private GameObject[] CollectiblesArray;
    private float maxScore;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpBoost = 1.5f;
        movementBoost = 1;
        CollectiblesArray = GameObject.FindGameObjectsWithTag("Collectible");
        maxScore = CollectiblesArray.Length;
    }

    // Update is called once per frame
    private void Update()
    {
        movement();
    }

    void FixedUpdate()
    {
        moveController();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "Collectible")
        //    Points();
        //if(other.tag == "powerUp")
        //{
        //    boost();
        //}

        if (other.GetComponent<IPickUp>() != null)
        {
            other.GetComponent<IPickUp>().PickUp(this);
        };

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!jump)
            GetComponent<ParticleSystem>().Play();
    }

    private void moveController()
    {
        //kierunki kamery
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;
        
        camForward.y = 0;
        camRight.y = 0;
        //relacje do kierunku kamery
        Vector3 forwardRelative = z * camForward;
        Vector3 rightRelative = x * camRight;

        Vector3 moveDir = forwardRelative + rightRelative;

        rb.AddForce(new Vector3(moveDir.x, 0, moveDir.z) * thrust * movementBoost);
        if (jump)
        {
            rb.AddForce(Vector3.up * thrust * 50 * jumpBoost);
            jump = false;
        }
    }
    private void movement()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, 1f);
        z = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        if (Input.GetKeyUp("space") && grounded)
        {
            jump = true;
        }
    }
    public void Points()
    {
        score += 1;
        pickupEvent?.Invoke();        
        if(score == maxScore)
        {
            nextSceneEvent?.Invoke();
        }
    }

    //private void boost()
    //{
    //    boostEvent?.Invoke();
    //}
    
}
