using UnityEngine;
using System.Collections;

public class DeleteStats : MonoBehaviour {

	// Use this for initialization
	void Awake () {
		PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
