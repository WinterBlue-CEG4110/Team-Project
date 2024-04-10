using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootInterval = 5f; // Adjust this to set the interval between shots
    private float lastShootTime;
    private enemyShip enemyShipScript;

    void Start()
    {
        lastShootTime = Time.time; // Initialize lastShootTime
        enemyShipScript = FindObjectOfType<enemyShip>(); // Find the enemyShip script in the scene
    }

    void Update()
    {
        // Check if enough time has passed since the last shot and if the enemyShip is at the stop Y-axis
        if (Time.time - lastShootTime >= shootInterval && enemyShipScript.transform.position.y <= enemyShipScript.stopY)
        {
            
            lastShootTime = Time.time; // Update lastShootTime
            Shoot(); // Call the Shoot method to instantiate the projectile
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }
}
