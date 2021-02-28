using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore;

    public Text scoreText;

    private void Start()
    {
        CurrentScore = 0;
    }

    private void Update()
    {
        scoreText.text = CurrentScore.ToString();
    }
}
