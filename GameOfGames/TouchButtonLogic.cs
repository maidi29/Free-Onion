using UnityEngine;
using System.Collections;

public class TouchButtonLogic : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		//is there a touch on screen?
		if (Input.touches.Length <= 0) {
			//if no touches on screen then...
		}
		else {
			//if there is a touch
			for (int i = 0; i < Input.touchCount; i++) {
				//executes code for every touch (i) on screen
				if (this.guiTexture.HitTest(Input.GetTouch (i).position)) {//Position of curren touch and checking if it is hitting the gui Texture
					if(Input.GetTouch(i).phase == TouchPhase.Began){
						Debug.Log ("The Touch has begun on " + this.name);
					}
					if(Input.GetTouch(i).phase == TouchPhase.Ended) {
						Debug.Log ("The Touch has ended on " + this.name);
					}
				}
			}
		}
	}
}