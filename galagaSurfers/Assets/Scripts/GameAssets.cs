using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages all game assets at one place
/// Written By Thavi
/// </summary>
public class GameAssets : MonoBehaviour {

    public static GameAssets _i;
    public static GameAssets Instance {
        get {
            if (_i == null) _i = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>();
            return _i;
        }
    }

    [Header("Audio Clips")]
    public AudioClip fireAudioClip;
    public AudioClip damageTakenAudioClip;
    public AudioClip powerPickupAudioClip;
    public AudioClip gameOverAudioClip;

}
