using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pauseUI;
    public static bool isPaused = false;
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
    public void Resume(){
        pauseUI.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }
    void Pause(){
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void ToMainMenu() {
        Resume();
        SceneManager.LoadScene("StartMenu");
    }

}
