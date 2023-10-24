using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupPoints : MonoBehaviour 
{
	public int scoreToGive;

	private ScoreManager theScoreManager;

	public Vector3 moveDirection;

	private AudioSource coinSound;
	// Use this for initialization
	void Start () 
	{
		theScoreManager = FindObjectOfType<ScoreManager> ();
		coinSound = GameObject.Find ("CoinSound").GetComponent <AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position += moveDirection*Time.deltaTime;
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.name == "Player")
		{
			theScoreManager.AddScore (scoreToGive);
			coinSound.Play ();
			Destroy (this.gameObject);
		}
		else if (other.gameObject.CompareTag("Dummy"))
		{
			
			Destroy (this.gameObject);
		} 
			
	}
}



