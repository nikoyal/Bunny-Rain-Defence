﻿using UnityEngine;
using System.Collections;

public class HpVisualDrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3((BunnyScript.BunnyHealth/BunnyScript.BunnyMaxHealth),1,1);
	}
}
