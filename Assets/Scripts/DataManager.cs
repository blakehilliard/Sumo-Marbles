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
    public string currPlayerName;
    private List<Score> highScores = new List<Score>();
    private const int maxScores = 10;

    public List<Score> GetHighScores()
    {
        return highScores;
    }

    public void AddNewScore(Score score)
    {
        bool added = false;
        for (int idx = 0; idx < highScores.Count; idx++)
        {
            if (score.num >= highScores[idx].num)
            {
                highScores.Insert(idx, score);
                added = true;
                break;
            }
        }

        if (!added && highScores.Count < maxScores)
        {
            highScores.Add(score);
        }

        while (highScores.Count > maxScores)
        {
            highScores.RemoveAt(highScores.Count - 1);
        }
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