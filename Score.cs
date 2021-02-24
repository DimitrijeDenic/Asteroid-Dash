using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int scoreValue ;
    public Text highScoreText;
    public static int highScoreValue;

    void Start()
    {
        if(PlayerPrefs.GetInt("HighScore") != null)
        {
            highScoreValue = PlayerPrefs.GetInt("HighScore");

        }
       
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreValue > highScoreValue)
        {
            highScoreValue = scoreValue;
            PlayerPrefs.SetInt("HighScore", highScoreValue);
        }

        scoreText.text = "Score: " + scoreValue;
        highScoreText.text = "High Score: " + highScoreValue;
        
        
    }
}