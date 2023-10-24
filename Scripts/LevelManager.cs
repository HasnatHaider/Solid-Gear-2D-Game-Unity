using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour {

	public Button[] mybuttons;


	// Use this for initialization
	void Start () {
		int level = PlayerPrefs.GetInt ("level", 1);
		print ("Level Unlock "+level);
		for (int i = level; i < mybuttons.Length; i++) {

			mybuttons [i].GetComponent<Button> ().interactable = false;
		}
	}
	public void level_onbtnclciked(int a)
	{

		SceneManager.LoadScene (a.ToString ());
	}

   
    public void One()
    {

        SceneManager.LoadScene("1");
    }
    public void Two()
    {

        SceneManager.LoadScene("2");
    }
    public void Three()
    {

        SceneManager.LoadScene("3");
    }
	public void ResetLevels()
	{

		PlayerPrefs.DeleteAll ();
	}
    public void MainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }
    public void LevelSelect()
    {

        SceneManager.LoadScene("LevelSelect");
    }
    public void PauseGame()
    {

       // Time.deltatime = 0;
    }

	// Update is called once per frame
	void Update () {

	}




}
