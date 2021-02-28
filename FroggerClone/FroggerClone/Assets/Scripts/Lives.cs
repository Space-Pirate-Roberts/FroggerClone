using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public static int currentLives;

    public Text livesText;

    public void Start()
    {
        currentLives = PlayerPrefs.GetInt("lives");
    }

    public void Update()
    {
        livesText.text = currentLives.ToString();
    }
}
