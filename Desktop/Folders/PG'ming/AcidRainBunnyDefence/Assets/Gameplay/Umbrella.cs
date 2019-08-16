using UnityEngine;
using System.Collections;

public class Umbrella : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale += new Vector3 (Stats.UmbrellaSize,0f,0f);
	}

	// Update is called once per frame
	void Update () 
	{
		if (Stats.currentumbdur <= 0) {
			Destroy (gameObject);
		}

		//Debug.Log ("Durability" + StatContainer.currentumbdur);
		if (BunnyScript.BunnyAlive == true) {
			transform.Translate (Input.acceleration.x * Stats.UmbrellaSpeed, 0, 0);
		}
	}

	void OnParticleCollision (GameObject Particle){
		if (Particle.gameObject.tag == "Rain") {
			Stats.currentumbdur -= 1;
		}
	}
}