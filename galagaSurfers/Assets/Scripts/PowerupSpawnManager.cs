using DigitalRuby.Pooling;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

/// <summary>
/// Manages Powerup Spawn System
/// Written By Thavi
/// </summary>
public class PowerupSpawnManager : MonoBehaviour
{
    public PlayerController playerController;

    [Space]
    public float shieldSpawnRate = 10f; 
    public float projectileSpawnRate = 8f;

    private float spawnYOffset = 2f;
    private float spawnXPadding = 1f;

    private float timeSinceLastShieldSpawn;
    private float timeSinceLastProjectileSpawn;

    private const string shieldKey = "Powerup_Sheild";
    private const string projectileKey = "Powerup_Gun";


    void Update()
    {
        SpawnPowers();
    }

    private void SpawnPowers()
    {
        if (GameManager.Instance._gameState == GameState.gameOver)
        {
            return;
        }

        timeSinceLastShieldSpawn += Time.deltaTime;
        timeSinceLastProjectileSpawn += Time.deltaTime;

        if (timeSinceLastShieldSpawn >= shieldSpawnRate && !playerController.health.isImmune)
        {
            SpawnShield();
            timeSinceLastShieldSpawn = 0f;
        }

        if (timeSinceLastProjectileSpawn >= projectileSpawnRate && !playerController.shootingManager.isPowerEquipped)
        {
            SpawnProjectile();
            timeSinceLastProjectileSpawn = 0f;
        }
    }

    private void SpawnShield()
    {
        GameObject obj = SpawningPool.CreateFromCache(shieldKey);
        if (obj == null)
        {
            Debug.LogErrorFormat("Unable to find object for key: ", shieldKey);
            return;
        }

        obj.transform.position = GetSpawnPosition();
        obj.transform.rotation = Quaternion.identity;
    }

    private void SpawnProjectile()
    {
        GameObject obj = SpawningPool.CreateFromCache(projectileKey);
        if (obj == null)
        {
            Debug.LogErrorFormat("Unable to find object for key: ", projectileKey);
            return;
        }

        obj.transform.position = GetSpawnPosition();
        obj.transform.rotation = Quaternion.identity;
    }

    private Vector3 GetSpawnPosition()
    {
        float randomX = Random.Range(spawnXPadding, Screen.width - spawnXPadding);
        Vector3 spawnPosition = new Vector3(randomX, Screen.height - spawnYOffset, 1f);
        Vector3 worldSpawnPosition = Camera.main.ScreenToWorldPoint(spawnPosition);
        return worldSpawnPosition;
    }
}
