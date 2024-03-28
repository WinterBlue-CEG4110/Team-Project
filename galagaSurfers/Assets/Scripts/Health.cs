using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Player Health
/// Written By Thavi
/// </summary>
public class Health : MonoBehaviour
{
    public int maxHealth = 3; 
    public float invincibilityDuration = 2f;
    public float blinkInterval = 0.1f;
    public float shieldDuration = 0.5f;
    public GameObject playerModel; 
    public GameObject ShieldGO;
    public AudioClip damageAudioClip;
    public GameObject restartButton;

    public bool isImmune; 
    private int currentHealth; 
    private bool isInvincible; 
    private Renderer modelRenderer;

    private Coroutine blinkCoroutine;

    void Start()
    {
        currentHealth = maxHealth;
        modelRenderer = playerModel.GetComponent<Renderer>();
    }

    public void TakeDamage()
    {
        if (isImmune)
        {
            isImmune = false;
            ShieldGO.SetActive(false);
            return;
        }

        if (!isInvincible)
        {
            currentHealth--;
            UIManager.Instance.DeductHeart(currentHealth);

            if (currentHealth <= 0)
            {
                // Player is out of lives, GameOver
                SoundManager.Instance.PlaySfxSound(damageAudioClip);
                Destroy(gameObject);
                GameManager.Instance.GameOver();
            }
            else
            {
                // Player still has lives, make them briefly invincible and respawn
                SoundManager.Instance.PlaySfxSound(GameAssets.Instance.damageTakenAudioClip);
                StartCoroutine(BecomeInvincible());
            }

        }
    }

    public void ActivateShield()
    {
        StartCoroutine(IEActivateShield());
    }

    private IEnumerator IEActivateShield()
    {
        isImmune = true;
        ShieldGO.SetActive(true);
        yield return new WaitForSeconds(shieldDuration);
        isImmune = false;
        ShieldGO.SetActive(false);  
    }

    // Coroutine to make the player briefly invincible
    IEnumerator BecomeInvincible()
    {
        isInvincible = true;
        StartBlinking();
        yield return new WaitForSeconds(invincibilityDuration);
        isInvincible = false;
        StopBlinking();
    }

    // Coroutine to make the player model blink during invincibility
    IEnumerator BlinkModel()
    {
        while (isInvincible)
        {
            modelRenderer.enabled = !modelRenderer.enabled;
            yield return new WaitForSeconds(blinkInterval);
        }
        modelRenderer.enabled = true;
    }

    private void StartBlinking()
    {
        if (blinkCoroutine == null)
        {
            blinkCoroutine = StartCoroutine(BlinkModel());
        }
    }

    private void StopBlinking()
    {
        if (blinkCoroutine != null)
        {
            StopCoroutine(blinkCoroutine);
            blinkCoroutine = null;
        }
        modelRenderer.enabled = true;
    }
}
