using UnityEngine;
using System.Collections;

public class friendssaved3 : MonoBehaviour {
	int highScore3;
	public GUISkin skin;

	// Use this for initialization
	void Start () {
		highScore3 = PlayerPrefs.GetInt ("highScore3", 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI () {
		GUI.Box (new Rect (1050, 340, 150, 50), "Friends saved: " + highScore3, skin.GetStyle ("Default"));
	}
}