using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages all UI in the game
/// Written By Thavi
/// </summary>
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    [SerializeField] private GameObject[] hearts;

    private void Awake()
    {
        Instance = this;
    }

    public void DeductHeart(int currentHealth)
    {
        hearts[currentHealth].gameObject.SetActive(false);
    }
}
