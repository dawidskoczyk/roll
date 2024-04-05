using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToBase : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Transform startPosition;

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        //powrót na start
        collision.gameObject.transform.position = startPosition.position;
    }
}
