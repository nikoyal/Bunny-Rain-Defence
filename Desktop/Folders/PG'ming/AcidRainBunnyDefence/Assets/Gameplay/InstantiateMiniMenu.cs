using UnityEngine;
using System.Collections;

public class InstantiateMiniMenu : MonoBehaviour {
	public Transform MiniMenu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (BunnyScript.BunnyAlive == false) {
			Object.Instantiate (MiniMenu, transform.position, Quaternion.identity);
		}
	}
}
