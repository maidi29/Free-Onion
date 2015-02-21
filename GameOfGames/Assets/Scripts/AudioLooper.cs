using UnityEngine;
using System.Collections;

public class AudioLooper : MonoBehaviour {
	
		static AudioLooper instance;

		void Start(){
			if(instance == null)
			{
				instance = this;
				DontDestroyOnLoad(gameObject);
			}
			else if (instance != this)
			{
				Destroy(gameObject);
			}
		}
}