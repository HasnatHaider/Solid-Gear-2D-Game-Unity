using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour {

	[Range(1f, 20f)]
	public float scrollSpeed;

	public float scrollOffset;
	Vector2 startPos;
	float newPos;
	// Use this for initialization
	void Start () {
		startPos = transform.position;

	}

	float TimeSpeed=1.2f;

	// Update is called once per frame
	void Update () {
		
		if (TimeSpeed < 4f) {
			TimeSpeed += 0.0001f;
		} else {
			TimeSpeed = 1.5f;
		}

			newPos = Mathf.Repeat (Time.time * -scrollSpeed * TimeSpeed, scrollOffset);
			transform.position = startPos + Vector2.right * newPos;
		
	}
}
