using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float shootInterval = 5f; // Adjust this to set the interval between shots
    private float lastShootTime;

    void Start()
    {
        lastShootTime = Time.time; // Initialize lastShootTime
    }

    void Update()
    {
        // Check if enough time has passed since the last shot
        if (Time.time - lastShootTime >= shootInterval)
        {
            Shoot(); // Call the Shoot method to instantiate the projectile
            lastShootTime = Time.time; // Update lastShootTime
        }
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

}