using UnityEngine;
using System.Collections;

public class DurabilityUpgrade : MonoBehaviour {

	void OnMouseDown () {
		Debug.Log ("DurabilityUpgrade Clicked!");
		if (Stats.totalcoins >= Stats.UmbrellaDurabilityUpgradeCost) {
			if (Stats.UmbrellaDurability < 5000f) {
				Stats.UmbrellaDurability += 500f;
				Stats.UmbrellaDurabilityLVL += 1;
				Stats.totalcoins -= Stats.UmbrellaDurabilityUpgradeCost;
				Stats.UmbrellaDurabilityUpgradeCost += 30;
			}
		}
	}
}
