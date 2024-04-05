using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject DirectionPoints;
    public Transform[] DirectionPointsChilds;
    public float speed = 10f;
    private int i = 1;
    public Transform targetObject;
    public float rotationSpeed = 5f;
    void Start()
    {
        DirectionPoints = GameObject.Find("guardianPoints");
        DirectionPointsChilds = DirectionPoints.GetComponentsInChildren<Transform>();
    }

    void Update()
    {
        moveShip();
    }
    void moveShip()
    {
        Transform currentPointTransform = DirectionPointsChilds[i];
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, DirectionPointsChilds[i].position, step);
        if (transform.position == currentPointTransform.position)
        {
            i++;
            if (i >= DirectionPointsChilds.Length)
            {
                i = 1; // Reset do pocz¹tku
            }
        }

    }
}
