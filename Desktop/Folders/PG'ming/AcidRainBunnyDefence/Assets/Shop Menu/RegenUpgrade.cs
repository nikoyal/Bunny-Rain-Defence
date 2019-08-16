using UnityEngine;
using System.Collections;

public class RegenUpgrade : MonoBehaviour {
	
	void OnMouseDown (){
		Debug.Log ("HPRegenUpgrade Clicked!");
		if (Stats.totalcoins >= Stats.HealthRegenCost) {
			if (Stats.HealthRegenTime > 0.5f) {
				Stats.HealthRegenTime -= 0.5f;
				Stats.HealthRegenLVL += 1;
				Stats.totalcoins -= Stats.HealthRegenCost;
				Stats.HealthRegenCost += 100;
			}
		}
	}
}
