using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Score
{
    public string name;
    public int num;

    public Score(string initName, int initNum)
    {
        name = initName;
        num = initNum;
    }
}

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;
    private List<Score> highScores = new List<Score>();

    public List<Score> GetHighScores()
    {
        return highScores;
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
        LoadHighScores();
    }

    private void LoadHighScores()
    {
        highScores.Add(new Score("Omar", 50));
        highScores.Add(new Score("Cedric", 40));
        highScores.Add(new Score("Jon", 30));
        highScores.Add(new Score("Juan", 20));
        highScores.Add(new Score("Ikey", 10));
    }
}