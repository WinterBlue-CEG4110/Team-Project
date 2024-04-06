using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio; // KL
using UnityEngine.UI; // KL

//Created by: John McGuff, Kha Le
//Controls the options menu for the MainMenu Scene
public class MainMenuOptionsScript : MonoBehaviour
{
    public AudioMixer myMixer; // KL
    public Slider mySlider; // KL

    public GameObject mainMenuUI;
    public GameObject optionsUI;
    // Update is called once per frame
    void Start() { // KL
        if (PlayerPrefs.HasKey("musicVolume")) {
            LoadVolume();
        } else {
            SetMusicVolume(); 
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            Exit();
        }
    }
    public void Exit(){
        mainMenuUI.SetActive(true);
        optionsUI.SetActive(false);
    }

    public void SetMusicVolume() { // KL
        // Set the music parameter base on slider value
        float volume = mySlider.value;
        // myMixer.SetFloat("music", volume); The slider value ranges from 0 to 1 only
        myMixer.SetFloat("music", Mathf.Log10(volume)*20);
        PlayerPrefs.SetFloat("musicVolume", volume); // Save value of volume
    }

    private void LoadVolume() { // KL
        mySlider.value = PlayerPrefs.GetFloat("musicVolume"); // Load previous volume setting
        SetMusicVolume();
    }
}
