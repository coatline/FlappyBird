using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    static Score staticScore;

    Text scoreText;

    int points;

    public static int Points
    {
        get { return staticScore.points;}
        set
        {
            staticScore.points = value;
            staticScore.scoreText.text = "Score: " + staticScore.points;

        }
    }

    void Awake()
    {
        staticScore = this;
        scoreText = GetComponent<Text>();
    }
}
