using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {
	private PlayerMovement playerScript;
	public GameObject Player;
	public Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		playerScript = Player.GetComponent<PlayerMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerScript.health == 100) {
			anim.SetTrigger ("Health100");
		}
		else if (playerScript.health == 80) {
			anim.SetTrigger ("Health80");
		}
		else if (playerScript.health == 60) {
			anim.SetTrigger ("Health60");
		}
		else if (playerScript.health == 40) {
			anim.SetTrigger ("Health40");
		}
		else if (playerScript.health == 20) {
			anim.SetTrigger ("Health20");
		}
		else if (playerScript.health == 0) {
			anim.SetTrigger ("Health0");
		}
	}
}
