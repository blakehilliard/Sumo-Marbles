using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text scoreText = GetComponent<Text>();
        List<Score> highScores = DataManager.Instance.GetHighScores();
        scoreText.text = "High Score: " + highScores[0].name + ": " + highScores[0].num;
    }
}
