using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    GameObject Player;
    Player_movement playerScript;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        playerScript = Player.GetComponent<Player_movement>();
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        //if (collision.GetComponent<IPickUp>() != null)
        //{
        //    collision.GetComponent<IPickUp>().PickUp();
        //};
        collision.GetComponent<IPickUp>().PickUp(playerScript);
    }
}
