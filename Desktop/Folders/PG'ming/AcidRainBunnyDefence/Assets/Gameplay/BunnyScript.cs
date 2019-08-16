using UnityEngine;
using System.Collections;

public class BunnyScript : MonoBehaviour {
	Animator BunnyAnimator;
	public Transform HpVisualForeGround;
	float RandomNumber = 0;
	float RandomMovementTime = 0;
	public static float BunnyHealth = 100;
	public static float BunnyStartingHealth = 100;
	public static float BunnyMaxHealth = 100;
	public static bool BunnyAlive = true;
	bool LeftBorderHit = false;
	bool RightBorderHit = false;
	bool ActiveEvents = false;
	bool RegenActive = true;
	float RegenCD = 5;

	// Use this for initialization

	void Start () {
		BunnyAnimator = GetComponent<Animator> ();
		InvokeRepeating ("RandomMovement",RandomMovementTime,RandomMovementTime);
		InvokeRepeating ("HPRegen",Stats.HealthRegenTime,Stats.HealthRegenTime);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (Stats.gamesplayed);
		if (RegenActive == false) {
			RegenCD -= Time.deltaTime;
			if (RegenCD <= 0) {
				RegenActive = true;
				RegenCD = 5;
			}
		}


		//Debug.Log ("CurrHP ---" + BunnyScript.BunnyHealth);
		//Debug.Log ("MAXHP ---" + BunnyScript.BunnyMaxHealth);

			
		if (CarrotScript.carroteffectrabit == true) {
			if (BunnyHealth <= BunnyMaxHealth - Stats.CarrotEffect) {
				BunnyHealth += Stats.CarrotEffect;
			} 
			else if (BunnyHealth >= BunnyMaxHealth - Stats.CarrotEffect && BunnyHealth < BunnyMaxHealth) {
				BunnyHealth += BunnyMaxHealth - BunnyHealth;
			}
			if (BunnyMaxHealth < 1000) {
				BunnyMaxHealth += Stats.CarrotEffect;
				BunnyHealth += Stats.CarrotEffect;
				transform.localScale += new Vector3 (0.2f, 0.2f, 0);
			}
			CarrotScript.carroteffectrabit = false;
			CarrotScript.OnCarrot = false;
		}

		if (BunnyHealth <= 0) {
			Destroy (gameObject);
			BunnyAlive = false;
			Stats.gamesplayed += 1;
			if (Stats.totalcoins < 999) {
				if (Stats.coins + Stats.totalcoins > 999) {
					Stats.totalcoins += 999 - Stats.totalcoins;
				}
				else
					Stats.totalcoins += Stats.coins;

			}
			Stats.coins = 0;
		}

		if (ActiveEvents == false) {
			if (RightBorderHit == true) {
				BunnyAnimator.SetBool ("Standing", false);
				BunnyAnimator.SetBool ("MoveRight", false);
				BunnyAnimator.SetBool ("MoveLeft", true);
				transform.position -= transform.right * 1 * Time.deltaTime;
			} else if (LeftBorderHit == true) {
				BunnyAnimator.SetBool ("Standing", false);
				BunnyAnimator.SetBool ("MoveLeft", false);
				BunnyAnimator.SetBool ("MoveRight", true);
				transform.position -= transform.right * -1 * Time.deltaTime;
			} else if (RandomNumber == 1) {
				BunnyAnimator.SetBool ("Standing", false);
				BunnyAnimator.SetBool ("MoveRight", false);
				BunnyAnimator.SetBool ("MoveLeft", true);
				transform.position -= transform.right * 1 * Time.deltaTime;
			} else if (RandomNumber == 2) {
				BunnyAnimator.SetBool ("MoveRight", false);
				BunnyAnimator.SetBool ("MoveLeft", false);
				BunnyAnimator.SetBool ("Standing", true);
				transform.position -= transform.right * 0 * Time.deltaTime;
			} else if (RandomNumber == 3) {
				BunnyAnimator.SetBool ("Standing", false);
				BunnyAnimator.SetBool ("MoveLeft", false);
				BunnyAnimator.SetBool ("MoveRight", true);
				transform.position -= transform.right * -1 * Time.deltaTime;
			}
			if (RandomMovementTime <= 0f) {
				RandomMovement ();
			}
			RandomMovementTime -= Time.deltaTime;
			//Debug.Log (RandomMovementTime);
		} 
	}



	void RandomMovement (){
		RandomNumber = Random.Range (1,4);
		RandomMovementTime = Random.Range (3f, 7f);
		LeftBorderHit = false;
		RightBorderHit = false;
		//Debug.Log (RandomNumber);
		//Debug.Log (RandomMovementTime);
	}

	void HPRegen () {
		if (RegenActive == true) {
			if (BunnyHealth < BunnyMaxHealth) {
				BunnyHealth += 1;
			}
		}
	}



	void OnCollisionEnter2D (Collision2D Collider) {
		if (Collider.gameObject.tag == "BorderRight") {
			RightBorderHit = true;
			//Debug.Log ("right");
		}
		if (Collider.gameObject.tag == "BorderLeft") {
			LeftBorderHit = true;
			//Debug.Log ("left");
		}
	}



	void OnParticleCollision (GameObject Particle){
		if (Particle.gameObject.tag == "Rain") {
			BunnyHealth -= 10;
			RegenActive = false;
		}
	}



	void OnTriggerEnter2D (Collider2D Trigger){
		if (Trigger.gameObject.tag == "Carrot") {
				CarrotScript.OnCarrot = true;
		}
	}
}
