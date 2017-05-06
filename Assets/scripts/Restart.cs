using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	public AudioSource music;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {

}



	void OnGUI() {
		if (GUI.Button (new Rect (160, 100, 60, 30), "退 出")) {

			Application.Quit ();
		}

		if (GUI.Button (new Rect (280, 100, 60, 30), "重新开始")) {
			
			SceneManager.LoadScene ("scene1");
		}

		if (GUI.Button (new Rect (10, 160, 100, 50), "Play")) {
			if (!music.isPlaying) {
				music.Play ();
			}
		}

		if (GUI.Button (new Rect (10, 220, 100, 50), "Pause")) {
			if (music.isPlaying) {
				music.Pause ();
			}
		}

		if (GUI.Button (new Rect (10, 280, 100, 50), "Stop")) {
			if (music.isPlaying) {
				music.Stop ();
			}
		}
	}

}
