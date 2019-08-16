using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class UpgradeCostAndLevelConfig : MonoBehaviour {
	public Text CarrotSpawnRateInfo;
	public Text CarrotEffectInfo;
	public Text UmbrellaDurabilityInfo;
	public Text UmbrellaSizeInfo;
	public Text Tree1Text;
	public Text Tree2Text;
	public Text Tree3Text;
	public Text Tree1Info;
	public Text Tree2Info;
	public Text Tree3Info;
	public Text HealthRegenInfo;
	public Text Coins;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Coins.text = ("" + Stats.totalcoins);

		if (Stats.CarrotSpawnRate == 15) {
			CarrotSpawnRateInfo.text = ("         MAX");
		}
		else {
			CarrotSpawnRateInfo.text = ("Cost: " + Stats.CarrotSpawnRateUpgradeCost + " lvl: " + Stats.CarrotSpawnRateLVL);
		}

		if (Stats.CarrotEffect == 100) {
			CarrotEffectInfo.text = ("         MAX");
		}
		else {
			CarrotEffectInfo.text = ("Cost: " + Stats.CarrotEffectUpgradeCost + " lvl: " + Stats.CarrotEffectLVL);
		}

		if (Stats.UmbrellaDurability == 5000f) {
			UmbrellaDurabilityInfo.text = ("         MAX");
		}
		else {
			UmbrellaDurabilityInfo.text = ("Cost: " + Stats.UmbrellaDurabilityUpgradeCost + " lvl: " + Stats.UmbrellaDurabilityLVL); 
		}
		if (Stats.UmbrellaSize > 0.09f) {
			UmbrellaSizeInfo.text = ("         MAX");
		}
		else {
			UmbrellaSizeInfo.text = ("Cost: " + Stats.UmbrellaSizeUpgradeCost + " lvl: " + Stats.UmbrellaSizeLVL);
		}


		if (Stats.Tree1Bought == 0) {
			Tree1Text.text = ("Buy Right Tree"); 
		} else {
			Tree1Text.text = ("Upgrade Size");
		}

		if (Stats.Tree2Bought == 0) {
			Tree2Text.text = ("Buy Middle Tree"); 
		} else {
			Tree2Text.text = ("Upgrade Size");
		}

		if (Stats.Tree3Bought == 0) {
			Tree3Text.text = ("Buy Left Tree"); 
		} else {
			Tree3Text.text = ("Upgrade Size");
		}



		if (Stats.Tree1Bought == 0) {
			Tree1Info.text = ("Cost: " + Stats.BuyTreesCost);
		} else if (Stats.Tree1Size < 3f) {
			Tree1Info.text = ("Cost: " + Stats.Tree1SizeUpgradeCost + " lvl: " + Stats.Tree1SizeLVL);
		} else {
			Tree1Info.text = ("           MAX");
		}

		if (Stats.Tree2Bought == 0) {
			Tree2Info.text = ("Cost: " + Stats.BuyTreesCost);
		} else if (Stats.Tree2Size < 3f) {
			Tree2Info.text = ("Cost: " + Stats.Tree2SizeUpgradeCost + " lvl: " + Stats.Tree2SizeLVL);
		} else {
			Tree2Info.text = ("           MAX");
		}

		if (Stats.Tree3Bought == 0) {
			Tree3Info.text = ("Cost: " + Stats.BuyTreesCost);
		} else if (Stats.Tree3Size < 3f) {
			Tree3Info.text = ("Cost: " + Stats.Tree3SizeUpgradeCost + " lvl: " + Stats.Tree3SizeLVL);
		} else {
			Tree3Info.text = ("           MAX");
		}








		if (Stats.HealthRegenTime == 0.5f) {
			HealthRegenInfo.text = ("          MAX");
		} else {
			HealthRegenInfo.text = ("Cost: " + Stats.HealthRegenCost + " lvl: " + Stats.HealthRegenLVL);
		}

	}
}
