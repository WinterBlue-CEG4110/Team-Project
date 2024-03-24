using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("MainScene");
    }

    public void Quit() {
        Debug.Log("If you are in the editor, the game would have quit out here.");
        Application.Quit();
    }
}
