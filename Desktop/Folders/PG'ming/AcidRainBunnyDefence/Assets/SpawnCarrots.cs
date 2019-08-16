using UnityEngine;
using System.Collections;

public class SpawnCarrots : MonoBehaviour {
	public Transform Carrot;
	public float y = -3.441f;
	public float xMin = 6.57f;
	public float xMax = -6.64f;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnCarrot",Stats.CarrotSpawnRate,Stats.CarrotSpawnRate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnCarrot (){
		if (CarrotScript.carrotspawnable == true) {
			Vector2 loc = new Vector2 (Random.Range (xMin, xMax), y);
			Object.Instantiate (Carrot, loc, Quaternion.identity);
			CarrotScript.carrotspawnable = false;
		}
	}
}
