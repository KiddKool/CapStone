using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Selection : MonoBehaviour
{
 
public void levelSelect1()
    {
        SceneManager.LoadScene(2);
    }
   
    public void levelSelect2()
    {
        SceneManager.LoadScene(3);
    }

    public void levelSelect3() 
    {
        SceneManager.LoadScene(4);
    }

    public void levelSelect4()
    {
        SceneManager.LoadScene(5);
    }

    public void levelSelect5()
    {
        SceneManager.LoadScene(6);
    }

    public void levelSelect6()
    {
        SceneManager.LoadScene(7);
    }

    public void Credit()
    {
        SceneManager.LoadScene(8);
    }
}
