using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject)
            SceneManager.LoadScene("Game Over");

        Score.highScoreValue = PlayerPrefs.GetInt("HighScore");
    }
    
}