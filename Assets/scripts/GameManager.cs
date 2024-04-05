using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
   // [SerializeField]
   // private GameObject[] CollectiblesArray;
    [SerializeField]
    GameObject player;
    //private float maxScore;
    [SerializeField]
    private GameObject LvlComplete;
    private UnityEngine.SceneManagement.Scene scene;
    private Player_movement playerScript;
    // Start is called before the first frame update
    void Start()
    {
        //CollectiblesArray = GameObject.FindGameObjectsWithTag("Collectible");
       // maxScore = CollectiblesArray.Length;
        scene = SceneManager.GetActiveScene();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player_movement>();
        playerScript.nextSceneEvent += LvlCompleted;
    }

    private void LvlUp()
    {
        int scNumber = scene.buildIndex;
        SceneManager.LoadScene(scNumber + 1, LoadSceneMode.Single);
    }
    private void LvlCompleted()
    {
        Debug.Log("Zebra³eœ wszystkie punkty");
        LvlComplete.SetActive(true);

        GetComponent<AudioSource>().PlayDelayed(1f);
        Invoke(nameof(LvlUp), 3f);
    }
}
