using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource musicSource;
    public AudioSource sfxSource;

    public AudioClip menu;
    public AudioClip background;
    public AudioClip explode;
    public AudioClip bulletHit;
    public AudioClip buttonClick;
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("Current Scene: " + currentScene.name);
        if (currentScene.name == "StartMenu") {
            musicSource.clip = menu;
        } else if (currentScene.name == "OptionsMenuImpl") {
            musicSource.clip = background;
        } else if (currentScene.name == "MainScene") {
            musicSource.clip = background;
        }
        musicSource.loop = true;
        musicSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
