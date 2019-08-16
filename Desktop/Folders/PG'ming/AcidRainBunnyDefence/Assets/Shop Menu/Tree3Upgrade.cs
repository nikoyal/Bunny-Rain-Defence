using UnityEngine;
using System.Collections;

public class Tree3Upgrade : MonoBehaviour {
	
	void OnMouseDown (){
		Debug.Log ("Tree3Upgrade Clicked!");
		if (Stats.Tree3Bought == 0) {
			if (Stats.totalcoins >= Stats.BuyTreesCost) {
				Stats.Tree3Bought = 1;
				Stats.totalcoins -= Stats.BuyTreesCost;
				Stats.BuyTreesCost += Stats.BuyTreesCost;
			}
		}
		else {
			if (Stats.totalcoins >= Stats.Tree3SizeUpgradeCost) {
				if (Stats.Tree3Size < 3f) {
					Stats.Tree3SizeLVL += 1;
					Stats.Tree3Size += 0.5f;
					Stats.totalcoins -= Stats.Tree3SizeUpgradeCost;
					Stats.Tree3SizeUpgradeCost += 50;
				}
			}
		}
	}
}
