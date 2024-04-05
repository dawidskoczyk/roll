using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos; 
    private float startTime;
    public float speed = 15f;
    private float journeyLength;
    public bool loop = true;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        journeyLength = Vector3.Distance(startPos.position, endPos.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (!loop) {
            float distCovered = (Time.time - startTime) * speed;

            // Fraction of journey completed equals current distance divided by total distance.
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJourney);
        }
       
        if (loop)
        {
            float distCovered = Mathf.PingPong(Time.time - startTime, speed);
            float fractionOfJourney = distCovered / journeyLength;

            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startPos.position, endPos.position, fractionOfJourney);
        }

    }

}
