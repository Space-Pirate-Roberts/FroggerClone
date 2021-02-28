using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindName : MonoBehaviour
{
    public Text playerNameText;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("nameChanged") == 1)
        {
            playerNameText.text = PlayerPrefs.GetString("name");
        }
        else
        {
            PlayerPrefs.SetString("name", "Frogger");
            playerNameText.text = PlayerPrefs.GetString("name");
        }
    }

}
