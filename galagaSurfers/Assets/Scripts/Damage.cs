using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Gives Damage to player on button click
/// Written By Thavi
/// </summary>
public class Damage : MonoBehaviour
{
    AudioManager audioManager;

    private void Awake() {
        audioManager = GameObject.FindGameObjectWithTag("KhaAudio").GetComponent<AudioManager>();
    }

    [Button(buttonSize:1)]
    public void DamagePlayer()
    {
        audioManager.PlaySFX(audioManager.buttonClick);
        if (GameManager.Instance._gameState == GameState.gameOver)
            return;

        Health health = GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();
        if(health == null)
        {
            Debug.Log("Can't find player");
        }
        else
        {
            health.TakeDamage();
        }
    }
}
