using UnityEngine;
using System.Collections;

public class Demo : MonoBehaviour {
	public int health;
	public string[] arrayString;
	public enum WeaponType {
		sword,
		knife,
		bow
	}
	public WeaponType weapontype;

	void Start () {

		arrayString = new string[5]; //Arrays sind Objekte, deshalb werden sie mit new initialisiert, 5 empy Spaces
		arrayString [0] = "I'm cool.";
		arrayString [1] = "You're not.";
	}

	/*void Update () {
		switch (weapontype) {
		case WeaponType.sword:
			print ("Sword");
			break;
		case WeaponType.knife:
			print ("Knife");
			break;
		default:
			print ("Yeah");
			break;
		}
	}*/

	public void DamagePlayer(int damage) {
		health -= damage; 
		//von dem was health davor war wird damage abgezogen
		if (health <= 0) {
			health = 0;
			Destroy (gameObject, 5.5f); 
			//gameObject verschwindet nach 5.5 Sekunden
			Debug.Log ("The Player is dead. Health: "+ health);
		}
	
		else if (health >= 15){
		print ("You are very healthy. Health: "+ health);
		}
	}
}
