using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Created by: John McGuff
//Script that controls the behaviour of the options menu UI in the main scene
public class MainSceneOptionsScript : MonoBehaviour
{
    public GameObject pauseUI;
    public GameObject optionsUI;    
    public GameObject back;
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
}
