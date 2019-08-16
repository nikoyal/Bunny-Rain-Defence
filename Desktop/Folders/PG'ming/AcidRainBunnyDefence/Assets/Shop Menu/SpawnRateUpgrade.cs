using UnityEngine;
using System.Collections;

public class SpawnRateUpgrade : MonoBehaviour {
	void OnMouseDown (){
		Debug.Log ("SpawnRateUpgrade Clicked!");
		if (Stats.totalcoins > Stats.CarrotSpawnRateUpgradeCost){
			if (Stats.CarrotSpawnRate > 15f) {
				Stats.CarrotSpawnRate -= 5f;
				Stats.CarrotSpawnRateLVL += 1;
				Stats.totalcoins -= Stats.CarrotSpawnRateUpgradeCost;
				Stats.CarrotSpawnRateUpgradeCost += 15;
			}
		}
	}
}
