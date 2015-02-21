using UnityEngine;
using System.Collections;

public class Anzahl2 : MonoBehaviour {
	static int anzahl = 0;
	static int highScore2 = 0;
	static Anzahl2 instance;
	static public void AddPoint() {
		if (instance.player.dead)
			return;
		anzahl++;
		if (anzahl > highScore2) {
			highScore2 = anzahl;
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
		highScore2 = PlayerPrefs.GetInt ("highScore2", 0);
		
	}
	void OnDestroy () {
		instance = null;
		PlayerPrefs.SetInt("highScore2", highScore2);
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Friends saved:  " + anzahl;
	}
}