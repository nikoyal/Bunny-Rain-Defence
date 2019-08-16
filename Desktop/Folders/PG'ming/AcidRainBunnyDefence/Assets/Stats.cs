using UnityEngine;
using System.Collections;
public class Stats : MonoBehaviour {
	public static int gamesplayed = 0;

	public static int coins = 0;
	public static int totalcoins = 0;
	public static int score = 0;

	public static int personalbest = 0;
	public static float UmbrellaSpeed = 0.1f;
	public static float currentumbdur = 500;

	public static int CarrotSpawnRateLVL = 1;
	public static float CarrotSpawnRate = 35f;
	public static int CarrotSpawnRateUpgradeCost = 15;


	public static int UmbrellaDurabilityLVL = 1;
	public static float UmbrellaDurability = 500;
	public static int UmbrellaDurabilityUpgradeCost = 30;

	public static int UmbrellaSizeLVL = 1;
	public static float UmbrellaSize = 0f;
	public static int UmbrellaSizeUpgradeCost = 25;


	public static int CarrotEffectLVL = 1;
	public static float CarrotEffect = 20;
	public static int CarrotEffectUpgradeCost = 25;


	public static int HealthRegenLVL = 1;
	public static float HealthRegenTime = 4f;
	public static int HealthRegenCost = 100;


	public static int BuyTreesCost = 250;

	public static int Tree1Bought = 0;
	public static float Tree1Size = 0;
	public static int Tree1SizeLVL = 1;
	public static int Tree1SizeUpgradeCost = 50;

	public static int Tree2Bought = 0;
	public static float Tree2Size = 0;
	public static int Tree2SizeLVL = 1;
	public static int Tree2SizeUpgradeCost = 50;

	public static int Tree3Bought = 0;
	public static float Tree3Size =0;
	public static int Tree3SizeLVL = 1;
	public static int Tree3SizeUpgradeCost = 50;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("AddCoins", 4.0f, 2.0f);
		InvokeRepeating ("AddScore", 1.5f, 1.5f);
	}

	// Update is called once per frame
	void Update () {
		if (Stats.personalbest >= 10) {
		}

		if (score > personalbest) {
			personalbest = score;
		}
		//Debug.Log (" " + coins);
	}

	void AddCoins (){       
		if (BunnyScript.BunnyAlive == true) {
			coins += 1;

		}
	}

	void AddScore (){
		if (BunnyScript.BunnyAlive == true) {
			score += 1;
		}
	}

}