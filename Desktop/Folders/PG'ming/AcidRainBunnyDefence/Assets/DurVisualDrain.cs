﻿using UnityEngine;
using System.Collections;

public class DurVisualDrain : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.localScale = new Vector3((Stats.currentumbdur/Stats.UmbrellaDurability),1,1);
	}
}
