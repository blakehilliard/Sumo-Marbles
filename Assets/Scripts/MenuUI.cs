using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static Exiter;

public class MenuUI : MonoBehaviour
{
    private Text playerNameText;
    private Button startButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton = GameObject.Find("Start Button").GetComponent<Button>();
        playerNameText = GameObject.Find("Name Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        startButton.interactable = playerNameText.text.Length > 0;
    }

    public void StartGame()
    {
        DataManager.Instance.currPlayerName = playerNameText.text;
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Exiter.Exit();
    }
}
