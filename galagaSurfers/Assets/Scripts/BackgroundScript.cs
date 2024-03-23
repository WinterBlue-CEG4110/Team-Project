using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gives the illusion of forward momentum with a scrolling background
public class BackgroundScript : MonoBehaviour
{
    public float moveSpeed = 3;
    public float deadzone = -10;

    // Update is called once per frame
    void Update()
    {
        //Move the background down as time progresses (use delta time to avoid issues due to framerate)
        transform.position = transform.position + (Vector3.down * moveSpeed) * Time.deltaTime;
        //When we are far enough down and away from the camera, delete the background object
        if(transform.position.y < deadzone){
            Destroy(gameObject);
        }
    }
}
