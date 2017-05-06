using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunC : MonoBehaviour {
	
	public int shootNumber = 0;

	public int speed = 5;

	public int Number = 0;
	// string text = "";

	//public int underGround = 0;

	public Transform gunShoot;

	public 
	//Use this for initialization
	void Start () {
		//GameObject.Find ("Main Camera").GetComponent<Restart> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {



		float x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;

		float z = Input.GetAxis("Vertical")*Time.deltaTime*speed;

		transform.Translate (x, 0, z);


		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Transform newObject = Instantiate (gunShoot, transform.position, transform.rotation);

			Vector3 forwd = transform.TransformDirection (Vector3.forward);

			//newObject.GetComponent<Rigidbody>().Addforce (forwd * 280);

			newObject.GetComponent<Rigidbody> ().AddForce (forwd * 2800);

			Number++;
		

			//GameObject.Find ("ShootNumber").GetComponent<Text>().text = "射击数：" + Number ; //找场景控件

			Destroy (newObject.gameObject, 3);
		}

		if (Input.GetKey (KeyCode.Q)) {
		
			transform.Rotate (0, -25 * Time.deltaTime, 0, Space.Self);

		}

		if (Input.GetKey (KeyCode.E)) {
		
		
			transform.Rotate (0, 25 * Time.deltaTime, 0, Space.Self);
		}

		if (Input.GetKey (KeyCode.Z)) {
		
			transform.Translate (0, 5 * Time.deltaTime, 0);
		}

		if (Input.GetKey (KeyCode.C)) {
		
			transform.Translate (0, -5 * Time.deltaTime, 0);
		}
	}
}
