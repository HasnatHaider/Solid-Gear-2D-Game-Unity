using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


	// Use this for initialization
	public void PlayGame()
	{
		SceneManager.LoadScene ("SelectLevel");
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	public void QuitGame()
	{
		Application.Quit ();
	}
	public void MoreGames()
	{
		Application.OpenURL ("https://play.google.com/store/apps/developer?id=Khezer+Mustafa");

	}
	public void RateUs()
	{
		Application.OpenURL("https://play.google.com/store/apps/details?id="+Application.identifier);
	}

	public void MainMen()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene("MainMenu");
	}
	public void backgroundMusic()
	{
		AudioListener.pause = !AudioListener.pause;

	}
	public void OnVolume()
	{
		AudioListener.pause = !AudioListener.pause;
	}
		
}
