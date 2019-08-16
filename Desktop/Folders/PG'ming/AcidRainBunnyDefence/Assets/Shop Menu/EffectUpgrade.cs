using UnityEngine;
using System.Collections;

public class EffectUpgrade : MonoBehaviour {
	void OnMouseDown (){
		Debug.Log ("CarrotEffectUpgrade Clicked!");
		if (Stats.totalcoins >= Stats.CarrotEffectUpgradeCost) {
			if (Stats.CarrotEffect < 100) {
				Stats.CarrotEffect += 10;
				Stats.CarrotEffectLVL += 1;
				Stats.totalcoins -= Stats.CarrotEffectUpgradeCost;
				Stats.CarrotEffectUpgradeCost += 25;
			}
		}
	}
}
