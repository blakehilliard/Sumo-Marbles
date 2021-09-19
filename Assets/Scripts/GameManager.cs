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
            DataManager.Instance.AddNewScore(new Score("Name", scoreKeeper.score));
        }
        gameOver = true;
    }
}
