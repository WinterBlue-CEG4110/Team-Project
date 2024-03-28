using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages Game State
/// Written By Thavi
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState _gameState;

    public GameObject restartButton;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        _gameState = GameState.playing;
        restartButton.SetActive(false);
    }

    public void GameOver()
    {
        _gameState = GameState.gameOver;
        restartButton.SetActive(true);
        SoundManager.Instance.PlaySfxSound(GameAssets.Instance.gameOverAudioClip);
    }
}

public enum GameState
{
    playing,
    gameOver
}
