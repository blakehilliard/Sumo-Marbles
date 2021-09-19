using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    private GameObject scoreText;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        scoreText = GameObject.Find("ScoreText");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
            if (!gameManager.gameOver)
            {
                scoreText.GetComponent<ScoreKeeper>().score += 1;
            }
        }
    }
    void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
