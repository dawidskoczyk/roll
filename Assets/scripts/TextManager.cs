using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextManager : MonoBehaviour
{
    GameObject player;
    private TMP_Text punkty;
    private Player_movement playerScript; 
    // Start is called before the first frame update
    void Start()
    {
        punkty = GameObject.Find("points").GetComponent<TMP_Text>();
        player = GameObject.FindGameObjectWithTag("Player");
        playerScript = player.GetComponent<Player_movement>();
        //punkty.text = playerScript.score.ToString();
        playerScript.pickupEvent += updateText;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void updateText()
    {
        if (punkty != null)
        {
            punkty.text = playerScript.score.ToString();
            Debug.Log("Zdoby³eœ punkt");
            Debug.Log("Masz " + playerScript.score + "punktów");
        }
    }
}
