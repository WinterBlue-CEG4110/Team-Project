// created by: Long Nguyen
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    private Vector3 originalPosition;
    private float leftBoundry = -10f; // Define left boundary
    private float rightBoundry = 10f; // Define right boundary
   // private float bottomBoundry = -7f; // Define bottom boundary
    private float topBoundry = 7f; // Define top boundary
    private float enemySpeed = 2f;
    private float incrementSpeed= 0.5f;
    private float speedIntervalIncrement=3f;
    private float timeOfLastIncrement=0f;


    void Start()
    {
        // Store the original position of the bot
        originalPosition = transform.position;
    }

    void Update()
    {
        // Move the bot downwards
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        timeOfLastIncrement += Time.deltaTime;
        if (timeOfLastIncrement >= speedIntervalIncrement){
            enemySpeed += incrementSpeed;
            timeOfLastIncrement = 0f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundry")
        {
            Respawn();
        }
        if (collision.gameObject.tag == "Player")
        {
            Respawn();
        }
    }

    void Respawn()
    {
        // Generate random respawn position within defined boundaries
        float randomX = Random.Range(leftBoundry, rightBoundry);
        transform.position = new Vector3(randomX, topBoundry+2, 0f);
    }
}
