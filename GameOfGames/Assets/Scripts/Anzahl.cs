using UnityEngine;
using System.Collections;

public class Anzahl : MonoBehaviour {
	static int anzahl = 0;
	static int highScore1 = 0;
	static Anzahl instance;
	static public void AddPoint() {
		if (instance.player.dead)
			return;
		anzahl++;
		if (anzahl > highScore1) {
			highScore1 = anzahl;
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
		highScore1 = PlayerPrefs.GetInt ("highScore1", 0);

	}
	void OnDestroy () {
		instance = null;
		PlayerPrefs.SetInt("highScore1", highScore1);
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Friends saved:  " + anzahl;
	}
}