using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Script handling the player's score
public class PlayerScoreScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    private float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer+= Time.deltaTime;
        //Every ten seconds, give the player some points (as a treat)
        if(timer > 10)
        {
            AddScore(5);
            timer = 0;
        }
        scoreText.text = playerScore.ToString();
    }
    //add to the player's score (public method, can be used anywhere)
    public void AddScore(int add)
    {
        playerScore += add;
    }
}
