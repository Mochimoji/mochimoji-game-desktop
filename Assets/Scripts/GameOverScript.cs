using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{

    void Start()
    {
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(Screen.width / 2 - 60, 700, 100, 40), "PLAY AGAIN"))
        {
            SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Single);
        }
    }
}