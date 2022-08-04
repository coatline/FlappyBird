using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    static HighScore reference;

    Text highScoreText;

    int highScore;

    void Start()
    {
        HighScoreness = PlayerPrefs.GetInt("highScore", 0);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("highScore", highScore);
    }

    public static int HighScoreness
    {
        get { return reference.highScore; }
        set
        {
            reference.highScore = value;
            reference.highScoreText.text = "Highscore: " + reference.highScore;
        }
    }

    void Awake()
    {
        reference = this;
        highScoreText = GetComponent<Text>();
    }
}
