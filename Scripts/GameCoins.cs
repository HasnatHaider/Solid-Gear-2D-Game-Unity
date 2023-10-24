using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCoins : MonoBehaviour {

	public Transform parentObject;
	public GameObject coinPrefab;
	public float destroyTime=10;

	public float time;
	public Vector3 offset;
	// Use this for initialization
	void Start () {
		
	}


	float tempTime;
	void Update(){
		tempTime += Time.deltaTime;

		if (tempTime >= time ) {
			tempTime = 0;
			GameObject coin = Instantiate (coinPrefab, parentObject) as GameObject;
			coin.transform.position = this.transform.position + offset;
			time = Random.Range (0.9f, 4f);
		}

	}

}
