using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Created by: John McGuff
//Controls the options menu for the MainMenu Scene
public class MainMenuOptionsScript : MonoBehaviour
{

    public GameObject mainMenuUI;
    public GameObject optionsUI;
    // Update is called once per frame
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
}
