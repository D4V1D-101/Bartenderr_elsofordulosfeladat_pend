using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class main : MonoBehaviour
{

    public int score;
    public bool isGameOver;
    public Transform title;
    public TextMeshProUGUI scoreboard;

    void Start()
    {
        score = 0;
        isGameOver = false;
        scoreboard.text = "0";
    }

    
    void Update()
    {
        if (isGameOver == true)
        {
            title.localPosition = new Vector3(8f, 577f, 0f);
            isGameOver = false;
        }
    }

    public void scoreAdd()
    {
        score ++;
        scoreboard.text = score.ToString();
    }

    public void newGame() 
    { 
        SceneManager.LoadScene(0);
    }
}
