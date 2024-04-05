using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WallOpener : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject wallToDestroy;
    public GameObject wallToEnable1;
    public GameObject wallToEnable2;
    public GameObject Player;
    public GameObject Collectibles;
    private Player_movement player;
    float wynik;
    void Start()
    {
        player = Player.GetComponent<Player_movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.score == Collectibles.transform.childCount)
        {
            wallToDestroy.SetActive(false);
            wallToEnable1.SetActive(true);
            wallToEnable2.SetActive(true);
        }
    }
}
