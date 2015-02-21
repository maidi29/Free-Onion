using UnityEngine;
using System.Collections;

public class MouseButtonRight : MonoBehaviour {

	public GameObject Shooting;
	private ShootingScript shootingScript;
	public GameObject Player;
	private PlayerMovement playerScript;

	
	
	void Start () {
		shootingScript = Shooting.GetComponent<ShootingScript> ();
		playerScript = Player.GetComponent<PlayerMovement> ();
	}

	void OnMouseDown() {
		if (playerScript.deathCooldown <= 0) {
			Application.LoadLevel (Application.loadedLevel);
		}
		else {
			shootingScript.shoot = true;
		}
	}

	void OnMouseUp() {
	}
}
