using UnityEngine;
using System.Collections;

public class save : MonoBehaviour {

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Save", 2f , 2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void Save (){
		PlayerPrefs.SetInt ("totalcoins", Stats.totalcoins);
		PlayerPrefs.SetInt ("PersonalBest", Stats.personalbest);
		PlayerPrefs.SetInt ("CarrotSpawnRateLvL", Stats.CarrotSpawnRateLVL);
		PlayerPrefs.SetFloat ("CarrotSpawnRate", Stats.CarrotSpawnRate);
		PlayerPrefs.SetInt ("CarrotSpawnRateUpgradeCost", Stats.CarrotSpawnRateUpgradeCost);
		PlayerPrefs.SetInt ("CarrotEffectLvL", Stats.CarrotEffectLVL);
		PlayerPrefs.SetFloat ("CarrotEffect", Stats.CarrotEffect);
		PlayerPrefs.SetInt ("CarrotEffectUpgradeCost", Stats.CarrotEffectUpgradeCost);
		PlayerPrefs.SetInt ("UmbrellaDurabilityLvL", Stats.UmbrellaDurabilityLVL);
		PlayerPrefs.SetFloat ("UmbrellaDurability", Stats.UmbrellaDurability);
		PlayerPrefs.SetInt ("UmbrellaDurabilityUpgradeCost", Stats.UmbrellaDurabilityUpgradeCost);
		PlayerPrefs.SetInt ("UmbrellaSizeLvL", Stats.UmbrellaSizeLVL);
		PlayerPrefs.SetFloat ("UmbrellaSize", Stats.UmbrellaSize);
		PlayerPrefs.SetInt ("UmbrellaSizeUpgadeCost", Stats.UmbrellaSizeUpgradeCost);
		PlayerPrefs.SetInt ("Tree1Bought", Stats.Tree1Bought);
		PlayerPrefs.SetInt ("Tree1LvL", Stats.Tree1SizeLVL);
		PlayerPrefs.SetFloat ("Tree1Size", Stats.Tree1Size);
		PlayerPrefs.SetInt ("Tree1UpgradeCost", Stats.Tree1SizeUpgradeCost);
		PlayerPrefs.SetInt ("Tree2Bought", Stats.Tree2Bought);
		PlayerPrefs.SetInt ("Tree2LvL", Stats.Tree2SizeLVL);
		PlayerPrefs.SetFloat ("Tree2Size", Stats.Tree2Size);
		PlayerPrefs.SetInt ("Tree2UpgradeCost", Stats.Tree2SizeUpgradeCost);
		PlayerPrefs.SetInt ("Tree3Bought", Stats.Tree3Bought);
		PlayerPrefs.SetInt ("Tree3LvL", Stats.Tree3SizeLVL);
		PlayerPrefs.SetFloat ("Tree3Size", Stats.Tree3Size);
		PlayerPrefs.SetInt ("Tree3UpgradeCost", Stats.Tree3SizeUpgradeCost);
		PlayerPrefs.SetInt ("BuyTreeCost", Stats.BuyTreesCost);
		PlayerPrefs.Save ();
	}

}
