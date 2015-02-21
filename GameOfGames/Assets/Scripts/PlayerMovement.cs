using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float moveSpeed = 5f;
	float jumpSpeed = 36f;
	public bool dead = false;
	public bool jump = false;
	public int health = 100;
	public float deathCooldown;
	bool grounded = true;
	int jumpcount;
	int maxjumps = 2;
	public GameObject blase;

	//public bool grounded = true;
	
	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator> ();
		if (animator == null) {
			Debug.LogError ("Didn't find animator!");
		}
	}

	void Update () {
		if (dead) {
			deathCooldown -= Time.deltaTime;
		}

		if (Input.GetKey ("escape")){
			Application.LoadLevel ("LevelOverview");
		}

		if (!grounded) {
			rigidbody2D.gravityScale = 11;
		}
		else if (grounded) {
			rigidbody2D.gravityScale = 1;	
		}
		if (health >= 100) {
			health = 100;
		}
	}

	void FixedUpdate () {
		if (dead) {
			return;
		}

		rigidbody2D.AddForce (Vector2.right * moveSpeed);

		if (jump) {
			if (jumpcount >= maxjumps) {
				return;
			}

			else if (jumpcount >= 1) {
				animator.SetTrigger ("Jump");
				Vector2 force = (transform.up * (jumpSpeed -= 5)) / Time.fixedDeltaTime;
				rigidbody2D.AddForce(force);
				jump = false;
				jumpcount++;
			}

			else {
				grounded = false;
				Vector2 force = (transform.up * jumpSpeed) / Time.fixedDeltaTime;
				rigidbody2D.AddForce (force);
				jump = false;
				jumpcount++;
			}
		}
	}

	public void DamagePlayer(int damage) {

		health -= damage; 
		//von dem was health davor war wird damage abgezogen
		if (health <= 0) {
			health = 0;
			dead = true;
			animator.SetTrigger ("Death");
			deathCooldown = 0.5f;
		}
	}

	void OnTriggerEnter2D (Collider2D collider) {
		if(collider.tag == "Knife"){
			if (blase.activeInHierarchy) {
				blase.SetActive (false);
			}
			else {
				DamagePlayer (20);
			}
			Destroy (collider.gameObject);
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		if (collision.gameObject.tag == "Enemy") {
			if (blase.activeInHierarchy) {
				blase.SetActive (false);
			}
			else {
				DamagePlayer(40);
			}
		}
		jumpcount = 0;
		jumpSpeed = 36f;
		grounded = true;
	}

	void OnCollisionExit2D (Collision2D collision) {
		grounded = false;
	}
}