using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // KL
using UnityEngine.UI; // KL
//Created by: John McGuff, Kha Le
//Script that controls the behaviour of the options menu UI in the main scene
public class MainSceneOptionsScript : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject optionsUI;    
    public GameObject back;
    public AudioMixer myMixer; // KL
    public Slider mySlider; // KL

    void Start() { // KL
        if (PlayerPrefs.HasKey("musicVolume")) {
            LoadVolume();
        } else {
           SetMusicVolume(); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            optionsUI.SetActive(false);
        }
    }
    public void Back() {
        pauseUI.SetActive(true);
        optionsUI.SetActive(false);
    }

    public void SetMusicVolume(){ // KL
        float volume = mySlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume); // Save value of volume
    }

    private void LoadVolume() { // KL
        mySlider.value = PlayerPrefs.GetFloat("musicVolume"); // Load previous volume setting
        SetMusicVolume();
    }
}
