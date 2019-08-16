using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown () {
		Stats.score = 0;

		Stats.currentumbdur = Stats.UmbrellaDurability;

		BunnyScript.BunnyHealth = BunnyScript.BunnyStartingHealth;
		BunnyScript.BunnyMaxHealth = BunnyScript.BunnyStartingHealth;
		BunnyScript.BunnyAlive = true;
		CarrotScript.carrotspawnable = true;
		Application.LoadLevel ("GamePlay");
	}
}
