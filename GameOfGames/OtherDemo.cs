using UnityEngine;
using System.Collections;

public class OtherDemo : MonoBehaviour {
	public GameObject player; //game Object mit dem Namen player aufrufen
	private Demo playerScript; //Demo Klasse aufrufen und Name playerScript vergeben


	// Use this for initialization
	void Start () {
		playerScript = player.GetComponent<Demo>();
		playerScript.DamagePlayer (1);
		//Demo.DamagePlayer(); wenn DamagePlayer static wäre
	}
	// Update is called once per frame
	void Update () {
		if (playerScript.health <= 0) {
			print ("Another Object has detected, that the Player is dead!");
		}
	}
}
