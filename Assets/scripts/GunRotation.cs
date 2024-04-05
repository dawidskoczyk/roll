using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotation : MonoBehaviour
{
    public Camera camera;
    Vector3 offset;
    public float RotationSpeed;
    private Quaternion lookRotation;
    private Vector3 direction;
    float gunAngle;

    // Start is called before the first frame update
    void Start()
    {
        //camera = GameObject.Find("MainCamera");
        offset = new Vector3(0, 0.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        //RaycastHit hit;
        //if (Physics.Raycast(ray, out hit))
        //{
        //    //transform.LookAt(hit.point); // Look at the point
        //    Vector3 lookDirection = hit.point - transform.position;
        //    transform.LookAt(lookDirection);
        //    // Wyznacz obrót w kierunku tego kierunku
        //    Quaternion targetRotation = Quaternion.LookRotation(lookDirection);
        //    transform.rotation = Quaternion.Euler(new Vector3(0, transform.rotation.eulerAngles.y, 0)); // Clamp the x and z rotation
        //}
        gunAngle += Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;
        //gunAngle = Mathf.Clamp(gunAngle, -90, 90);
        transform.localRotation = Quaternion.AngleAxis(gunAngle, Vector3.up);
    }
}
