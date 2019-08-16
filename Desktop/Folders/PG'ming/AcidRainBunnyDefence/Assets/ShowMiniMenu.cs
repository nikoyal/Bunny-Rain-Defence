using UnityEngine;
using System.Collections;

public class ShowMiniMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BunnyScript.BunnyAlive == false) {
			transform.position = new Vector3(0, 0, -3);
		}
	}
}
