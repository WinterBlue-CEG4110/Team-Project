using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shield Powerup Class
/// Written By Thavi
/// </summary>
public class PowerUpShield : PowerUp
{
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        base.OnTriggerEnter2D(collision);

        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<Health>().ActivateShield();
            Destroy(gameObject);
        }
    }
}
