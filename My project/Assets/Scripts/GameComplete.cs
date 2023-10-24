using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour {

//	private AudioSource deathSound;

	private Animator myAnimator;

	public static bool GameIsPaused = false;
	public GameObject pauseMenuUI;
	public GameObject deathMenuUI;
	private ScoreManager theScoreManager;

	public Vector3 moveDirection;

	// Update is called once per frame
	void Update () 
	{
		this.transform.position += moveDirection*Time.deltaTime;
	}
	public void RateUs()
	{
		Application.OpenURL("https://play.google.com/store/apps/details?id="+Application.identifier);
	}

	void Start () 
	{
	//	deathSound = GameObject.Find ("DeathSound").GetComponent <AudioSource>();
		myAnimator = GetComponent<Animator> ();

	}


	public void PlayGame()
	{	
		

		Time.timeScale = 1f;
		SceneManager.LoadScene ("GamePlay");
		//SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
   

	public void Resume()
	{
	
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}
	public void Pause()
	{
		
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}

	public void MainMenu()
	{
		
		Time.timeScale = 1f;
		SceneManager.LoadScene ("MainMenu");

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Killbox") {
		
			myAnimator.SetTrigger ("Death");

			Invoke("waitmethod",1);
	//		deathSound.Play ();

		}

	}
	void waitmethod()
	{
		deathMenuUI.SetActive (true);			

		Time.timeScale = 0;
	}
}
