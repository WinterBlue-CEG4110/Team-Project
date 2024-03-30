using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
///Script for a game timer UI element
/// </summary>
public class GameTimerScript : MonoBehaviour
{
    public float gameTimer;
    public Text timerText;

    // Update is called once per frame
    void Update()
    {
        //Increments a timer to show playtime in current run
        gameTimer += Time.deltaTime;
        int rounded = (int) Math.Round(gameTimer, 0);
        timerText.text = rounded.ToString();
    }
}
