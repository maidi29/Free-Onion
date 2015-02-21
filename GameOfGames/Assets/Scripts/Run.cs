using UnityEngine;
using System.Collections;

public class Run : MonoBehaviour {
	public string levelName;

	void OnMouseDown() {
		Application.LoadLevel(levelName);
	}
}
