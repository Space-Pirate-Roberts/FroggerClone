using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeName : MonoBehaviour
{
    public InputField textbox;

    public void Start()
    {
        PlayerPrefs.SetInt("nameChanged", 0);
    }

    public void editName()
    {
        PlayerPrefs.SetInt("nameChanged", 1);
        PlayerPrefs.SetString("name", textbox.text);
    }
}
