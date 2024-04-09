using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Created by: John McGuff
//Controls for the main menu ui elements
public class MainMenuScript : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject optionsUI;
    public GameObject creditsUI;
    //Loads the main game scene
    public void StartGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void OpenOptions() {
        mainMenuUI.SetActive(false);
        optionsUI.SetActive(true);
    }

    public void showScoreboard() {
        SceneManager.LoadScene("Scoreboard");
    }

    public void ShowCredits() {
        mainMenuUI.SetActive(false);
        creditsUI.SetActive(true);
    }

    //Exits the application
    public void Quit() {
        Debug.Log("If you are in the editor, the game would have quit out here.");
        Application.Quit();
    }
}
