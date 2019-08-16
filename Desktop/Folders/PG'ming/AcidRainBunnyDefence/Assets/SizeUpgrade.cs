using UnityEngine;
using System.Collections;

public class SizeUpgrade : MonoBehaviour {

	void OnMouseDown (){
		Debug.Log ("SizeUpgrade Clicked!");
		if (Stats.totalcoins >= Stats.UmbrellaSizeUpgradeCost) {
			if (Stats.UmbrellaSize <= 0.09f) {
				Stats.UmbrellaSize += 0.01f;
				Stats.UmbrellaSizeLVL += 1;
				Stats.totalcoins -= Stats.UmbrellaSizeUpgradeCost;
				Stats.UmbrellaSizeUpgradeCost += 25;
			}
		}
	}
}
