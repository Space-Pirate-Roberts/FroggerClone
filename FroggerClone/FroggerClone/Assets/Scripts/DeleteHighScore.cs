using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteHighScore : MonoBehaviour
{
    public Text highScoreText;
    public Text champ;
    public void DeleteIt()
    {
        PlayerPrefs.SetInt("highScore", 0);
        highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
        PlayerPrefs.SetString("champ", "Frogger");
        champ.text = PlayerPrefs.GetString("champ");
    }
}
