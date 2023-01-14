using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class switchScenesOnKP : MonoBehaviour
{
    public string scene;
    public KeyCode key;

    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            SceneManager.LoadScene(scene);
        }   
    }
}