using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Flashlight : MonoBehaviour {

	public bool lightOn = true;
	//Flashlight Power capacity
	public int maxPower = 4;
	//Useable flashlight power
	public int currentPower;

	Light light;

	// Use this for initialization
	void Start () {
		//Add pwer to flashlight
		currentPower = maxPower;
		print("power = " + currentPower);

		light = GetComponent<Light> ();
		lightOn = true;
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.F) && lightOn) {
			lightOn = false;
			light.enabled = false;

		}

		else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
			lightOn = true;
			light.enabled = true;
		}
	}
	public void setLightOn(){
		lightOn = true;
	}

	public bool isLightOn(){
		return lightOn;
	}
}
