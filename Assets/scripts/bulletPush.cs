using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletPush : MonoBehaviour
{
    // Start is called before the first frame update
    private float pushForce = 20f;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            //odpycha gracza w przeciwnym kierunku
            collision.gameObject.GetComponent<Rigidbody>().AddForce(-transform.forward * pushForce, ForceMode.Impulse);
           
        }
        
    }
}
