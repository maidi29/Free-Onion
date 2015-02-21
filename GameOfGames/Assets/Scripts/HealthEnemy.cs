using UnityEngine;
using System.Collections;

public class HealthEnemy : MonoBehaviour {
	private EnemyMovement enemyScript;
	public GameObject Paprika;
	public Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		enemyScript = Paprika.GetComponent<EnemyMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (enemyScript.health == 100) {
			anim.SetTrigger ("Health100");
		}
		else if (enemyScript.health == 80) {
			anim.SetTrigger ("Health80");
		}
		else if (enemyScript.health == 60) {
			anim.SetTrigger ("Health60");
		}
		else if (enemyScript.health == 40) {
			anim.SetTrigger ("Health40");
		}
		else if (enemyScript.health == 20) {
			anim.SetTrigger ("Health20");
		}
		else if (enemyScript.health == 0) {
			anim.SetTrigger ("Health0");
		}
	}
}
