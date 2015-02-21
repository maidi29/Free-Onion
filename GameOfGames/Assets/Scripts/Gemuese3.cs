using UnityEngine;
using System.Collections;

public class Gemuese3 : MonoBehaviour {
	public int healthPlus;
	GameObject player_go;
	public GameObject plus;
	private PlayerMovement playerScript;
	// Use this for initialization
	void Start () {
		player_go = GameObject.FindGameObjectWithTag ("Player");
		playerScript = player_go.GetComponent<PlayerMovement> ();
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Player"){
			Anzahl3.AddPoint();
			Destroy (gameObject);
			if (playerScript.health < 100) {
				playerScript.health += healthPlus;
				/*if (healthPlus > 0) {
					StartCoroutine (showPlus (0.5f));
				}*/
			}
		}
	}
	IEnumerator showPlus(float delay) {
		plus.SetActive (true);
		yield return new WaitForSeconds (delay);
		plus.SetActive (false);
		yield break;
	}
}