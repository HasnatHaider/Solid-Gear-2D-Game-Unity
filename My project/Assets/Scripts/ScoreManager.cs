using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;


	public float pointsperSecond;

	public bool scoreIncreasing;


	// Use this for initialization
	void Start () {
		if (PlayerPrefs.HasKey("HighScore")) {
			hiScoreCount = PlayerPrefs.GetFloat ("HighScore");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		if (scoreIncreasing) {
			scoreCount += pointsperSecond * Time.deltaTime;
		}

		if (scoreCount > hiScoreCount) {
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", hiScoreCount);
		}

		scoreText.text = "" + Mathf.Round (scoreCount);
		hiScoreText.text = "" + Mathf.Round (hiScoreCount);
	}

	public void AddScore(int pointsToAdd)
	{
		scoreCount = scoreCount + pointsToAdd;

	}
}
