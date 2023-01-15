using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class mainMenuAct : MonoBehaviour
{
    public bool isStart;
    public bool isSettings;
    public bool isQuit;

    void OnMouseDown()
    {
        if(isStart)
        {
            SceneManager.LoadScene("game");
        }
        
        if(isSettings)
        {
            //Debug.Log("Open settings");
        }

        if(isQuit)
        {
            Application.Quit();
        }
    }
}