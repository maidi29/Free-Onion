﻿using UnityEngine;
using System.Collections;

public class NewLevel : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if (collider.tag == "Player"){
		Application.LoadLevel ("LevelOverview");
		}
	}
}
