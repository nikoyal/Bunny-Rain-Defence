using UnityEngine;
using System.Collections;

public class Tree2Upgrade : MonoBehaviour {

	void OnMouseDown (){
		Debug.Log ("Tree2Upgrade Clicked!");
		if (Stats.Tree2Bought == 0) {
			if (Stats.totalcoins >= Stats.BuyTreesCost) {
				Stats.Tree2Bought = 1;
				Stats.totalcoins -= Stats.BuyTreesCost;
				Stats.BuyTreesCost += Stats.BuyTreesCost;
			}
		}
		else {
			if (Stats.totalcoins >= Stats.Tree2SizeUpgradeCost) {
				if (Stats.Tree2Size < 3f) {
					Stats.Tree2SizeLVL += 1;
					Stats.Tree2Size += 0.5f;
					Stats.totalcoins -= Stats.Tree2SizeUpgradeCost;
					Stats.Tree2SizeUpgradeCost += 50;
				}
			}
		}
	}
}
