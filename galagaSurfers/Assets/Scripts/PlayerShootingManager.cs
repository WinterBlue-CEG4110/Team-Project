using UnityEngine;
using DigitalRuby.Pooling;
using UnityEngine.InputSystem;
using UnityEditor;

/// <summary>
/// Manages Player Shooting Mechanics
/// Written By Thavi
/// </summary>
public class PlayerShootingManager : MonoBehaviour
{

    public static PlayerShootingManager Instance;

    [SerializeField] private GameObject shootPosition; 

    private const string key_projectile_base = "Projectile_Base";
    private const string key_projectile_upgrade = "Projectile_Upgrade";

    private string currentProjectile = key_projectile_base;

    public bool isPowerEquipped;

    private void Awake()
    {
        Instance = this;
        currentProjectile = key_projectile_base;    
    }

    public void Shoot()
    {
        if(GameManager.Instance._gameState == GameState.gameOver)
            return;
        

        //Using Simple Pooling plugin to handle the spawning. Helps with optimization.
        GameObject obj = SpawningPool.CreateFromCache(currentProjectile);
        if (obj == null)
        {
            Debug.LogErrorFormat("Unable to find object for key: {0}", currentProjectile);
            return;
        }

        obj.transform.position = shootPosition.transform.position;
        obj.transform.rotation = Quaternion.identity;

        SoundManager.Instance.PlaySfxSound(GameAssets.Instance.fireAudioClip);
    }

    public void UpgradeProjectile()
    {
        isPowerEquipped = true;
        currentProjectile = key_projectile_upgrade;
    }

    public void DowngradeProjectile()
    {
        isPowerEquipped = false;
        currentProjectile = key_projectile_base;
    }
}
