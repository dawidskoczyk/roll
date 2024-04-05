using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
    [SerializeField]GameObject projectile;
    public List<Transform> childList;
    private bool shoot= false;
    float fireRate = 0.5f;
    float nextFire = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (shoot == true)
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                shootEnemy();
            }
                
            
    }
    private void OnTriggerEnter(Collider other)
    {
        shoot = true;
    }
    private void OnTriggerExit(Collider other)
    {
        shoot = false;
    }
    private void shootEnemy() {
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            GameObject go = Instantiate(projectile, childList[i].position, Quaternion.identity);
            go.GetComponent<Rigidbody>().AddForce(-transform.forward * 30f, ForceMode.Impulse);
            Destroy(go, 3f);
        }
    }
}
