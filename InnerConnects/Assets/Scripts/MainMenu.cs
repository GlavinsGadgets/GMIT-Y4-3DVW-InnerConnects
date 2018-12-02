using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    //Menu Options, Play and Quit.

	public void PlayGame ()
    {
        SceneManager.LoadScene(1);
	}
    public void QuitGame()
    {
        Application.Quit();
    }
}
