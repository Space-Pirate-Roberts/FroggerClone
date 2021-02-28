using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeLives : MonoBehaviour
{
    public Dropdown livesDropdown;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("lives", 1);
    }

    public void editLives()
    {
        PlayerPrefs.SetInt("lives", (livesDropdown.value*2)+1);
    }
}
