﻿using UnityEngine;

public class Rotate : MonoBehaviour {

	// Use this for initialization
	void Start() {

	}
	
	// Update is called once per frame
	void Update() {
		transform.Rotate(0f, 0f, Time.deltaTime * 50);
	}
}
