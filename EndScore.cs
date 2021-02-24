using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScore : MonoBehaviour
{
    
        
        public Text highScoreText;
        public static int highScoreValue;

        void Start()
        {
            if (PlayerPrefs.GetInt("HighScore") != null)
            {
                highScoreValue = PlayerPrefs.GetInt("HighScore");

            }

        }

        // Update is called once per frame
        void Update()
        {
           
            highScoreText.text = "High Score: " + highScoreValue;


        }
    }