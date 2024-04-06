using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreData", menuName = "New Score Data", order = 1)]
public class ScoreData : ScriptableObject
{
    /*
    *   Getter / Setter property for List of scores.
    */
    public Data[] Scores { 
        get{
Array.Sort(this._scores, new ScoreComparer());
return this._scores;
} 
        set{
            for (int i = 0; i < this._scores.Length; i++){
                this._scores[i] = value[i];
            }
        }
    }

    [SerializeField]
    private Data[] _scores;

    /*
    *   On creation, populate with empty scores.
    */
    public ScoreData() : base(){
        _scores = new Data[10];
        for(int i = 0; i < 10; i++)
            _scores[i] = new Data();
    }
}

[System.Serializable]
/*
*   Container for individual scores and the name of their... I cant think of a word to describe this. Owner? feels weird.
*/
public class Data{
    [SerializeField]
    private string _name;
    [SerializeField]
    private int _score;
    public string g_Name {get{return this._name;}}
    public int g_Score {get{return this._score;}}
    public Data(){
        _name = "___";
        _score = 0;
    }
    
    public Data(string name, int score){
        this._name = name;
        this._score = score;
    }

    public Data(Data other){
        this._name = other.g_Name;
        this._score = other.g_Score;
    }
}

public class ScoreComparer : IComparer<Data>{
    public int Compare(Data a, Data b){
        return a.g_Score.CompareTo(b.g_Score);
    }
}