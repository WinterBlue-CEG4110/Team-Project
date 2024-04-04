using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//Created by: John McGuff
//Controls for the main menu ui elements
public class MainMenuScript : MonoBehaviour
{
    //Loads the main game scene
    public void StartGame() {
        SceneManager.LoadScene("MainScene");
    }

    //Exits the application
    public void Quit() {
        Debug.Log("If you are in the editor, the game would have quit out here.");
        Application.Quit();
    }
}
