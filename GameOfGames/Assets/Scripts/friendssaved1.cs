using UnityEngine;
using System.Collections;

public class friendssaved1 : MonoBehaviour {
	int highScore1;
	public GUISkin skin;

	// Use this for initialization
	void Start () {
		highScore1 = PlayerPrefs.GetInt ("highScore1", 0);
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI () {
		GUI.Box (new Rect (250, 340, 150, 50), "Friends saved: " + highScore1, skin.GetStyle ("Default"));
	}
}