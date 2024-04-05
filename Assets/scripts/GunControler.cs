using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControler : MonoBehaviour
{
    public GameObject bullet;
    public Rigidbody player;
    public GameObject camera;
    public float forceMagnitude = 10f;
    public float liftAmount = 100f;
    public Animator anim;
    public ParticleSystem particle; 

  

    // Start is called before the first frame update
    void Start()
    {
        Vector3 movement = transform.forward * 10;
        movement.y = liftAmount;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    public void Shoot()
    {
        GetComponent<Animator>().SetTrigger("shoot");
        GameObject go = Instantiate(bullet, transform.position, Quaternion.identity);

        // Apply the force to the Rigidbody using AddForce
        go.GetComponent<Rigidbody>().AddForce(transform.forward * 10f , ForceMode.Impulse);
        anim.Play("gun");
        particle.Play();
        Invoke(nameof(ResetShoot), 0.5f);
    }
    void ResetShoot()
    {
        GetComponent<Animator>().ResetTrigger("shoot");
    }
}


//
