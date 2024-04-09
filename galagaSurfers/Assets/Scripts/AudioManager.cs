using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Created by: Kha Le
//Controls the behaviour of the music sound effect

public class AudioManager : MonoBehaviour
{
    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip menu;
    public AudioClip background;
    public AudioClip explode;
    public AudioClip bulletHit;
    public AudioClip buttonClick;
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene(); // get the current scene
        Debug.Log("Current Scene: " + currentScene.name);
        // play the music based on what curren scene is
        if (currentScene.name == "StartMenu") {
            musicSource.clip = menu;
        } else if (currentScene.name == "OptionsMenuImpl") {
            musicSource.clip = background;
        } else if (currentScene.name == "MainScene") {
            musicSource.clip = background;
        }
        musicSource.loop = true; // lopp the music
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButtonClick() {
        sfxSource.PlayOneShot(buttonClick);
    }
}
