using UnityEngine;
using System.Collections;

public class Tree1Upgrade : MonoBehaviour {

	void OnMouseDown (){
		Debug.Log ("Tree1Upgrade Clicked!");
		if (Stats.Tree1Bought == 0) {
			if (Stats.totalcoins >= Stats.BuyTreesCost) {
				Stats.Tree1Bought = 1;
				Stats.totalcoins -= Stats.BuyTreesCost;
				Stats.BuyTreesCost += Stats.BuyTreesCost;
			}
		}
		else {
			if (Stats.totalcoins >= Stats.Tree1SizeUpgradeCost) {
				if (Stats.Tree1Size < 3f) {
					Stats.Tree1SizeLVL += 1;
					Stats.Tree1Size += 0.5f;
					Stats.totalcoins -= Stats.Tree1SizeUpgradeCost;
					Stats.Tree1SizeUpgradeCost += 50;
				}
			}
		}
	}
}
