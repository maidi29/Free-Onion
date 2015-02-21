using UnityEngine;
using System.Collections;

public class friendssaved2 : MonoBehaviour {
	int highScore2;
	public GUISkin skin;

	// Use this for initialization
	void Start () {
		highScore2 = PlayerPrefs.GetInt ("highScore2", 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI () {
		GUI.Box (new Rect (650, 340, 150, 50), "Friends saved: " + highScore2, skin.GetStyle ("Default"));
	}
}