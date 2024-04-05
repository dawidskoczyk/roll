using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject goalText;
    [SerializeField] private ParticleSystem goal1;
    [SerializeField] private ParticleSystem goal2;
    bool scored = false;

    // Update is called once per frame
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("weszlo");
        if (!scored)
        {
            if (other.tag == "ballToScore")
            {
                goalText.SetActive(true);
                GetComponent<AudioSource>().Play();
                scored = true;
                goal1.Play();
                goal2.Play();
                Invoke(nameof(endText), 3f);

            }
        }
    }
    private void endText()
    {
        goalText.SetActive(false);

    }
}
