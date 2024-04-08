using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;

/// <summary>
/// Manages Game State
/// Written By Thavi
/// </summary>
//Edited by John McGuff on 4/7/2024
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState _gameState;

    public GameObject restartButton;

    public GameObject GameOverUI;

    public ScoreData scores;
    
    public int playerScore = 0;

    public Text scoreText;

    public TMP_Text GOTextField;

    private float timer = 0;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        scores.Load();
        _gameState = GameState.playing;
        restartButton.SetActive(false);
    }

    //When game over, get the player's input and then load the scoreboard scene with updated scores
    void Update(){
        if(_gameState == GameState.gameOver){
            if(Input.GetKeyDown(KeyCode.Return)){
                Data newEntry = new Data(GOTextField.text, playerScore);
                Data[] newScores = new Data[10];
                for(int i = 0; i < scores.Scores.Length - 1; i++){
                    newScores[i] = scores.Scores[i];
                }
                newScores[newScores.Length - 1] = newEntry;
                scores.Scores = newScores;
                scores.Save();
                SceneManager.LoadScene("Scoreboard");
            }
        }
        timer+= Time.deltaTime;
        //Every ten seconds, give the player some points (as a treat)
        
        if(timer > 1 && _gameState != GameState.gameOver)
        {
            AddScore(5);
            timer = 0;
        }
        scoreText.text = playerScore.ToString();
    }

    public void GameOver()
    {
        _gameState = GameState.gameOver;
        GameOverUI.SetActive(true);
        SoundManager.Instance.PlaySfxSound(GameAssets.Instance.gameOverAudioClip);  
    }

    public void AddScore(int add)
    {
        playerScore += add;
    }
}

public enum GameState
{
    playing,
    gameOver
}
