using UnityEngine;
using System.Collections;

public class Anzahl3 : MonoBehaviour {
	static int anzahl = 0;
	static int highScore3 = 0;
	static Anzahl3 instance;
	static public void AddPoint() {
		if (instance.player.dead)
			return;
		anzahl++;
		if (anzahl > highScore3) {
			highScore3 = anzahl;
		}
	}
	
	PlayerMovement player;
	// Use this for initialization
	void Start () {
		instance = this;
		GameObject player_go = GameObject.FindGameObjectWithTag ("Player");
		if (player_go == null) {
			Debug.LogError ("Could not find object with tag 'Player'!");
		}
		player = player_go.GetComponent<PlayerMovement> ();
		anzahl = 0;
		highScore3 = PlayerPrefs.GetInt ("highScore3", 0);
		
	}
	void OnDestroy () {
		instance = null;
		PlayerPrefs.SetInt("highScore3", highScore3);
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Friends saved:  " + anzahl;
	}
}