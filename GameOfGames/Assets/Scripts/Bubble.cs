using UnityEngine;
using System.Collections;

public class Bubble : MonoBehaviour {
	public bool blase;
	//GameObject player_go;
	public GameObject bubble_go;
	//private PlayerMovement playerScript;

	// Use this for initialization
	void Start () {
		//player_go = GameObject.FindGameObjectWithTag ("Player");
		//playerScript = player_go.GetComponent<PlayerMovement> ();
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Player"){
			if(blase == true) {
				bubble_go.SetActive (true);
			}
		}
	}
}