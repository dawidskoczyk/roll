using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerUp : MonoBehaviour, IPickUp
{
    private Player_movement player;
    public float moveUp = 1;
    public float jumpUp = 1.5f;
    public float duringTime = 5;

    //private void Start()
    //{
    //    player = GameObject.FindGameObjectWithTag("Player");
    //    playerScript = player.GetComponent<Player_movement>();
    //    //playerScript.boostEvent += boost;
    //}
    private void OnTriggerEnter(Collider other)
    {
        player = other.GetComponent<Player_movement>();
    }

        public void boost()
    {
        player.movementBoost = moveUp;
        player.jumpBoost = jumpUp;
        Invoke(nameof(resetBoost), duringTime);
        
    }

    private void resetBoost()
    {
        moveUp = 1;
        jumpUp = 1.5f;
        player.movementBoost = moveUp;
        player.jumpBoost = jumpUp;
    }

    public void PickUp(Player_movement ps)
    {
        boost();
    }
}
