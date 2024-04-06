using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBoardScript : MonoBehaviour
{
    public ScoreData scores;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(scores.Scores[scores.Scores.Length - 1].g_Score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
