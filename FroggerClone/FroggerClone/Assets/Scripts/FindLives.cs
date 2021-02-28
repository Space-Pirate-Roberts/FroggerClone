using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindLives : MonoBehaviour
{
    public Text livesText;
    
    // Start is called before the first frame update
    void Start()
    {
        livesText.text = PlayerPrefs.GetInt("lives").ToString();  
    }

}
