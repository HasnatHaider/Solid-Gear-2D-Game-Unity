using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

	public GameObject deathMenuUI;

	public void MainMenu()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");

	}
	public void QuitGame(){
		Application.Quit ();
	}
	public void GamePlay()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene ("GamePlay");

	}


}
