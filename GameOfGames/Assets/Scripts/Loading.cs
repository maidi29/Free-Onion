using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Application.GetStreamProgressForLevel("Level1") ==1){
			Application.LoadLevelAsync("Level1");
		}
	}
}
