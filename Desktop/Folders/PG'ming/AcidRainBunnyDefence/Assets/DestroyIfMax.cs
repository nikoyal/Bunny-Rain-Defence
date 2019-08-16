using UnityEngine;
using System.Collections;

public class DestroyIfMax : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TextsConfig.UmbDurMax == true) {
			Destroy (gameObject);
		}
	}
}
