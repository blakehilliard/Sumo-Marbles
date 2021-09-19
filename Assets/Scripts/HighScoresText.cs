using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoresText : MonoBehaviour
{
    private Text scoresText;

    // Start is called before the first frame update
    void Start()
    {
        scoresText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoresText.text = "High Scores\n";
        foreach (Score score in DataManager.Instance.GetHighScores())
        {
            scoresText.text += score.name + ": " + score.num + "\n";
        }
    }
}
