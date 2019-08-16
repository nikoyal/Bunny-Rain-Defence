using UnityEngine;
using System.Collections;

public class MiddleTree : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.localScale += new Vector3 (Stats.Tree2Size,Stats.Tree2Size,0);
		if (Stats.Tree2Bought == 1 && Stats.Tree2Size < 1f) {
			transform.position = new Vector3 (0.31f,-2.3f,-1f);
		}

		if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 1f) {
			transform.position = new Vector3 (0.31f, -2f, -1f);
		} else if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 1f) {
			transform.position = new Vector3 (0.31f, -2.05f, -1f);
		} else if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 1.50f) {
			transform.position = new Vector3 (0.31f, -1.83f, -1f);
		} else if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 2f) {
			transform.position = new Vector3 (0.31f, -1.62f, -1f);
		} else if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 2.5f) {
			transform.position = new Vector3 (0.31f, -1.42f, -1f);
		} else if (Stats.Tree2Bought == 1 && Stats.Tree2Size == 3f){
			transform.position = new Vector3 (0.31f, -1.22f, -1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
