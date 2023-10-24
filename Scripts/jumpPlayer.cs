using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityStandardAssets.CrossPlatformInput;
public class jumpPlayer : MonoBehaviour {

	public float jumpForce;
	private Rigidbody2D myrigidbody;
	private Animator myAnimator;

	//private AudioSource JumpSound;
	//private AudioSource SlideSound;
	// Use this for initialization
	void Start () {
	myrigidbody = GetComponent<Rigidbody2D> (); 
		myAnimator = GetComponent<Animator> ();

		//JumpSound = GameObject.Find ("JumpSound").GetComponent <AudioSource>();
		//SlideSound = GameObject.Find ("SlideSound").GetComponent <AudioSource>();
	//	Invoke ("ShowBanner",1);
	}


	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) ) {
			myrigidbody.velocity = new Vector2 (myrigidbody.velocity.x, jumpForce);	
			myAnimator.SetTrigger ("Jump");
			//JumpSound.Play ();
			//myAnimator.SetTrigger ("NewJump");


		
		}
		if (Input.GetKeyDown (KeyCode.A) ) {
			myAnimator.SetTrigger ("Slide");
			//SlideSound.Play ();
		}
	}

}
	
