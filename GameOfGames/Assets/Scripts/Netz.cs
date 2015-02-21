using UnityEngine;
using System.Collections;

public class Netz : MonoBehaviour {
	GameObject player;
	private PlayerMovement playerScript;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		playerScript = player.GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D (Collision2D collision) {
		if(collision.gameObject == player) {
			if (playerScript.blase.activeInHierarchy) {
				playerScript.blase.SetActive (false);
			}
			else {
				playerScript.DamagePlayer (100);
			}
		}

	}

	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Projectile"){
			Destroy (gameObject);
		}
	}
}