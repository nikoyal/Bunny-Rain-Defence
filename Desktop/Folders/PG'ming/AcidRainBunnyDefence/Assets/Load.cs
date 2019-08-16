using UnityEngine;
using System.Collections;

public class Load : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		Stats.totalcoins = PlayerPrefs.GetInt ("totalcoins");
		Stats.personalbest = PlayerPrefs.GetInt ("PersonalBest");

		Stats.CarrotSpawnRateLVL = PlayerPrefs.GetInt ("CarrotSpawnRateLvL");
		if (Stats.CarrotSpawnRateLVL == 0) {
			Stats.CarrotSpawnRateLVL = 1;
		}
		Stats.CarrotSpawnRate = PlayerPrefs.GetFloat ("CarrotSpawnRate");
		if (Stats.CarrotSpawnRate == 0) {
			Stats.CarrotSpawnRate = 35f;
		}
		Stats.CarrotSpawnRateUpgradeCost = PlayerPrefs.GetInt ("CarrotSpawnRateUpgradeCost");
		if (Stats.CarrotSpawnRateUpgradeCost == 0) {
			Stats.CarrotSpawnRateUpgradeCost = 15;
		}
		Stats.CarrotEffectLVL = PlayerPrefs.GetInt ("CarrotEffectLvL");
		if (Stats.CarrotEffectLVL == 0) {
			Stats.CarrotEffectLVL = 1;
		}
		Stats.CarrotEffect = PlayerPrefs.GetFloat ("CarrotEffect");
		if (Stats.CarrotEffect == 0) {
			Stats.CarrotEffect = 20;
		}
		Stats.CarrotEffectUpgradeCost = PlayerPrefs.GetInt ("CarrotEffectUpgradeCost");
		if (Stats.CarrotEffectUpgradeCost == 0) {
			Stats.CarrotEffectUpgradeCost = 25;
		}
		Stats.UmbrellaDurabilityLVL = PlayerPrefs.GetInt ("UmbrellaDurabilityLvL");
		if (Stats.UmbrellaDurabilityLVL == 0) {
			Stats.UmbrellaDurabilityLVL = 1;
		}
		Stats.UmbrellaDurability = PlayerPrefs.GetFloat ("UmbrellaDurability");
		if (Stats.UmbrellaDurability == 0) {
			Stats.UmbrellaDurability = 500;
		}
		Stats.UmbrellaDurabilityUpgradeCost = PlayerPrefs.GetInt ("UmbrellaDurabilityUpgradeCost");
		if (Stats.UmbrellaDurabilityUpgradeCost == 0) {
			Stats.UmbrellaDurabilityUpgradeCost = 30;
		}
		Stats.UmbrellaSizeLVL = PlayerPrefs.GetInt ("UmbrellaSizeLvL");
		if (Stats.UmbrellaSizeLVL == 0) {
			Stats.UmbrellaSizeLVL = 1;
		}
		Stats.UmbrellaSize = PlayerPrefs.GetFloat ("UmbrellaSize");

		Stats.UmbrellaSizeUpgradeCost = PlayerPrefs.GetInt ("UmbrellaSizeUpgadeCost");
		if (Stats.UmbrellaSizeUpgradeCost == 0) {
			Stats.UmbrellaSizeUpgradeCost = 25;
		}
		Stats.Tree1Bought = PlayerPrefs.GetInt ("Tree1Bought");

		Stats.Tree1SizeLVL = PlayerPrefs.GetInt ("Tree1LvL");
		if (Stats.Tree1SizeLVL == 0) {
			Stats.Tree1SizeLVL = 1;
		}
		Stats.Tree1Size = PlayerPrefs.GetFloat ("Tree1Size");

		Stats.Tree1SizeUpgradeCost = PlayerPrefs.GetInt ("Tree1UpgradeCost");
		if (Stats.Tree1SizeUpgradeCost == 0) {
			Stats.Tree1SizeUpgradeCost = 50;
		}
		Stats.Tree2Bought = PlayerPrefs.GetInt ("Tree2Bought");

		Stats.Tree2SizeLVL = PlayerPrefs.GetInt ("Tree2LvL");
		if (Stats.Tree2SizeLVL == 0) {
			Stats.Tree2SizeLVL = 1;
		}
		Stats.Tree2Size = PlayerPrefs.GetFloat ("Tree2Size");
		Stats.Tree2SizeUpgradeCost = PlayerPrefs.GetInt ("Tree2UpgradeCost");
		if (Stats.Tree2SizeUpgradeCost == 0) {
			Stats.Tree2SizeUpgradeCost = 50;
		}
		Stats.Tree3Bought = PlayerPrefs.GetInt ("Tree3Bought");

		Stats.Tree3SizeLVL = PlayerPrefs.GetInt ("Tree3LvL");
		if (Stats.Tree3SizeLVL == 0) {
			Stats.Tree3SizeLVL = 1;
		}
		Stats.Tree3Size = PlayerPrefs.GetFloat ("Tree3Size");
		Stats.Tree3SizeUpgradeCost = PlayerPrefs.GetInt ("Tree3UpgradeCost");
		if (Stats.Tree3SizeUpgradeCost == 0) {
			Stats.Tree3SizeUpgradeCost = 0;
		}
		Stats.BuyTreesCost = PlayerPrefs.GetInt ("BuyTreeCost");
		if (Stats.BuyTreesCost == 0) {
			Stats.BuyTreesCost = 250;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
