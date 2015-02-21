using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public float moveSpeed = 8f;
	GameObject Player;
	private PlayerMovement playerScript;
	public int health = 100;
	public bool dead;

	public Animator animator;
	// Use this for initialization
	void Start () {
		Player = GameObject.Find ("Player");
		playerScript = Player.GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (playerScript.dead == true) {
			animator.SetTrigger("Death");
			moveSpeed = 0f;
		}
	}

	void OnTriggerStay2D (Collider2D collider) {
		if(collider.tag == "MainCamera"){
			rigidbody2D.AddForce (-Vector2.right * moveSpeed);
			/*if (playerScript.jump) {
				rigidbody2D.AddForce (Vector2.up * playerScript.jumpSpeed);
			}*/
		}
	}
	
	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Projectile"){
			DamageEnemy (60);
			Destroy (collider.gameObject);
		}
	}
	public void DamageEnemy(int damage) {
			health -= damage; 
			//von dem was health davor war wird damage abgezogen
			if (health <= 0) {
				health = 0;
				dead = true; 
				Destroy(gameObject);//gameObject verschwindet nach bla Sekunden
			}
	}
}