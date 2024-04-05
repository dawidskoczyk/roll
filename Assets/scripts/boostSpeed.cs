using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boostSpeed : MonoBehaviour
{
    private GameObject player;
    private Player_movement playerScript;
    [SerializeField] private float boostValue;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player_movement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        playerScript.thrust = playerScript.thrust * boostValue;

    }
    private void OnTriggerExit(Collider other)
    {
        playerScript.thrust = playerScript.thrust / boostValue;
    }

}
