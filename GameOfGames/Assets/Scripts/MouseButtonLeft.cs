using UnityEngine;
using System.Collections;

public class MouseButtonLeft : MonoBehaviour {
	public GameObject Player;
	private PlayerMovement playerScript;
	

	void Start () {
		playerScript = Player.GetComponent<PlayerMovement> ();
	}

	void Update () {
	}

	void OnMouseDown() {
		if (playerScript.deathCooldown <= 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
		else {
			playerScript.jump = true;
		}
	}

	void OnMouseUp() {
		playerScript.jump = false;
	 }
}