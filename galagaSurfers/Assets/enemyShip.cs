using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShip : MonoBehaviour
{
    private Vector3 originalPosition;
    private float leftBoundry = -10f; // Define left boundary
    private float rightBoundry = 10f; // Define right boundary
    private float topBoundry = 7f; // Define top boundary
    private float stopY = 2.7f; // Define the "y" position where the enemy should stop
    private bool isRespawning = false; // Flag to track if the enemy is respawning

    public float respawnTime = 3f; // Respawn time in seconds
    public float moveSpeed = 4;

    void Start()
    {
        // Store the original position of the bot
        originalPosition = transform.position;
    }

    void Update()
    {
        // Move the bot downwards only if it hasn't reached the stopY position and is not respawning
        if (transform.position.y > stopY && !isRespawning)
        {
            transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boundry" || collision.gameObject.tag == "Player")
        {
            Respawn();
        }
    }

    void Respawn()
    {
        if (!isRespawning)
        {
            isRespawning = true;
            // Generate random respawn position within defined boundaries
            float randomX = Random.Range(leftBoundry, rightBoundry);
            transform.position = new Vector3(randomX, topBoundry + 2, 0f);
            StartCoroutine(ResetRespawnFlag());
        }
    }

    IEnumerator ResetRespawnFlag()
    {
        yield return new WaitForSeconds(respawnTime);
        isRespawning = false;
    }
}
