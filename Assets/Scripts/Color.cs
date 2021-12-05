using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Color : MonoBehaviour
{
    public Dropdown dropdown;
    public GameObject Player;
    public Color color;

    string change;
    Renderer thisRend;
    public Material Blue;
    public Material Green;
    public Material Black;

    public void ColorChange()
    {
        switch (dropdown.value)
        {
            case 1:
                Player.GetComponent<Renderer>().sharedMaterial = Blue;
                break;

            case 2:
                Player.GetComponent<Renderer>().sharedMaterial = Green;
                break;
            case 3:
                Player.GetComponent<Renderer>().sharedMaterial = Black;
                break;

            default:
                break;
        }

    }
}
