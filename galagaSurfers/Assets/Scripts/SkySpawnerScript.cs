using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Creates more background objects to help maintain the illusion of movement.
//Objects are spawned and then fall down on their own due to the BackgroundScript
public class SkySpawnerScript : MonoBehaviour
{
    public GameObject sky;
    //rate at which background objects are spawned
    public float spawnRate= 12;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        //create one immediately at the start
        Instantiate(sky, transform.position, transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        //If timer is less than the chosen spawn rate, increment timer, otherwise...
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        //... create a new background image
        else
        {
            Instantiate(sky, transform.position, transform.rotation);
            timer = 0;
        }
    }

}
