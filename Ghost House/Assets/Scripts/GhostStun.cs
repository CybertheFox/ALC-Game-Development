﻿using UnityEngine;
using System.Collections;

public class GhostStun : MonoBehaviour {

	bool lightCheck;
	Flashlight flash;
	public GameObject ghost;


	// Use this for initialization

	void Start () {
		//print ("Obj:" + gameObject.GetComponentInChildren<Light>().GetComponent<FlashLight());
		flash = gameObject.GetComponentInChildren<Light>().GetComponentInChildren<Flashlight>();
		//bool test = gameObject.GetComponentInChildren<Light>().Flashlight.isLightOn();
		//print("Test;" + test);
		print("Obj:" + flash);
		flash.setLightOn();
		print ("Start" + flash.isLightOn ());

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){
		print(other.gameObject.name);
		print ("Collider" + flash);
		if(other.gameObject.name == "Ghost" && flash == true){
			print("Ghost is Stunned!");
			// other.GetCompnent<Rigidbody>().velocity = Vector3.zero;
			// other.GetCompnent<Rigidbody>().angularVelocity = Vector3.zero;

			other.GetComponent<GhostAI>().moveSpeed = 0f;
			StartCoroutine(Wait(5, other));	
			// StopCoroutine(Wait(5));

		}
	}

	IEnumerator Wait(float time, Collider other){
			yield return new WaitForSeconds(time);
			ghost.gameObject.GetComponent<GhostAI>().moveSpeed = 5f;
			print("Ghost is unstunned");
	
	}



	
}