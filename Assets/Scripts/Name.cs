using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Name : MonoBehaviour
{
    public Text textDisplay;

    private void Start()
    {
        textDisplay.text = PlayerPrefs.GetString("Player");
    }
}
