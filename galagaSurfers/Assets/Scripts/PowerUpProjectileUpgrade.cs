using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpProjectileUpgrade : PowerUp
{
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.CompareTag("Player"))
        {
            PlayerShootingManager.Instance.UpgradeProjectile();
            Destroy(gameObject);
        }
    }
}
