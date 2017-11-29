﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour {

	public bool lightOn = true;
	//Flashlight Power capacity
	public int maxPower = 4;
	//Usable flashlight power
	public int currentPower;

	public int batDrainAmt;

	public float batDrainDelay;

	Light light;

	//Gets Battery UI Text
	public Text batteryText;

	// Use this for initialization
	void Start () {
		//Add pwer to flashlight
		currentPower = maxPower;
		print("power = " + currentPower);

		light = GetComponent<Light> ();
		lightOn = true;
		print("Turn light on when Flashlight is initiated");
		light.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//Toggle light on/off when F key is pressed
		if (Input.GetKeyUp (KeyCode.F) && lightOn) {
			print("Light Off");
			lightOn = false;
			light.enabled = false;

		}

		else if (Input.GetKeyUp (KeyCode.F) && !lightOn){
			print("Light Off");
			lightOn = true;
			light.enabled = true;
		}

		//Update Battery UI text
		batteryText.text = currentPower.ToString();

		//Drain Batter Life
		if(currentPower > 0){
			StartCoroutine(BatteryDrain(batDrainDelay,batDrainAmt));
		}
	}

	public void setLightOn(){
		lightOn = true;
	}

	public bool isLightOn(){
		return lightOn;
	
	}

	IEnumerator Battery(float delay, int amount){
		yield return new WaitForSeconds(delay);
		currentPower -= amount;
		if(currentPower <= 0){
			current Power = 0;
			print("Battery is dead!");
			light.enabled = false;
	
		}
	}

}