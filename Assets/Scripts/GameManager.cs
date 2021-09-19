using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    [SerializeField] private ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetGameOver()
    {
        if (!gameOver)
        {
            Score scoreObj = new Score(DataManager.Instance.currPlayerName, scoreKeeper.score);
            DataManager.Instance.AddNewScore(scoreObj);
        }
        gameOver = true;
    }
}
