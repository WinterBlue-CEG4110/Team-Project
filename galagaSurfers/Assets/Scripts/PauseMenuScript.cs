using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Created by: John McGuff
//Controls for the pause menu ui elements
public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool isPaused = false;
    //Checks to see if the Escape key is pressed
    void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused){
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    //If the escape key is pressed and the game is paused, we resume the game
    public void Resume(){
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
    //If the escape key is pressed and the game is not paused, pause the game
    void Pause(){
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    //Loads the startmenu scene when the quit button is pressed
    public void ToMainMenu() {
        //Have to use the Resume() method to reset bools, pause menu visibility, and timescale
        Resume();
        SceneManager.LoadScene("StartMenu");
    }

}
