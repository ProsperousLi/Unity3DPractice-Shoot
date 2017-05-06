using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class underTheGround : MonoBehaviour {

	//public static int underGroundShootNumber = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (gameObject.transform.position.y < 0) {
		
			GameObject.Find ("Main Camera").GetComponent<GunC> ().shootNumber++;

			//print (underGroundShootNumber);

			if (GameObject.Find ("Main Camera").GetComponent<GunC> ().shootNumber > 1) {

				GameObject.Find("ShootNumber").GetComponent<Text>().text = "恭喜过关";
				GameObject.Find ("Main Camera").GetComponent<GunC> ().enabled = false;
				GameObject.Find ("land").GetComponent<Restart> ().enabled = true;
			}

			Destroy (gameObject);
		}

		if (GameObject.Find ("Main Camera").GetComponent<GunC> ().shootNumber <= 1) {

			GameObject.Find ("ShootNumber").GetComponent<Text> ().text = "射击数" + GameObject.Find ("Main Camera").GetComponent<GunC> ().Number + " " + GameObject.Find ("Main Camera").GetComponent<GunC> ().shootNumber;
		}
	}
}
