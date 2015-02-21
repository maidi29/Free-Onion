using UnityEngine;
using System.Collections;

public class CameratracksPlayer : MonoBehaviour {

	Transform player;
	float offsetX;
	float offsetY;


	// Use this for initialization
	void Start () {
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");

		if (player_go == null) {
				Debug.LogError ("Couldn't find an object with tag 'Player'!");
				return;
		}

		player = player_go.transform;
		offsetX = transform.position.x - player.position.x;
		offsetY = transform.position.y - player.position.y;
	}
	// Update is called once per frame
	void Update () {
		if (player != null) {
			Vector3 pos = transform.position;
			pos.x = player.position.x + offsetX;
			pos.y = player.position.y + offsetY;
			transform.position = pos;
		}
	}

	void OnTriggerExit2D (Collider2D collider) {
		if (collider.tag == "Projectile") {
			Destroy (collider.gameObject);
		}
		else if (collider.tag == "Knife") {
			Destroy (collider.gameObject);
		}
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Knife") {
			collider.GetComponent<ShootingScriptEnemy>().shoot = true;
		}
	}
}