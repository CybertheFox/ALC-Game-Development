using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

	public int power = 4;
	
	public GameObject batterySpawn;
	public GameObject Flashlight;

	GameObject Player;

	int checkBat;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindWithTag("Player");

		Flashlight = Player;

		checkBat = Flashlight.gameObject.GetComponentInChildren<Flashlight>().currentPower;
		print("CkBat = "+checkBat);

	}
	
	// Update is called once per frame
	void Update () {
			checkBat = Flashlight.gameObject.GetComponentInChildren<Flashlight>().currentPower;
	}

	void OnCollisionEnter(Collision other){
		if(other.gameObject.tag == "Player" && checkBat == 0){
			Flashlight.gameObject.GetComponentInChildren<Flashlight>().currentPower = power;
			Destroy(gameObject);
			batterySpawn.gameObject.GetComponentInChildren<BatterySpawn>().BatteryPickup();
		}
	}

}
