using UnityEngine;
using System.Collections;

public class ShootingScript : MonoBehaviour {
	public Transform shootOutOf;
	public GameObject shootObject;
	public bool shoot;
	public float shootSpeed;
	public float rateOfFire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (shoot == true) {
			StartCoroutine(Fire());
			audio.Play ();
		}
	}

	IEnumerator Fire () {
		GameObject projectile = Instantiate (shootObject, shootOutOf.position, shootOutOf.rotation) as GameObject;
		projectile.rigidbody2D.velocity = new Vector2 (shootSpeed, 0);
		shoot = false;
		yield return new WaitForSeconds (rateOfFire);
	}
}
