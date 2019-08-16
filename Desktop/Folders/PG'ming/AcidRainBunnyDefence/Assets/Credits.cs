using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
	void OnMouseDown (){
		Debug.Log ("Credits");
		Application.LoadLevel ("Credits");
	}
}
