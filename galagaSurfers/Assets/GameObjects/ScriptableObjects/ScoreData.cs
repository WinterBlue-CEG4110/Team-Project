using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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

    public void Save() {
        string json = JsonUtility.ToJson(this, true);
        WriteToFile(json);
    }

    public void Load(){
        ScoreData newData = new ScoreData();
        string json = ReadFromFile();
        JsonUtility.FromJsonOverwrite(json, newData);
        for(int i = 0; i < newData.Scores.Length - 1; i++){
            this._scores[i] = newData._scores[i];
        }
    }

    private void WriteToFile(string json){
        string path = GetFilePath();
        FileStream fileStream = new FileStream(path, FileMode.Create);

        using(StreamWriter writer = new StreamWriter(fileStream)){
            writer.Write(json);
        }
    }

    private string ReadFromFile(){
        string path = GetFilePath();
        if(File.Exists(path)){
            using(StreamReader reader = new StreamReader(path)){
                string json = reader.ReadToEnd();
                return json;
            }
        }
        else{
            Debug.LogWarning("FNF");
            return "";
        }
    }

    private string GetFilePath(){
        return Application.dataPath+ "/Scores.json";
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
        return -a.g_Score.CompareTo(b.g_Score);
    }
}