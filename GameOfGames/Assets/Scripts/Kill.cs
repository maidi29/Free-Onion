using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {
	public GameObject Player; //game Object mit dem Namen player aufrufen
	private PlayerMovement playerScript; //Demo Klasse aufrufen und Name playerScript vergeben
	public int damage;
	
	
	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");
		playerScript = Player.GetComponent<PlayerMovement>();

		//Demo.DamagePlayer(); wenn DamagePlayer static wäre
	}
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D(Collision2D collision) {
		if(collision.gameObject.name == "Player"){
			//playerScript.animator.SetTrigger ("Death");
			playerScript.DamagePlayer (damage);
		}
	}

}