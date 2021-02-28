using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSpeed : MonoBehaviour
{

    public Slider speedSlider;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("speed", 1f);
    }

    public void EditSpeed()
    {
        PlayerPrefs.SetFloat("speed", speedSlider.value);
    }
}
