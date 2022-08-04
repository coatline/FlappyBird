using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePoint : MonoBehaviour
{
    public Score sc;
    public HighScore hc;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.tag == "Player")
        {
            Score.Points++;
            if(Score.Points > HighScore.HighScoreness)
            {
                HighScore.HighScoreness++;
            }
        }
    }

}
