using UnityEngine;
using System.Collections;

public class ShootingScriptEnemy : MonoBehaviour {
	public bool shoot;
	public float shootSpeed;
	public float beforeShoot;

	Animator animator;
	
	// Use this for initialization
	void Start () {
		animator = transform.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (shoot == true) {
			//GameObject knife = Instantiate (shootObject, shootOutOf.position, shootOutOf.rotation) as GameObject;
			gameObject.rigidbody2D.velocity = new Vector2 (-shootSpeed, 0);
			animator.SetTrigger ("Shoot");
		}
	}
}
