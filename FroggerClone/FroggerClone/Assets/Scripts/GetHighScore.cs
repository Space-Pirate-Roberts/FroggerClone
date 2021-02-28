using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetHighScore : MonoBehaviour
{
    public Text highScoreText;
    public Text champ;

    // Start is called before the first frame update
    void Start()
    {
        champ.text = PlayerPrefs.GetString("champ", "Frogger");
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", PlayerPrefs.GetInt("score"));
            highScoreText.text = PlayerPrefs.GetInt("highScore").ToString();
            champ.text = PlayerPrefs.GetString("name");
        }
    }

}
