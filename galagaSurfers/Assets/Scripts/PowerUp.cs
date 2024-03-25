using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float moveSpeed;
    public AudioClip pickupAudioClip;

    public virtual void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * moveSpeed);
    }

    public virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SoundManager.Instance.PlaySfxSound(GameAssets.Instance.powerPickupAudioClip);
        }
    }
}
