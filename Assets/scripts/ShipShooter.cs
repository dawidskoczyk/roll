using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooter : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    public Transform shootPoint;
    private bool shoot = true;
    float fireRate = 0.8f;
    float nextFire = 1.2f;
    public float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //czas pomiedzy strzalami
        if (shoot == true)
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                shootEnemy();
            }


    }
   
    private void shootEnemy()
    {
        //strzela w kierunku gracza
        Vector3 direction = target.position - transform.position;
        GameObject go = Instantiate(projectile, shootPoint.position, transform.rotation);
        go.GetComponent<Rigidbody>().velocity = direction.normalized * speed;
        Destroy(go, 3f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        //wy³¹cza strzelanie statku na 3 sekundy gdy gracz go trafi pociskiem 
        if(collision.transform.tag == "bullet")
        {
            shoot = false;
            Invoke(nameof(resetShoot), 3f);
        }
    }
    private void resetShoot()
    {
        //aktywacja strzelania
        shoot =true;
    }
}
