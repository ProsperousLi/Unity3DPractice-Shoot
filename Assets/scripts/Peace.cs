using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Peace : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter() {

			GameObject.Find ("ShootNumber").GetComponent<Text> ().text = "碰撞了，GG";

			GameObject.Find ("Point light").GetComponent<Light> ().enabled = false;

			Destroy (gameObject, 2);
	}
}
