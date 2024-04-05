using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource musicSource;
    public AudioSource soundFXSource;

    public AudioClip menu;
    public AudioClip background;
    public AudioClip buttonClick;
    public AudioClip explode;
    void Start()
    {
        musicSource.clip = menu;
        musicSource.loop = true;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return)) {
            musicSource.clip = background;
            musicSource.loop = true;
            musicSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.Backspace)) {
            musicSource.Stop();
        }
    }

    public void PlaySFX(AudioClip clip) {
        soundFXSource.PlayOneShot(clip);
    }
}
