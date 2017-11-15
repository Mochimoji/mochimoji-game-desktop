using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartScript : MonoBehaviour {

	void Start() 
	{
	}

	void OnGUI()
	{
		// GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 50), "Mochimoji");

		if(GUI.Button(new Rect(Screen.width / 2 - 60, 450, 100, 40), "NEW GAME"))
		{
			SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Single);
		}
	}
}