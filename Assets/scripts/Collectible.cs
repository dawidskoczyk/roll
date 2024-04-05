using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour, IPickUp
{
    private Player_movement player;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(30 * Time.deltaTime, 20* Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "bullet")
        {
            GetComponent<ParticleSystem>().Play();
            player = other.GetComponent<Player_movement>();
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;
            GetComponent<AudioSource>().Play();
            Invoke(nameof(disableObject), 2f);
        }
    }
    private void disableObject()
    {
        Debug.Log("usuwa");
        gameObject.SetActive(false);
    }

    public void PickUp(Player_movement ps)
    {
        ps.Points();
    }
}
