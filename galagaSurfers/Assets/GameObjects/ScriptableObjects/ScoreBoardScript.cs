using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

//Created by: John McGuff
//Script to control the ScoreBoard scene behavior
public class ScoreBoardScript : MonoBehaviour
{
    public ScoreData Scores;
    public GameObject ScoreLine;
    public GameObject ScoreBoard;
    void Awake() 
    {
        Scores.Load();
    }
    // Start is called before the first frame update
    void Start()
    {
        //Starts at 3 to avoid overwriting the headers
        int x = 3;
        foreach(Data val in Scores.Scores){
            GameObject clone = Instantiate(ScoreLine, ScoreBoard.transform, true);
            TMP_Text[] children = GetComponentsInChildren<TMP_Text>();
            children[x].text = val.g_Name;
            x++;
            children[x].text = val.g_Score + "";
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKey) {
            SceneManager.LoadScene("StartMenu");
        }
    }
}
