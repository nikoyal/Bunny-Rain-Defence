using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TextsConfig : MonoBehaviour {
	public Text Coins;
	public Text TotalCoins;
	public Text Score;
	public Text PersonalBest;
	public Text HealthDisplay;
	public Text DurabilityDisplay;
	public static bool UmbDurMax = false;
	//public Text PersonalBest;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		Coins.text = ("Collected: " + Stats.coins);
		Score.text = ("Score: " + Stats.score);
		HealthDisplay.text = (BunnyScript.BunnyHealth + "/" + BunnyScript.BunnyMaxHealth);
		if (Stats.UmbrellaDurability == 5000f){
			UmbDurMax = true;
		}
		else{
			DurabilityDisplay.text = (Stats.currentumbdur + "/" + Stats.UmbrellaDurability);
		}
		if (BunnyScript.BunnyAlive == false) {
			PersonalBest.text = ("Best: " + Stats.personalbest);
			TotalCoins.text = ("Coins: " + Stats.totalcoins);
		} 
		else{
			PersonalBest.text = ("");
			TotalCoins.text = ("");
		}
	}
}
